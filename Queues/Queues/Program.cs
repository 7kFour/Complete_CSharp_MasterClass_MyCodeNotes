using System;
using System.Collections.Generic;

namespace Queues {

    // queues should be used when the order of 
    // the data is important 
    // part of Systems.Collections.Generic
    // new entries are sent to the end of the queue 
    // when items are removed from the queue they are removed from 
    // the beginning of the queue - eg first item entered is first to leave 
    // FIFO - first in first out 


    internal class Program {
        static void Main(string[] args) {

            // define a queue 
            // can also be initialized in one line
            // can be any object type 
            Queue<int> myQueue = new Queue<int>();

            // adding items to the queue 
            // will be added to the end of the queue 
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);

            // printing the element at the front of the queue 
            Console.WriteLine($"Value at front of queue: {myQueue.Peek()}"); // 1 

            // no matter what we add to the queue 1 was still in there first
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            myQueue.Enqueue(5);

            // printing the element at the front of the queue 
            // 1 is still first in the queue 
            Console.WriteLine($"Value at front of queue: {myQueue.Peek()}"); // 1 

            // can use Dequeue() to remove the first integer in our Queue
            // check that your Queue is not empty before using Dequeue() 
            int queueItem = 0;
            if (myQueue.Count > 0) {
                queueItem = myQueue.Dequeue(); // will be 1 
            }

            // will be 2 now that 1 has been Dequeued
            Console.WriteLine($"Value at front of queue: {myQueue.Peek()}"); // 2
            
            while (myQueue.Count > 0) {

                // Dequeue() returns the removed element as well 
                Console.WriteLine($"The front value {myQueue.Dequeue()} was removed from the queue");

                // print count of elements remaining in queue 
                Console.WriteLine($"{myQueue.Count} element(s) remain(s).");
            }

            // sorta real world example 
            // we are an ecommerce platform handling user orders
            // the order we receive the orders matters 
            // we want to handle them in the order they were received 
            // first come first served
            // the order the data was received

            // a queue of our orders
            Queue<Order> ordersQueue = new Queue<Order>();
            
            foreach (Order o in RecieveOrdersFromBranch1()) {
                // add each order to the queue
                ordersQueue.Enqueue(o);
            }

            foreach (Order o in RecieveOrdersFromBranch2()) {
                // add each order to the queue
                ordersQueue.Enqueue(o);
            }

            // processing the orders 
            while (ordersQueue.Count > 0) {

                // remove order at front of queue 
                // order that came in first
                // store it in a variable called currentOrder
                Order currentOrder = ordersQueue.Dequeue();

                // process the order - just printing it to the console 
                // could obviously do something like send an email or w/e youd
                // do in real life
                currentOrder.ProcessOrder();

                // order will be 1, 2, 6, 3, 4, 5
            }

        }

        // could also check to see which branch orders were from 
        // in a real example we would most likely have something like that as
        // well as date
        // items would also most likely be coming from a DB as well 

        // created an array of orders and returns it
        static Order[] RecieveOrdersFromBranch1() {
            // create new orders array
            Order[] orders = new Order[] {
                // Order(id, quantity)
                new Order(1, 5),
                new Order(2, 4),
                new Order(6, 10)
            };
            return orders;
        }

        // created an array of orders and returns it
        static Order[] RecieveOrdersFromBranch2() {
            // create new orders array
            Order[] orders = new Order[] {
                // Order(id, quantity)
                new Order(3, 7),
                new Order(4, 9),
                new Order(5, 2)
            };
            return orders;
        }
    }
}
