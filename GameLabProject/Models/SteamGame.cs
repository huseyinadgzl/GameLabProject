using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLabProject.Models;

namespace GameLabProject.Models
{
    public class SteamGame
    {

        public int appid { get; set; }
        public string name { get; set; }
        public int playtime_forever { get; set; }
        public string img_icon_url { get; set; }

        public string Genre { get; set; }         
        public double Rating { get; set; }       
        public string BackgroundImage { get; set; } 
        public string Description { get; set; }

    }
    public class SteamResponse
    {
        public SteamGameList response { get; set; }
    }
    public class SteamGameList
    {
        public int game_count { get; set; }
        public List<SteamGame> games { get; set; }
    }
}
