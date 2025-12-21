using DevExpress.XtraGrid.Views.Card;
using GameLabProject.Models;
using GameLabProject.Services;
using Newtonsoft.Json; 
using Newtonsoft.Json.Linq; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLabProject
{
    public partial class MainScreenForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        List<SteamGame> _globalOyunListesi = new List<SteamGame>();
        public MainScreenForm()
        {
            InitializeComponent();
        }
        public void OyunlariListele(List<SteamGame> gelenOyunlar)
        {
           
            if (gelenOyunlar != null && gelenOyunlar.Count > 0)
            {
                gridControl1.DataSource = gelenOyunlar;

                
                navigationFrame1.SelectedPage = navigationPage1; 
            }
        }

        private void btnLibrary_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navigationFrame1.SelectedPage = navigationPage1;
        }

        private void btnProfile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navigationFrame1.SelectedPage = navigationPage2;

            if (_globalOyunListesi == null || _globalOyunListesi.Count == 0)
            {
                lblGameCount.Text = "Veri Yok";
                return;
            }

            // --- İSTATİSTİK HESAPLAMA (LINQ Kullanıyoruz) ---

            // A) Toplam Oyun
            lblGameCount.Text = "Toplam Oyun: " + _globalOyunListesi.Count;

            // B) Toplam Süre (Steam dakika verir, 60'a bölüp saat yaparız)
            // Sum: Hepsini topla
            double toplamDakika = _globalOyunListesi.Sum(x => x.playtime_forever);
            double toplamSaat = Math.Round(toplamDakika / 60, 1); // Virgülden sonra 1 basamak
            lblGameTime.Text = $"Toplam Süre: {toplamSaat} Saat";

            // C) En Çok Oynanan Oyun
            // OrderByDescending: Büyükten küçüğe sırala -> FirstOrDefault: İlkini al
            var favoriOyun = _globalOyunListesi.OrderByDescending(x => x.playtime_forever).FirstOrDefault();
            if (favoriOyun != null)
            {
                lblMostGame.Text = $"Favori Oyun: {favoriOyun.name}";
            }

            
            CizdirGrafik();
        }

        
        private void CizdirGrafik()
        {
            // 1. Önceki grafiği temizle
            chartControl1.Series.Clear();

            // 2. Yeni bir seri oluştur (Bar Grafiği)
            DevExpress.XtraCharts.Series seri = new DevExpress.XtraCharts.Series("En Çok Oynananlar", DevExpress.XtraCharts.ViewType.Bar);

            // 3. En çok oynanan ilk 5 oyunu al
            var ilk5Oyun = _globalOyunListesi
                            .OrderByDescending(x => x.playtime_forever)
                            .Take(5)
                            .ToList();

            // 4. Verileri grafiğe ekle
            foreach (var oyun in ilk5Oyun)
            {
                // X ekseni: Oyun Adı, Y ekseni: Saat (Dakika / 60)
                seri.Points.Add(new DevExpress.XtraCharts.SeriesPoint(oyun.name, oyun.playtime_forever / 60));
            }

            // 5. Seriyi kontrol'e ekle
            chartControl1.Series.Add(seri);
        }

        private void btnSuggest_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navigationFrame1.SelectedPage = navigationPage3;
        }

        private void btnListGame_Click(object sender, EventArgs e)
        {
            string steamId = txtSteamID.Text.Trim(); // Trim boşlukları siler

            // ID boş mu kontrol et
            if (string.IsNullOrEmpty(steamId))
            {
                MessageBox.Show("Lütfen 17 haneli Steam ID'nizi girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. SENİN API KEY'İN (Burası sabit kalacak)
            string apiKey = "D9749B5DC06A3B879A9A4F08E106973E";

            // 3. Adresi Oluştur (Kullanıcıdan gelen ID ile)
            string url = $"http://api.steampowered.com/IPlayerService/GetOwnedGames/v0001/?key={apiKey}&steamid={steamId}&include_appinfo=1&format=json";

            try
            {
                // 4. Veriyi Çek
                using (WebClient client = new WebClient())
                {
                    client.Encoding = System.Text.Encoding.UTF8;
                    string jsonVerisi = client.DownloadString(url);

                    // 5. JSON'u Parçala ve Listeye At
                    JObject genelVeri = JObject.Parse(jsonVerisi);

                    // Oyun listesi "response" -> "games" altında duruyor
                    var oyunlarJson = genelVeri["response"]["games"];

                    if (oyunlarJson == null)
                    {
                        MessageBox.Show("Bu profilde oyun bulunamadı veya profil gizli!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // JSON verisini bizim SteamGame sınıfımıza çeviriyoruz
                    _globalOyunListesi = oyunlarJson.ToObject<List<SteamGame>>();

                    // 6. Grid'e Yükle
                    gridControl1.DataSource = _globalOyunListesi;
                    MessageBox.Show($"Tebrikler! {_globalOyunListesi.Count} adet oyun başarıyla çekildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Services.RawgService _rawgService = new Services.RawgService();

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var selectedGame = gridView1.GetFocusedRow() as SteamGame;

            // Eğer seçim boşsa (liste boşsa) işlem yapma
            if (selectedGame == null) return;

            // 2. Ekrandaki eski bilgileri temizle veya "Yükleniyor..." yaz
            lblGameName.Text = selectedGame.name; // İsim hemen gelsin
            lblGameGenre.Text = "Loading genre...";
            lblGameRating.Text = "Rating: ...";
            imgGameCover.Image = null; // Eski resmi sil

            // 3. API'ye git ve detayları çek (Burası servise gidip geliyor)
            // Not: API hızlı yanıt verirse anlık, yavaşsa yarım saniye takılabilir.
            _rawgService.GetGameDetails(selectedGame);

            // 4. Gelen yeni verileri ekrana bas

            // Türü Yaz
            lblGameGenre.Text = string.IsNullOrEmpty(selectedGame.Genre) ? "Genre: Unknown" : "Genre: " + selectedGame.Genre;

            // Puanı Yaz
            lblGameRating.Text = $"Rating: {selectedGame.Rating}/5";

            // 5. Resmi Yükle (Eğer resim linki geldiyse)
            if (!string.IsNullOrEmpty(selectedGame.BackgroundImage))
            {
                // LoadAsync: Resmi internetten indirirken programı dondurmaz
                imgGameCover.LoadAsync(selectedGame.BackgroundImage);
            }
        }
    }
}
