using Game_Sorter;
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
    
    public partial class MainWindow : Window{

        string[] listGames = new string[300];

        public MainWindow(){
        
            InitializeComponent();
        
        }

        public async Task<string> GetPictures(string name)
        {
            IGDBClient client = new IGDBClient(
                Environment.GetEnvironmentVariable("IGDB_CLIENT_ID"),
            
                Environment.GetEnvironmentVariable("IGDB_CLIENT_SECRET")
            
                );

            var games = await client.QueryAsync<Game>(IGDBClient.Endpoints.Games, query: ("fields name, artworks.image_id; search \"" + name + "\";  limit 1;"));
            var game = games.First();
            Debug.WriteLine(game.Artworks.Values.First().ImageId); // id = 4 // name = Thief
            var artworkImageId = game.Artworks.Values.First().ImageId;

            // Thumbnail
            var thumb2X = IGDB.ImageHelper.GetImageUrl(imageId: artworkImageId, size: ImageSize.Thumb, retina: true);
            Debug.WriteLine(thumb2X.ToString());

            return "https:" + thumb2X.ToString();
        }
        //
        //"fields id, name; search \"astroneer\";"

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            List<string> names = new List<string>();
            List<string> theboys = new List<string>();

            names.Add("Astroneer");
            names.Add("Equilinox");
            names.Add("Crypt of the NecroDancer");
            names.Add("Aim Lab");
            names.Add("Escape Simulator");

            foreach (string name in names)
            {
                theboys.Add(await GetPictures(name));
            }

            this.InitializeComponent();
            


            //theboy.Delay(5000).ContinueWith(t => {
            //    Debug.WriteLine("lol you waited hahahahaha");
            //});


            var theboy = await GetPictures("astroneer");
            testlbl.Content = theboy;

            //BackendEngine vented = new BackendEngine();
            ///Task t1 = new Task(vented.GetAuthorizationJson);
            //t1.RunSynchronously();
            //t1.Wait();

            //vented.GetPicture("Astroneer");
            
            //testlbl.Content = BackendEngine.auth;
            //Task<string> sussy = Task<string>.Factory.StartNew(() => {
            //Task t1 = new Task(vented.GetAuthorizationJson);
            // t1.Start();

            //Task<string> task = vented.GetPicture("Astroneer");
            //while(t1.Status == TaskStatus.Running)
            //{

            //}


            //return vented.GetPicture("astroneer").Result.ToString();
            //});
            //sussy.Wait();
            //testlbl.Content = BackendEngine.Picture;

        }

        private void VideoGameList_SelectionChanged(object sender, SelectionChangedEventArgs e){



        }

    }

}
