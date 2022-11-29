using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using IGDB;
using IGDB.Models;

namespace Game_Sorter
{
    internal class BackendEngine
    {




        public async Task<string> GetGames()
        {
            IGDBClient client = new IGDBClient(
                Environment.GetEnvironmentVariable("IGDB_CLIENT_ID"),
                Environment.GetEnvironmentVariable("IGDB_CLIENT_SECRET")
            );

            var games = await client.QueryAsync<Game>(IGDBClient.Endpoints.Games, query: "fields id, name; where id = 4;");
            var game = games.First();
            Debug.WriteLine( game.Name); // id = 4 // name = Thief
            
            return game.Name;
        }

        /* static string auth { get; set; }
        public static string Picture { get; set; }
        

        /// <summary>
        /// This Function connects to the data base.
        /// </summary>
        public async void GetAuthorizationJson() {

            HttpClient client = new HttpClient();

            //~~//we will have to have ablitly to set the ID and secret later as they change every so often.//~~//
            KeyValuePair<string, string> clientID = new KeyValuePair<string, string>("client_id", "ukinm8oq8njkab73c59c1b0vpmv69h");
            KeyValuePair<string, string> clientSecret = new KeyValuePair<string, string>("client_secret", "k8rc3jc89pgez5jw7ca4491epgakz2");
            KeyValuePair<string, string> grantType = new KeyValuePair<string, string>("grant_type", "client_credentials");

            var data = new StringContent("", Encoding.UTF8, "application/json");

            var url = "https://id.twitch.tv/oauth2/token?" + clientID.Key + "=" + clientID.Value + "&" + clientSecret.Key + "=" + clientSecret.Value + "&" + grantType.Key + "=" + grantType.Value;

            HttpResponseMessage response = await client.PostAsync(url, data);

            response.EnsureSuccessStatusCode();
                
            string resp = await response.Content.ReadAsStringAsync();

            Console.WriteLine(resp);

            JsonDocument amongus = JsonDocument.Parse(resp);
            JsonElement IamGroot = amongus.RootElement;
            auth = IamGroot.GetProperty("access_token").ToString();
            //auth will = the auth instead of a buch of jason googlygook

        }

        public async void GetPicture(string name) {

            HttpClient client = new HttpClient();

            //~~//we will have to have ablitly to set the ID and secret later as they change every so often.//~~//
            KeyValuePair<string, string> clientID = new KeyValuePair<string, string>("client_id", "ukinm8oq8njkab73c59c1b0vpmv69h");
            KeyValuePair<string, string> clientAuth = new KeyValuePair<string, string>("Authorization", "Bearer " + auth);

            client.DefaultRequestHeaders.Add(clientID.Key, clientID.Value);
            client.DefaultRequestHeaders.Add(clientAuth.Key, clientAuth.Value);
            var raw = "fields name, cover.url; search \"" + name + "\"; limit 1;";
            var data = new StringContent(raw, Encoding.UTF8, "text/plain");

            var url = "https://api.igdb.com/v4/games";// + clientID.Key + "=" + clientID.Value + "&" + clientAuth.Key + "=" + clientAuth.Value;
            

            HttpResponseMessage response = await client.PostAsync(url, data);

            //response.EnsureSuccessStatusCode();

            string resp = await response.Content.ReadAsStringAsync();

            Console.WriteLine(resp);

            JsonDocument amongus = JsonDocument.Parse(resp);
            JsonElement IamGroot = amongus.RootElement;
            Picture = IamGroot.GetProperty("cover").GetProperty("url").ToString();
            Console.WriteLine(Picture);
            
            //return auth;



            //picture will = the auth instead 

        }*/

    }
}
