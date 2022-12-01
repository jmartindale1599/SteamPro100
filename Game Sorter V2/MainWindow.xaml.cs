﻿using Game_Sorter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using IGDB;
using IGDB.Models;
//using IGDB.ImageHelper;
using System.Diagnostics;
using System.IO;

namespace Game_Sorter_V2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        string[] listGames = new string[300];

        public MainWindow()
        {

            InitializeComponent();
            listboxGames.Items.Clear();
        
        }

        public async Task<string> GetPictures(string name)
        {
            IGDBClient client = new IGDBClient(
                Environment.GetEnvironmentVariable("IGDB_CLIENT_ID"),

                Environment.GetEnvironmentVariable("IGDB_CLIENT_SECRET")

                );

            var games = await client.QueryAsync<Game>(IGDBClient.Endpoints.Games, query: ("fields name, artworks.image_id; search \"" + name + "\";  limit 1;"));
            try
            {
            var game = games.First();
            Debug.WriteLine(game.Artworks.Values.First().ImageId); // id = 4 // name = Thief
            var artworkImageId = game.Artworks.Values.First().ImageId;

            // Thumbnail
            var thumb2X = IGDB.ImageHelper.GetImageUrl(imageId: artworkImageId, size: ImageSize.Thumb, retina: true);
            Debug.WriteLine(thumb2X.ToString());

            return "https:" + thumb2X.ToString();
            }
            catch { return "NOT FOUND"; }
            //return thumb2X.ToString();
        }
        //
        //"fields id, name; search \"astroneer\";"

            List<Gamedudes> theboys = new List<Gamedudes>();

        private async void Button_Click(object sender, RoutedEventArgs e)
        {

            //theboys.Add(new Gamedudes("Astroneer"));
            //theboys.Add(new Gamedudes("Equilinox"));
            //theboys.Add(new Gamedudes("Crypt of the NecroDancer"));
            //theboys.Add(new Gamedudes("Aim Lab"));
            //theboys.Add(new Gamedudes("Escape Simulator"));

            theboys.Add(new Gamedudes(filePathtxt.Text));
            //List<string> names = new List<string>();
            //List<string> theboys = new List<string>();



            foreach (Gamedudes boy in theboys)
            {
                boy.Artwork = (await GetPictures(boy.Name));
            }

            //lvDataBinding.ItemsSource = theboys;

            //this.InitializeComponent();

            //var theboy = await GetPictures("astroneer");
            //testlbl.Content = theboy;
            /*listboxGames.ItemsSource = null;
            listboxGames.ItemsSource = theboys;

            */

            listboxGames.ItemsSource = null;

            listboxGames.ItemsSource = theboys;

        }

        private class Gamedudes
        {
            public Gamedudes(string name) {
                this.Name = name;
                this.Artwork = "";
            }
            public string Name { get; set; }
            public string Artwork { get; set; }

        }

        public async void GeneratePerp(string name){

            IGDBClient client = new IGDBClient(

                Environment.GetEnvironmentVariable("IGDB_CLIENT_ID"),

                Environment.GetEnvironmentVariable("IGDB_CLIENT_SECRET")

                );

            var games = await client.QueryAsync<Character>(IGDBClient.Endpoints.Characters, query: ("fields akas, description, slug, url; search \"" + name + "\";  limit 1;"));

            ReturnDesc.Content = "";

            ReturnDesc.Content = "Name:";

            var character = games.First();
            
            for(int i = 0; i < games.Length; i++){

                ReturnDesc.Content += character.Slug + "\n";

                if (character.Gender == Gender.Male){

                    ReturnDesc.Content += "Gender: Male \n";
                
                }else if (character.Gender == Gender.Female){

                    ReturnDesc.Content += "Gender: Female \n";

                }else {

                    ReturnDesc.Content += "Gender: Other \n";

                }

                ReturnDesc.Content += character.Description;

            }

            ReturnSite.Content = "";

            ReturnSite.Content += character.Url;
            
        }

        private void bring_it_up_Click(object sender, RoutedEventArgs e){

            GeneratePerp(userNameInput.Text);

        }

    }

}