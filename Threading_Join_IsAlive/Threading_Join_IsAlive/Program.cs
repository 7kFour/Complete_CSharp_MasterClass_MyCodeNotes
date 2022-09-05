using System;
using System.Threading;

namespace Threading_Join_IsAlive {
    internal class Program {
        static void Main(string[] args) {

            // warning - this is working differently than his did in the video 
            // refresh on the video if this doesn't make sense for some reason

            // this is just a basic example from before i added more to the code
            // - run the program and tinker around with it to fully understand

            // before adding the joins the output of running the program would look like 
            // main thread start
            // main thread end
            // thread 1 start
            // thread 2 start

            // after adding the Join() it becomes 
            // main thread start
            // thread 1 start
            // thread 2 start
            // main thread end

            Console.WriteLine("Main Thread started");

            // here we are making thread and passing in a function to use instead of using a lambda expression ()=> like we
            // have previously 
            Thread thread1 = new Thread(ThreadOneFunction);
            Thread thread2 = new Thread(ThreadTwoFunction);

            // starting threads
            thread1.Start();
            thread2.Start();

            // Join() these threads are being 'joined' to the main thread now
            // they will block it from finishing until they are finished 
            // join blocks the calling thread - in this case that is the main thread because that is the thread
            // we are calling this from
            //thread1.Join();
            //Console.WriteLine("ThreadOneFunction done");
            //thread2.Join();
            //Console.WriteLine("ThreadTwoFunction done");

            // Join() has multiple overloads - here we are giving a time
            // this basically says - if thread1 completes within 1000ms - do something
            // this is only blocking the calling thread (the main thread in this example) for 1 second 
            if(thread1.Join(1000)) {
                Console.WriteLine("ThreadOneFunction done on time");
            } else {
                Console.WriteLine("ThreadOneFunction didn't finish within 1 second");
            }

            thread2.Join();
            Console.WriteLine("ThreadTwoFunction done");

            // an example of how to check continously to see if a thread is still working
            for (int i = 0; i < 10; i++) {

                // isalive gets the execution status of the current thread - is it done or is it not done
                if (thread1.IsAlive) {
                    Console.WriteLine("ThreadOne is still doing stuff");
                    Thread.Sleep(300);
                } else {
                    Console.WriteLine("ThreadOne completed");
                }
            }

            Console.WriteLine("Main Thread ended");

        }

        // these are functions not methods because they aren't in an OOP class
        public static void ThreadOneFunction() {
            Console.WriteLine("ThreadOneFunction started!");
            Thread.Sleep(3000);
            Console.WriteLine("ThreadOneFunction coming back to caller (main thread in this program)");
        }

        public static void ThreadTwoFunction() {
            Console.WriteLine("ThreadTwoFunction started!");
            Thread.Sleep(3000);
        }
    }
}
