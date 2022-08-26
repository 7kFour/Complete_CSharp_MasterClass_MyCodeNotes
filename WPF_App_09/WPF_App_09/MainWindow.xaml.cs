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

namespace WPF_App_09 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            // create list to contain Match objects 
            List<Match> matches = new List<Match>();

            // create/add match objects to list
            matches.Add(new Match() { Team1 = "Tottenham Hotspur", Team2 = "Wolverhampton Wolves", Score1 = 1, Score2 = 0, Completion = 90 });
            matches.Add(new Match() { Team1 = "Crystal Palace", Team2 = "Aston Villa", Score1 = 3, Score2 = 1, Completion = 70 });
            matches.Add(new Match() { Team1 = "Everton", Team2 = "Nottingham Forest", Score1 = 1, Score2 = 1, Completion = 43 });
            matches.Add(new Match() { Team1 = "Fullham", Team2 = "Brentford", Score1 = 3, Score2 = 2, Completion = 90 });
            matches.Add(new Match() { Team1 = "AFC Bournemouth", Team2 = "Arsenal", Score1 = 0, Score2 = 2, Completion = 54 });

            // lbMatches is the <ListBox> we created and named ln14 in the .xaml - it displays our matches
            // It needs a datasource - we set that with ItemSource and are setting it to our List<T> of matches 
            // the matches in the list are the datasource
            lbMatches.ItemsSource = matches;
        }

        private void Button_Click(object sender, RoutedEventArgs e) { 
            // make sure there is a value at the selected item
            if(lbMatches.SelectedItem != null) {
                // lbMatches.SelectedItem is an object - but we want to use it as a Match so that the 
                // member properties can be accessed
                MessageBox.Show("Selected Match: "
                    + (lbMatches.SelectedItem as Match).Team1 + " "
                    + (lbMatches.SelectedItem as Match).Score1 + " "
                    + (lbMatches.SelectedItem as Match).Score2 + " "
                    + (lbMatches.SelectedItem as Match).Team2 + " "
                    );
            }
        }
    }
}
