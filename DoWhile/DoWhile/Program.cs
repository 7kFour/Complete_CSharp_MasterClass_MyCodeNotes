using System;

namespace DoWhile {
    internal class Program {
        static void Main(string[] args) {
            int counter = 0;
            int lengthofText = 0;
            string wholeText = string.Empty;

            // do while will always execute the code at least once 
            // make sure that there is always a way to make sure your condition becomes false
            // so you avoid having infinite loops
            do {
                Console.Write("Please enter the name of a friend: ");
                string nameOfFriend = Console.ReadLine();

                // gets length of friend name that user entered and adds to current length
                int currentLen = nameOfFriend.Length;
                lengthofText += currentLen;

                // i think he's doing this as a sort of fake array
                wholeText += nameOfFriend;
            } while (lengthofText < 20);
            Console.WriteLine("Thanks that was enough!" + wholeText);


            Console.ReadKey();
        }
    }
}
