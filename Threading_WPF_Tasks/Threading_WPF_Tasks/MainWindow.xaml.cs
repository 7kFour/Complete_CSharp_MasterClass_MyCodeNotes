using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
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

namespace Threading_WPF_Tasks {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        // refresh on depedency properties from the WPF chapter - WPF 14 I think
        // whenever we set this depedency property the OnHtmlChanged method at the bottom will be called
        public static readonly DependencyProperty HtmlProperty = DependencyProperty.RegisterAttached(
                "Html",
                typeof(string), // type
                typeof(MainWindow), // owner
                new FrameworkPropertyMetadata(OnHtmlChanged)); // what type of data is being given to it

        public MainWindow() {
            InitializeComponent();
        }

        // remember - when working with different thread and objects, if the objects are owned by different threads 
        // you cannot change or modify them 
        // eg - in ButtonClickUrlWithTask() if you run it with the debugger and step over until you get to MyButton.Content
        // you will get an exception - System.InvalidOperationException: 'The calling thread cannot access this object because a different thread owns it.'

        // to test out the below methods just change the Click="" in the button to the method you want

        // method sends GET request to google.com and changes WPF button content from Button to Done when it 
        // receives a response
        // this is a very quick example because google.com has very little to send back in the GET response - a large website
        // would take much longer
        // in the video he downloads a 200mb file and the entire WPF UI freezes up
        // this is an example of something we shouldn't do because we are doing this on the UI thread - and it will freeze our UI 
        private void ButtonClickUrl(object sender, RoutedEventArgs e) {
            // chaining 2 functions CurrentThread() and ManagedThreadId so that we can get the results of both in one line
            Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId}");

            // creating a variable to save the website string in 
            string url = "https://www.google.com";

            // create a base class for sending/receiving http requests/responses
            HttpClient webClient = new HttpClient();

            // sends a GET request to specified URi and returns the response body as a string
            // asychronously - meaning it will run in the background without making the UI freeze
            string html = webClient.GetStringAsync(url).Result;

            // changing button content from "Button" to "Done" to give an indicator when the task is finished 
            MyButton.Content = "Done";
        }

        // same as above but introduces a Task so that our function is running async outside of the main thread
        // this introduced the problem of not being able to modify objects controlled by other threads 
        private void ButtonClickUrlWithTask(object sender, RoutedEventArgs e) {
            Task.Run(() => {
                // chaining 2 functions CurrentThread() and ManagedThreadId so that we can get the results of both in one line
                Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId}");

                // creating a variable to save the website string in 
                string url = "https://www.google.com";

                // create a base class for sending/receiving http requests/responses
                HttpClient webClient = new HttpClient();

                // sends a GET request to specified URi and returns the response body as a string
                // asychronously - meaning it will run in the background without making the UI freeze
                string html = webClient.GetStringAsync(url).Result;

                // changing button content from "Button" to "Done" to give an indicator when the task is finished 
                MyButton.Content = "Done";
            });
        }

        // fixing the above problem of not being able to modify an object controlled by another thread by using 
        // a dispatcher
        private void ButtonClickUrlWithTaskAndDispatcher(object sender, RoutedEventArgs e) {
            Task.Run(() => {
                // chaining 2 functions CurrentThread() and ManagedThreadId so that we can get the results of both in one line
                Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId}");

                // creating a variable to save the website string in 
                string url = "https://www.google.com";

                // create a base class for sending/receiving http requests/responses
                HttpClient webClient = new HttpClient();

                // sends a GET request to specified URi and returns the response body as a string
                // asychronously - meaning it will run in the background without making the UI freeze
                string html = webClient.GetStringAsync(url).Result;

                // executes the specified action async on the thread the dispatcher is associated wtih
                // we can now modify the buttons content because it belongs to the thread this function is running in
                // and not the main thread
                MyButton.Dispatcher.Invoke(() => {
                    Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId} owns MyButton");
                    // changing button content from "Button" to "Done" to give an indicator when the task is finished 
                    MyButton.Content = "Done";
                });
            });
        }

        // this method does the same as ButtonClickUrlWithTaskAndDispatcher but is the preferred way to do it
        // notice async and await 
        // PreferredButtonClickUrlWithTaskAndDispatcher is now an asynchronous method that will await a specified Task to run
        private async void PreferredButtonClickUrlWithTask(object sender, RoutedEventArgs e) {

            // declaring this outside of the task so that we can use it to setvalue to the browser 
            // which is also outside the task
            string myHtml = String.Empty;

            // creating a variable to save the website string in 
            string url = "https://www.google.com";

            // chaining 2 functions CurrentThread() and ManagedThreadId so that we can get the results of both in one line
            Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId} before await task");

            await Task.Run(() => {
                Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId} during await task");

                // create a base class for sending/receiving http requests/responses
                HttpClient webClient = new HttpClient();

                // sends a GET request to specified URi and returns the response body as a string
                // asychronously - meaning it will run in the background without making the UI freeze
                string html = webClient.GetStringAsync(url).Result;
                // this is a bit of a work around for us to get the results of the GET outside of the Task
                myHtml = html;
            });

            Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId} after await task");

            // now we can update the button outside of the Task and don't have to use a dispatcher
            MyButton.Content = "Done Downloading";

            // populating the web browser
            MyWebBrowser.SetValue(HtmlProperty, myHtml);
        }

        // called whenever a dependecy property will be changed
        // this is needed for our web browser to work
        static void OnHtmlChanged(DependencyObject dObj, DependencyPropertyChangedEventArgs e) {

            // as used as a conversion from one type to another
            WebBrowser webBrowser = dObj as WebBrowser;

            if (webBrowser != null) {
                webBrowser.NavigateToString(e.NewValue as string);
            }
        }

    }
}
