using System;
using System.Collections.Generic;

namespace IEnumerableDemo {
    internal class Program {
        static void Main(string[] args) {

            // creating generic IEnumerable variable that takes any collection of type int
            // will use this variable to store the collections that are returned by GetCollection() method
            // this also means we can iterate through it with a foreach loop because the returned object
            // will have implemented GetEnumerator() from IEnumerable
            IEnumerable<int> unknownCollection;

            // because the argument 1 is used this will contain a List
            unknownCollection = GetCollection(1);
            Console.WriteLine("List! (:");
            foreach (int i in unknownCollection) {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            // because the argument 2 is used this will contain a Queue
            // but it will still be stored in unknownCollection because it's type is IEnumerable<int>
            // so it can store anything that implements IEnumerable and stores a type of int!
            unknownCollection = GetCollection(2);
            Console.WriteLine("\nQueue O_o");
            foreach (int i in unknownCollection) {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            // because any argument other than 1 or 2 is used this will contain an Array
            unknownCollection = GetCollection(3);
            Console.WriteLine("\nArray... :O");
            foreach (int i in unknownCollection) {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

        }

        // returns IEnumerable of type int
        // returns a different types of lists depending on the option we pass to it
        // showing the power of IEnumerable - it is possible to return different types 
        // of collections from one method instead of needing to make multiple methods 
        // ala static List<int> GetList() static Queue<int> GetQueue() etc
        // we can just return anything that implements the IEnumerable interface ie 
        // all generic collections from this GetCollection() method
        static IEnumerable<int> GetCollection(int option) {

            // List<T>, Queue<T> are both generic collections
            List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5 };
            Queue<int> numbersQueue = new Queue<int>();
            // add values to Queue
            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);


            // switch expression
            return option switch {
                1 => numbersList,
                2 => numbersQueue,
                _ => new int[] { 11, 12, 13, 14, 15 },
            };

            // could also use if/else if/else here 
            //if (option == 1) {
            //    return numbersList;
            //} else if (option == 2) {
            //    return numbersQueue;
            //} else {
            //    return new int[] { 11, 12, 13, 14, 15 };
            //}

            // or a switch statement
            //switch (option) {
            //    case 1:
            //        return numbersList;
            //        break;
            //    case 2:
            //        return numbersQueue;
            //        break;
            //    default:
            //        return new int[] { 11, 12, 13, 14, 15 };
            //        break;
        }
    }
}
