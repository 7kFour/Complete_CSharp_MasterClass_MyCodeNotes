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

namespace WPF_App_11 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void cbAllCheckedChanged(object sender, RoutedEventArgs e) {
            // if All Toppings is checked then all other check boxes should be checked or unchecked 
            bool newVal = (cbAllToppings.IsChecked == true);
            cbSalami.IsChecked = newVal;
            cbMushrooms.IsChecked = newVal;
            cbMozzarella.IsChecked = newVal;    
        }

        private void cbSingleCheckedChanged(object sender, RoutedEventArgs e) {
            // values are either checked or null
            cbAllToppings.IsChecked = null;

            if ((cbSalami.IsChecked == true) && (cbMushrooms.IsChecked == true) && (cbMozzarella.IsChecked == true)) {
                // if all 3 of the options are checked then All Toppings should be checked 
                cbAllToppings.IsChecked = true;
            }

            if ((cbSalami.IsChecked == false) && (cbMushrooms.IsChecked == false) && (cbMozzarella.IsChecked == false)) {
                // if all 3 of the options are unchecked then All Toppings should be unchecked 
                cbAllToppings.IsChecked = false;
            }
        }
    }
}
