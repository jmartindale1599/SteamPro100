using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Pro100test{

    internal class Backend {

        var call = "https://id.twitch.tv/oauth2/token";


        public void GetLibrary() {

            HttpClient client = new HttpClient();

             //"//=/=";

            HttpRequestMessage requestu = new HttpRequestMessage(HttpMethod.Get,"https://id.twitch.tv/oauth2/token");

            requestu.Headers.Add("client_id", "ukinm8oq8njkab73c59c1b0vpmv69h");
            
            requestu.Headers.Add("client_secret", "9rprk08hlt1ci4ysb41wey5rvx7i1b");          
            
            requestu.Headers.Add("grant_type", "client_credentials");          

            //client.BaseAddress(call);

        }


    }

    

        /*public string[] getDatabase(){

        string[] database = new string[1000];

        

        

        var values = new Dictionary<string, string>{{ "thing1", "hello" },{ "thing2", "world" }};

        var content = new FormUrlEncodedContent(values);

        var response = await client.PostAsync(call, content);

        var responseString = await response.Content.ReadAsStringAsync();

        var responseString = await client.GetStringAsync("http://www.example.com/recepticle.aspx");

        return database;*/

        

        /*POST https://api.igdb.com/v4/games
        
        Client-ID: abcdefg12345
        
        Authorization: Bearer access12345token
        
        fields*;*/

}
