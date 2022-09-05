using System;
using System.Threading.Tasks; // need this for TaskCompletionSource
using System.Threading;

namespace Threading_StartEnd_Completion {
    internal class Program {

        // using the TaskCompletionSource 
        // various methods of the Thread class
        // manually ending a thread

        static void Main(string[] args) {
            
            var taskCompletionSource = new TaskCompletionSource<bool>();

            // creating a thread but not starting it
            var thread = new Thread(() => {

                // need to use this syntax when inside the {} of the Thread you want to interact with
                // a way to see when our thread started
                Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");

                // sleep thread for 5000ms
                Thread.Sleep(5000);

                // this will try and set the completion state of the taskCompletionSource variable to true -- meaning the task is done
                // this is what is referenced below - a way to manually say that a task is finished
                taskCompletionSource.TrySetResult(true);
                
                // letting us know when the thread is ended
                Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended");
            });

            // getting the thread id - check some of the things Thread() can do by either <var name of your new Thread()>. eg thread. 
            // and looking at the context in VS or just looking up the microsoft docs for the Thread class
            // this is a way to know if a thread has started also and can be done inside the thread {} however you need to use different syntax
            // see thread above on ln16
            Console.WriteLine($"Thread number: {thread.ManagedThreadId}");

            // starting our thread above
            thread.Start();

            // this will be a bool letting us know if the task has been completed
            // TaskCompletionSource we are using will never be set to true because it doesn't actually do anything 
            // however, we can do it manually ---^ see the thread above 
            var test = taskCompletionSource.Task.Result;

            Console.WriteLine($"Task was done: {test}");

            Console.ReadKey();
        }
    }
}
