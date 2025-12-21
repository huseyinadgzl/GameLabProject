using GameLabProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net; 
using Newtonsoft.Json; 
using Newtonsoft.Json.Linq; 
using System.IO;
namespace GameLabProject
{
    public partial class MainScreenForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
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
                    List<SteamGame> oyunListesi = oyunlarJson.ToObject<List<SteamGame>>();

                    // 6. Grid'e Yükle
                    gridControl1.DataSource = oyunListesi;

                    MessageBox.Show($"Tebrikler! {oyunListesi.Count} adet oyun başarıyla çekildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
