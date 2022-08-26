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
            matches.Add(new Match() { Team1 = "Bayern Munich", Team2 = "Real Madrid", Score1 = 3, Score2 = 2, Completion = 85 });

            // lbMatches is the <ListBox> we created and named ln14 in the .xaml - it displays our matches
            // It needs a datasource - we set that with ItemSource and are setting it to our List<T> of matches 
            // the matches in the list are the datasource
            lbMatches.ItemsSource = matches;
        }
    }
}
