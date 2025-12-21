using GameLabProject.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GameLabProject.Services
{
    public class RawgService
    {
        // RAWG API Key'ini buraya yapıştır (Aldığın o anahtar)
        private readonly string _apiKey = "cb3f5c724dfc42f4a4d67d0645e8d290";
        private readonly string _baseUrl = "https://api.rawg.io/api/games";

        public RawgService()
        {
            // Constructor
        }

        // Method to fetch details (Genre, Image, Rating) for a single game
        public void GetGameDetails(SteamGame game)
        {
            if (game == null || string.IsNullOrEmpty(game.name)) return;

            // Encode the game name for URL (e.g., "CS: GO" -> "CS%3A+GO")
            string encodedName = WebUtility.UrlEncode(game.name);

            // Construct the API URL
            // We request only the top 1 result (page_size=1) for accuracy
            string url = $"{_baseUrl}?key={_apiKey}&search={encodedName}&page_size=1";

            try
            {
                using (WebClient client = new WebClient())
                {
                    // Ensure correct character encoding
                    client.Encoding = Encoding.UTF8;

                    // Download JSON data string
                    string jsonResponse = client.DownloadString(url);

                    // Parse JSON
                    JObject data = JObject.Parse(jsonResponse);
                    var results = data["results"];

                    // Check if we found any game
                    if (results != null && results.HasValues)
                    {
                        // Get the best match (first result)
                        var bestMatch = results[0];

                        // Map JSON data to our SteamGame object

                        // 1. Background Image URL
                        game.BackgroundImage = bestMatch["background_image"]?.ToString();

                        // 2. Rating (e.g., 4.5)
                        game.Rating = (double?)bestMatch["rating"] ?? 0;

                        // 3. Release Date
                        game.Released = bestMatch["released"]?.ToString();

                        // 4. Genres (List of genres)
                        var genres = bestMatch["genres"];
                        if (genres != null)
                        {
                            string genreList = "";
                            foreach (var genre in genres)
                            {
                                genreList += genre["name"] + ", ";
                            }
                            // Remove trailing comma and space
                            game.Genre = genreList.TrimEnd(',', ' ');
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error silently or debug
                System.Diagnostics.Debug.WriteLine("RAWG API Error: " + ex.Message);
            }
        }
    }
}
