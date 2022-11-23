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
using System.Diagnostics;

namespace Game_Sorter_V2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public async Task<string> GetGames()
        {
            IGDBClient client = new IGDBClient(
                Environment.GetEnvironmentVariable("IGDB_CLIENT_ID"),
                Environment.GetEnvironmentVariable("IGDB_CLIENT_SECRET")
            );

            var games = await client.QueryAsync<Game>(IGDBClient.Endpoints.Games, query: "fields id, name; where id = 4;");
            var game = games.First();
            Debug.WriteLine(game.Name); // id = 4 // name = Thief

            return game.Name;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {


            var theboy = await GetGames();

            
            //theboy.Delay(5000).ContinueWith(t => {
            //    Debug.WriteLine("lol you waited hahahahaha");
            //});


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
    }
}
