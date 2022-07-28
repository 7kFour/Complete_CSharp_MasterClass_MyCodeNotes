using System;
using System.Collections.Generic;

namespace Stacks {

    // stacks are a generic collection
    // in Systems.Collections.Generic namespace
    // use LIFO - Last In First Out 
    // most recent element to enter a stack will be the first element removed

    internal class Program {
        static void Main(string[] args) {

            // declaring a new stack
            // stacks can hold any type of Object(strings, your own class, etc) 
            // but only data type of object per stack - because they are generic
            Stack<int> theStack = new Stack<int>();

            // adding items to stack 
            // they will be added at the top of the stack 
            theStack.Push(1);
            theStack.Push(1337);
            theStack.Push(3405);
            theStack.Push(65345);
            theStack.Push(3789);
            theStack.Push(451);
            theStack.Push(926);

            // to see whats on top of the stack 
            // Peek() returns the element at the top of the stack
            // without removing it 
            Console.WriteLine($"Top value on the stack is {theStack.Peek()}"); // writes 926

            // removing an item from a stack 
            // removes item from the top of the stack 
            // you cannot pop from an empty stack 
            // can be good to wrap the Pop() in a conditional
            if (theStack.Count > 0) {
                Console.WriteLine($"{theStack.Pop()} removed from stack"); // removes 926
            }
            
            Console.WriteLine($"Top value on the stack is {theStack.Peek()}"); // writes 451

            // create a while loop to delete items from the stack 
            // will pop all items from the stack and stop executing when stack is empty
            while(theStack.Count > 0) {

                // pop will return the value and remove it 
                // starts at 451 -> 3789 -> 65345 -> 3405 -> 1337 -> 1
                Console.WriteLine($"\nTop value: {theStack.Pop()} removed from the stack.");

                // print count of items remaining in stack 
                Console.WriteLine($"Remain items in stack: {theStack.Count}\n");
            }

            // reverse an array with a stack 
            int[] nums = new int[] { 8, 2, 3, 4, 7, 6, 2 };
            Stack<int> numStack = new Stack<int>();

            // pushing each value from nums array to stack
            foreach (int x in nums) {
                numStack.Push(x);
                Console.WriteLine($"{x} pushed to stack");
            }

            // once all values are stored in stack 
            // popping them off will write to console a reverse order 
            // of the values previously in array nums 
            Console.WriteLine("\nNums array reversed");
            while (numStack.Count > 0) {
                // this is ok
                //Console.Write($"{numStack.Pop()} ");

                // this is another way to remove and display the value
                // could be useful to store in a variable if you need to do 
                // other logic with it
                int num = numStack.Pop();
                Console.WriteLine($"{num} ");
            }

        }
    }
}
