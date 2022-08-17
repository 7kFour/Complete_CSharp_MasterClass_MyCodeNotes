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

namespace WPF_App_02 {
    
    // this is a recreation of the XAML code with C# 

    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            // creating a new grid and initializing it to content
            // this.Content - is basically the content of the application
            // in the design window is this basically everything between the <Window></Window> tag
            // basically saying to add a new <Grid></Grid> element inside the window tags
            Grid grid = new Grid();
            this.Content = grid;

            // creating a button with code behind
            Button btn = new Button();
            btn.FontSize = 26;
            btn.Width = 250;
            btn.Height = 100;

            // create a wrap panel for button like in the XML
            WrapPanel wp = new WrapPanel();

            // adding a text block
            // text color is done with the Brushes class
            TextBlock txt = new TextBlock();
            txt.Text = "Multi";
            txt.Foreground = Brushes.Blue;

            // adding the text to the wrap panel
            wp.Children.Add(txt);

            // adding the other text to recreate the multicolor text from the XAML
            // must assign a new text block to txt each time we want to add new content
            txt = new TextBlock();
            txt.Text = "Color";
            txt.Foreground = Brushes.Red;
            wp.Children.Add(txt);

            txt = new TextBlock();
            txt.Text = "Button";
            txt.Foreground = Brushes.White;
            wp.Children.Add(txt);

            // add the wrap panel to the button 
            btn.Content = wp;

            // adding the button to the Grid - basically the body if you think of <html><body></body></html>
            grid.Children.Add(btn);
        }
    }
}
