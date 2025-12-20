using GameLabProject.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLabProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string myApiKey = "D9749B5DC06A3B879A9A4F08E106973E";
            string mySteamId = "76561199539057555";

            SteamService service = new SteamService();

            this.Text = "Steam oyunları getiriliyor...";

            var oyunListesi = await service.GetUserGames(myApiKey, mySteamId);

            gridControl1.DataSource = oyunListesi;
        }
    }
}
