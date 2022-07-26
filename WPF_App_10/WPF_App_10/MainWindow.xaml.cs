﻿using System;
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

namespace WPF_App_10 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            // getting all of the colors back from the System.Colors namespace 
            // you could create your own list, info from a db etc to populate this 
            // or you could use an internal list like below 
            // this combo box will drop down to reveal all of the colors in the Colors namespace of C#
            comboBoxColors.ItemsSource = typeof(Colors).GetProperties();
        }
    }
}
