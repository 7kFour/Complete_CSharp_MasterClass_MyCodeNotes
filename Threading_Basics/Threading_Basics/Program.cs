using System;
using System.Threading; // must be included to use thread class

namespace Threading_Basics {
    internal class Program {

        // to see threads - add breakpoint - start debugger - Debug > Windows > Threads

        // think of a thread as a piece of work that is executed and allow you to execute multiple things at the same time 
        // if you have multiple cores in your processor - 4 core processor can run 4 threads at the same time
        static void Main(string[] args) {

            //Console.WriteLine("Hello World 1!");

            // will pause the thread it is part of for 1000ms - it's currently part of the thread of main() 
            // so it will pause main() for 1s when it's called
            // keep in mind that this will pause the entire thread - so, for instance - if you pause the main() thread
            // of a program with a UI - like a WPF program - the UI will not respond for that entire second either

            //Thread.Sleep(1000);

            //Console.WriteLine("Hello World 2!");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello World 3!");

            // creating a new thread 
            // and starting it immediately with .Start() -- meaning it will execute whatever is withing its {}
            //new Thread(()=> {

            //}).Start();


            // creating, starting new thread
            // where the above method of writeline - sleep was printing then pausing for 1 second because it was stopping the main thread
            // the below method will print out each of the 4 writeline statements at once - though not necessarily in order
            // ie these 4 threads are running at the same time - running parallel - this is multi-threading
            // the order that they finish is based on the order of how long the code inside takes to run - you need to be
            // very careful when using multi-threading

            new Thread(()=> {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 1");
            }).Start();
            new Thread(() => {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 2");
            }).Start();
            new Thread(() => {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 3");
            }).Start();
            new Thread(() => {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 4");
            }).Start();

            Console.ReadKey();
        }
    }
}
