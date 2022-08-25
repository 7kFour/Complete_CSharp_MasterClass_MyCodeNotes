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

namespace WPF_App_06 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        // creating my own property
        public int MyProperty {
            get { return (int)GetValue(myDependencyProperty); } 
            set { SetValue(myDependencyProperty, value); }
        }

        // make sure to create this as a static readonly for the reasons listed in MainWindow.xaml

        // register is the name, type, and owner of our property, and PropertyMetadata - this is a default value 
        // MyProperty{} is int the name is the name we want and the owner is the MainWindow class because thats where 
        // we defined it -- the owner is the class where the property is created
        public static readonly DependencyProperty myDependencyProperty =
            DependencyProperty.Register("MyProperty", typeof(int), typeof(MainWindow), new PropertyMetadata(0));

        public MainWindow() {
            InitializeComponent();

            
        }
    }
}
