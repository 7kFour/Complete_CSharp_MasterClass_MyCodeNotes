using System;
using System.Collections;

namespace ArrayLists {
    internal class Program {
        static void Main(string[] args) {
            
            // declaring an array list 
            // need to `using System.Collections;
            // this declaration method as an undefined amount of objects
            // it will grow dynamically
            ArrayList myArrayList = new ArrayList();

            // this method has a defined amount of objects
            // this one is defined as size 3
            ArrayList myArrayList2 = new ArrayList(3);

            // can add any type of object to an arraylist
            myArrayList2.Add(1);
            myArrayList2.Add("cat");
            myArrayList2.Add(false);
            myArrayList2.Add('$');
            myArrayList2.Add(3.14159f);
            
            // checking all the objects in our arraylist 
            // remember we need to use object type
            foreach (object n in myArrayList2) {
                Console.WriteLine(n);
            }

            // instead of removing something from a specific index location
            // we can remove a specified value from the arraylist 
            myArrayList2.Remove("cat");

            // can delete an element at a specific index position also 
            myArrayList2.RemoveAt(0); // this will remove the 1
            myArrayList2.RemoveRange(1, 2); // this will remove "cat" and false 

            // just a note about the above ^ 
            // removing cat makes the AL 1, false, $, 3.14159
            // removing at 0 removes 1 
            // remove range 1 for 2 spaces inclusive removes $ and 3.14159
            // this leaves only false in the AL 

            // gives count of objects stored in AL
            Console.WriteLine(myArrayList2.Count);

            // adding some objects to AL1 to work with 
            myArrayList.Add("tractor");
            myArrayList.Add(42);
            myArrayList.Add('&');
            myArrayList.Add(true);
            myArrayList.Add(72.49394);
            myArrayList.Add(-7);

            Console.WriteLine("\nmyArrayList stuff below");

            // a variable to store the value from our foreach
            double sum = 0;

            // we can operate on objects in the AL using logic we create
            foreach (object obj in myArrayList) {

                // check each obj in the AL 
                // if it is an int type 
                // convert it to a double and add it to the sum variable above
                if (obj is int) {
                    sum += Convert.ToDouble(obj);
                } else if (obj is double) {
                    // also casting but using a different method 
                    // (double) and Convert.ToDouble() work different
                    // but in this case it doesn't matter which one you use
                    sum += (double)obj;
                } else if (obj is string) {
                    Console.WriteLine(obj);
                }
            }
            Console.WriteLine($"the sum is {sum}");
        }
    }
}
 