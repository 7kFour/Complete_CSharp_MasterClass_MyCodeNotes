using System;
using System.Linq;
using System.Threading;

namespace Threading_ThreadPools_ThreadsInBackground {
    internal class Program {

        // when working with threads you need to be very deliberate and precise
        // know where they are - what you are doing with them and why they are there
        // and how you are going to work with everything in the thread

        // the main place you want to use threads is when you are doing something in the background and in the foreground
        // foreground: something like the UI - wpf, xamarin etc - everything in the UI is done by the UI thread in the foreground
        // background: things like downloading videos/data from the internet - or even accessing data from the HDD or an SD card
        // things that can take a little while - even if thats a few ms - these are things that should be down in the background
        // otherwise your UI will freeze - because its thread is being used up which will cause it to freeze 
        // offloading background things can make your app feel more performant and will stop it from freezing up

        // threadpools are there to do specific work items
        // they will wait until a thread is ready/available before it starts with the next work item 
        // threads in managed threadpool are background threads - their 'thread is background' property is set to true

        // when a threadpool reuses a thread id - like when you see thread 3 start over and over - the threadpool 
        // doesn't clear the data in the thread local storage - when a thread examines the thread local storage the values
        // it sees may be leftover from an earlier usage of the thread

        static void Main(string[] args) {

            // this is going to create 1000 threads and they will start/end
            // this is just an example of quickly creating a lot of threads 
            //Enumerable.Range(0, 1000).ToList().ForEach(f => {
            //    new Thread(() => {
            //        Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");
            //        Thread.Sleep(1000);
            //        Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} exited");
            //    }).Start();
            //});

            // now we are going to do a more secure method and only create the threads that are actually required
            // using a threadpool
            Enumerable.Range(0, 1000).ToList().ForEach(f => {

                // the threadpool will handle creating the threads for us
                // threadpool will try and start and end the threads around the same time
                // it will also only create the amount of threads that it needs and can work with 
                // it won't create a 1000 threads like the one above - it will only create as many threads as your computer
                // can handle
                // queueuserworkitem expects an object
                ThreadPool.QueueUserWorkItem((o) => {
                    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");
                    Thread.Sleep(1000);
                    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} exited");
                });
            });

            // setting a thread to be background
            // threadpools only have background threads
            new Thread(() => {
                Console.WriteLine("Background thread boiiiiii");
            }) { IsBackground = true }.Start();

            Console.ReadKey();

        }
    }
}
