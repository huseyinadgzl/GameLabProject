using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Newtonsoft.Json.Linq;
using GameLabProject.Models;

namespace GameLabProject.Services
{
    internal class RecommendationService
    {
        private readonly string _apiKey = "cb3f5c724dfc42f4a4d67d0645e8d290";
        private readonly string _baseUrl = "https://api.rawg.io/api/games";

        // Yardımcı servisimiz (Detay çekmek için)
        private RawgService _rawgService = new RawgService();

        // ANA METOT: Analiz Et ve Öner
        public List<SteamGame> GetRecommendations(List<SteamGame> userLibrary)
        {
            List<SteamGame> recommendedGames = new List<SteamGame>();

            // 1. Kütüphane boşsa boş dön
            if (userLibrary == null || userLibrary.Count == 0) return recommendedGames;

            // 2. En çok oynanan ilk 10 oyunu al
            var top10Games = userLibrary
                             .OrderByDescending(x => x.playtime_forever)
                             .Take(10)
                             .ToList();

            // 3. Bu 10 oyunun türlerini (Genre) analiz etmemiz lazım.
            // Ancak Steam verisinde tür yok. Hızlıca RAWG'dan türlerini öğrenmeliyiz.
            // (Bu işlem 3-4 saniye sürebilir, kullanıcıya "Analiz ediliyor" diyeceğiz)

            Dictionary<string, int> genreCounts = new Dictionary<string, int>();

            foreach (var game in top10Games)
            {
                // Oyunun detaylarını çek (RawgService'deki metodu kullanıyoruz)
                // Not: RawgService'deki metodu "void" yerine "SteamGame" döndüren bir yapıya çevirmek gerekebilir
                // Ama şimdilik nesne referansı üzerinden gidiyoruz, sorun yok.
                _rawgService.GetGameDetails(game);

                // Oyunun türlerini sayaca ekle
                if (!string.IsNullOrEmpty(game.Genre))
                {
                    // Türler "Action, RPG, Shooter" gibi virgüllü geliyor. Onları ayır.
                    var genres = game.Genre.Split(',');
                    foreach (var g in genres)
                    {
                        string cleanGenre = g.Trim(); // Boşlukları temizle
                        if (genreCounts.ContainsKey(cleanGenre))
                            genreCounts[cleanGenre]++;
                        else
                            genreCounts.Add(cleanGenre, 1);
                    }
                }
            }

            // 4. En çok tekrar eden TOP 2 türü bul (Yapay Zeka Mantığı Burası)
            // Örn: Action (8 kere), RPG (6 kere), Strategy (1 kere) -> Action ve RPG seçilir.
            var topGenres = genreCounts.OrderByDescending(x => x.Value).Take(2).Select(x => x.Key).ToList();

            if (topGenres.Count == 0) return recommendedGames; // Tür bulamadıysak dön

            // 5. RAWG'a bu türlere uygun YENİ oyunları sormaya gidiyoruz
            // Sorgu: genres=action,rpg & ordering=-rating (Puanı yüksek olsun)

            // Tür isimlerini küçük harfe çevirip virgülle birleştir (api formatı: action,rpg)
            string genreQuery = string.Join(",", topGenres).ToLower();

            // API Çağrısı
            // string url = $"{_baseUrl}?key={_apiKey}&genres={genreQuery}&ordering=-metacritic&page_size=5";
            Random rnd = new Random();
            int randomPage = rnd.Next(1, 10);

            // 3. URL'in sonuna "&page={randomPage}" ekle
            string url = $"{_baseUrl}?key={_apiKey}&genres={genreQuery}&ordering=-metacritic&page_size=5&page={randomPage}";

            try
            {
                using (WebClient client = new WebClient())
                {
                    client.Encoding = System.Text.Encoding.UTF8;
                    string json = client.DownloadString(url);

                    JObject data = JObject.Parse(json);
                    var results = data["results"];

                    if (results != null)
                    {
                        foreach (var result in results)
                        {
                            // Kendi kütüphanemizde VARSA önerme (Yeni oyun istiyoruz)
                            string gameName = result["name"].ToString();

                            // Basit bir kontrol: İsim kütüphanede geçiyor mu?
                            bool alreadyOwned = userLibrary.Any(u => u.name.ToLower().Contains(gameName.ToLower()));

                            if (!alreadyOwned)
                            {
                                SteamGame newGame = new SteamGame();
                                newGame.name = gameName;
                                newGame.BackgroundImage = result["background_image"]?.ToString();
                                newGame.Rating = (double?)result["rating"] ?? 0;
                                newGame.Genre = string.Join(", ", topGenres); // Bulduğumuz türleri yazalım

                                recommendedGames.Add(newGame);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Recommendation Error: " + ex.Message);
            }

            return recommendedGames;
        }
    }
}
