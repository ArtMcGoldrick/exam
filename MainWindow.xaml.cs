/*************************
 * NAME: Art Mc Goldrick *
 * DATE: 11/12/2019      *
 * DESC: Player display  *
 *************************/

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

namespace exam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Creation of objects
        List<Player> Players = new List<Player>();
        List<Player> selectedPlayers = new List<Player>();
        decimal totalspaces = 11;
        // Create a Random object  
        Random rand = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        //Code for when window loads
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Array for first names
            string[] firstNames = {
                "Adam", "Amelia", "Ava", "Chloe", "Conor", "Daniel", "Emily",
                "Emma", "Grace", "Hannah", "Harry", "Jack", "James",
                "Lucy", "Luke", "Mia", "Michael", "Noah", "Sean", "Sophie"};
            //Array for surnames
            string[] surnames = {
                "Brennan", "Byrne", "Daly", "Doyle", "Dunne", "Fitzgerald", "Kavanagh",
                "Kelly", "Lynch", "McCarthy", "McDonagh", "Murphy", "Nolan", "O'Brien",
                "O'Connor", "O'Neill", "O'Reilly", "O'Sullivan", "Ryan", "Walsh"};

            // Generate a random index less than the size of the array.  
            int index = rand.Next(firstNames.Length);
            int index2 = rand.Next(surnames.Length);

            //To choose random number between 20 and 30
            int age = rand.Next(20, 31);

            //Putting values into the objects
            Player p1 = new Player { FirstName = firstNames[index], Surname = surnames[index2], Age = age, PreferredPosition = Position.Goalkeeper };
            Player p2 = new Player { FirstName = firstNames[index], Surname = surnames[index2], Age = age, PreferredPosition = Position.Defender };
            Player p3 = new Player { FirstName = firstNames[index], Surname = surnames[index2], Age = age, PreferredPosition = Position.Defender };
            Player p4 = new Player { FirstName = firstNames[index], Surname = surnames[index2], Age = age, PreferredPosition = Position.Defender };
            Player p5 = new Player { FirstName = firstNames[index], Surname = surnames[index2], Age = age, PreferredPosition = Position.Midfielder };
            Player p6 = new Player { FirstName = firstNames[index], Surname = surnames[index2], Age = age, PreferredPosition = Position.Midfielder };
            Player p7 = new Player { FirstName = firstNames[index], Surname = surnames[index2], Age = age, PreferredPosition = Position.Midfielder };
            Player p8 = new Player { FirstName = firstNames[index], Surname = surnames[index2], Age = age, PreferredPosition = Position.Foward };
            Player p9 = new Player { FirstName = firstNames[index], Surname = surnames[index2], Age = age, PreferredPosition = Position.Foward };

            Player p10 = new Player { FirstName = firstNames[index], Surname = surnames[index2], Age = age, PreferredPosition = Position.Goalkeeper };
            Player p11 = new Player { FirstName = firstNames[index], Surname = surnames[index2], Age = age, PreferredPosition = Position.Defender };
            Player p12 = new Player { FirstName = firstNames[index], Surname = surnames[index2], Age = age, PreferredPosition = Position.Defender };
            Player p13 = new Player { FirstName = firstNames[index], Surname = surnames[index2], Age = age, PreferredPosition = Position.Defender };
            Player p14 = new Player { FirstName = firstNames[index], Surname = surnames[index2], Age = age, PreferredPosition = Position.Midfielder };
            Player p15 = new Player { FirstName = firstNames[index], Surname = surnames[index2], Age = age, PreferredPosition = Position.Midfielder };
            Player p16 = new Player { FirstName = firstNames[index], Surname = surnames[index2], Age = age, PreferredPosition = Position.Midfielder };
            Player p17 = new Player { FirstName = firstNames[index], Surname = surnames[index2], Age = age, PreferredPosition = Position.Foward };
            Player p18 = new Player { FirstName = firstNames[index], Surname = surnames[index2], Age = age, PreferredPosition = Position.Foward };

            //Adding these objects to a list
            Players.Add(p1);
            Players.Add(p2);
            Players.Add(p3);
            Players.Add(p4);
            Players.Add(p5);
            Players.Add(p6);
            Players.Add(p7);
            Players.Add(p8);
            Players.Add(p9);

            //Sorts players by position
            Players.Sort();

            //Display list in listbox
            lbxPlayers.ItemsSource = Players;
        }

        //Method for creating random names
        private void PlayerNames()
        {
            //Array for first names
            string[] firstNames = {
                "Adam", "Amelia", "Ava", "Chloe", "Conor", "Daniel", "Emily",
                "Emma", "Grace", "Hannah", "Harry", "Jack", "James",
                "Lucy", "Luke", "Mia", "Michael", "Noah", "Sean", "Sophie"};
            //Array for surnames
            string[] surnames = {
                "Brennan", "Byrne", "Daly", "Doyle", "Dunne", "Fitzgerald", "Kavanagh",
                "Kelly", "Lynch", "McCarthy", "McDonagh", "Murphy", "Nolan", "O'Brien",
                "O'Connor", "O'Neill", "O'Reilly", "O'Sullivan", "Ryan", "Walsh"};

            // Generate a random index less than the size of the array.  
            int index = rand.Next(firstNames.Length);
            int index2 = rand.Next(surnames.Length);

            //To choose random number between 20 and 30
            int age = rand.Next(20, 31);
        }

        //This function is for when the add button is pressed
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            //Figure out which item selected
            Player selectedPlayer = lbxPlayers.SelectedItem as Player;

            //Checking if NULL
            if (selectedPlayer != null)
            {
                Players.Remove(selectedPlayer);
                selectedPlayers.Add(selectedPlayer);

                //Refreshes screen
                RefreshScreen();

            }//Move item over

            //This takes a value away from the total number of spaces then displays it in a textblock
            totalspaces--;
            txtBlockSpaces.Text = string.Format($"{totalspaces}");
        }

        //This function is for when the remove button is pressed
        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            //Figure out which item selected
            Player selectedPlayer = lbxSelectedPlayer.SelectedItem as Player;

            //Checking if NULL
            if (selectedPlayer != null)
            {
                Players.Add(selectedPlayer);
                selectedPlayers.Remove(selectedPlayer);

                //Refreshes screen
                RefreshScreen();
            }//Move item over

            //This takes a value away from the total number of spaces then displays it in a textblock
            totalspaces++;
            txtBlockSpaces.Text = string.Format($"{totalspaces}");
        }
        //Refreshes screen
        private void RefreshScreen()
        {
            lbxPlayers.ItemsSource = null;
            lbxPlayers.ItemsSource = Players;
            lbxSelectedPlayer.ItemsSource = null;
            lbxSelectedPlayer.ItemsSource = Players;
        }
    }
}
