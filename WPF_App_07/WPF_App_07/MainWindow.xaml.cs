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

namespace WPF_App_07 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            // creating a cojnstructor to utilize one time binding
            // the sliders value will start at 30 and the text in the textbox will be the value of the slider 
            // You can still change the slider but it won't change the value in the box and vice versa 
            MySlider.Value = 30;
            MyTextBox.Text = MySlider.Value.ToString();
        }
    }
}
