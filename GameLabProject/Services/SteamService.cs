using GameLabProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GameLabProject.Services
{
    public class SteamService
    {
        public async Task<List<SteamGame>> GetUserGames(string apiKey, string steamId)
        {
            // include_appinfo=1 : Oyunun sadece ID'sini değil, adını ve resmini de getir demek.
            string url = $"http://api.steampowered.com/IPlayerService/GetOwnedGames/v0001/?key={apiKey}&steamid={steamId}&format=json&include_appinfo=1";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // İsteği gönderiyoruz...
                    string jsonResponse = await client.GetStringAsync(url);

                    // Gelen veriyi çözüyoruz...
                    var data = JsonConvert.DeserializeObject<SteamResponse>(jsonResponse);

                    // Veri var mı kontrolü
                    if (data != null && data.response != null && data.response.games != null)
                    {
                        return data.response.games;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("BİR HATA OLUŞTU: " + ex.Message);
                }
            }
            return new List<SteamGame>(); // Hata varsa boş liste dön
        }
    }
}
