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

namespace WPF_App_13 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            // same as IsChecked="True" in the XAML -- just another way to do it
            rbMaybe.IsChecked = true;
        }

        // adding an event to no 
        private void RadioButton_Checked(object sender, RoutedEventArgs e) {
            MessageBox.Show("Please say yes!");
        }

        private void yesChecked(object sender, RoutedEventArgs e) {
            MessageBox.Show("Thanks!!!");
        }
    }
}
