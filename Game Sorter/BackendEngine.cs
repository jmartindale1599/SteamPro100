using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Game_Sorter
{
    internal class BackendEngine
    {
        
        /// <summary>
        /// This Function connects to the data base.
        /// </summary>
        public void Connect() {

            HttpClient client = new HttpClient();

            //~~//we will have to have ablitly to set the ID and secret later as they change every so often.//~~//
            KeyValuePair<string, string> clientID = new KeyValuePair<string, string>("client_id", "ukinm8oq8njkab73c59c1b0vpmv69h");
            KeyValuePair<string, string> clientSecret = new KeyValuePair<string, string>("client_secret", "rsx7v0kzkpzo5ejwffh3wufpnhz2hv");
            KeyValuePair<string, string> grantType = new KeyValuePair<string, string>("grant_type", "client_credentials");

            client.BaseAddress = new Uri("https://id.twitch.tv/oauth2/token");
            client.DefaultRequestHeaders.Add(clientID.Key, clientID.Value);
            client.DefaultRequestHeaders.Add(clientSecret.Key, clientSecret.Value);
            client.DefaultRequestHeaders.Add(grantType.Key, grantType.Value);
        }
    }
}
