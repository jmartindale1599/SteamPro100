using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using SteamKit2.CDN;
using SteamKit2.Internal;

namespace Pro100test
{
    internal class backend
    {

        public string[] getDatabase()
        {

            //string[] database = new string[1000];

            HttpClient client = new HttpClient();

            /*KeyValuePair<string, string> clientID = new KeyValuePair<string, string>("client_id", "ukinm8oq8njkab73c59c1b0vpmv69h");
        
            KeyValuePair<string, string> clientSecret = new KeyValuePair<string, string>("client_secret", "rsx7v0kzkpzo5ejwffh3wufpnhz2hv");
        
            KeyValuePair<string, string> grantType = new KeyValuePair<string, string>("grant_type", "client_credentials");

            client.BaseAddress("https://id.twitch.tv/oauth2/token");

            client.DefaultRequestHeaders.Add(clientID.Key, clientID.Value);
            
            client.DefaultRequestHeaders.Add(clientSecret.Key, clientSecret.Value);
            
            client.DefaultRequestHeaders.Add(grantType.Key, grantType.Value);

            client.body();*/


            //var response = await client.PostAsync(call, content);

            //var responseString = await response.Content.ReadAsStringAsync();

            //var responseString = await client.GetStringAsync("http://www.example.com/recepticle.aspx");

            //return database;



            /*POST https://api.igdb.com/v4/games

            Client-ID: abcdefg12345

            Authorization: Bearer access12345token

            fields*;*/

            string[] holder = new string[4];

            return holder;

        }

    }

}
