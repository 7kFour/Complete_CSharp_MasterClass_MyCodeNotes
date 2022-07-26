using System;

namespace NestedIFElse {
    internal class Program {
        static void Main(string[] args) {
            bool isAdmin = false;
            bool isRegistered = true;

            // ask for user name
            Console.Write("Please enter your username: ");
            string userName = Console.ReadLine();

            if (isRegistered) {
                Console.WriteLine("Hello there, registered user.");
                if (userName != "") {
                    Console.WriteLine($"Hi there, {userName}!");
                    // .Equals() to compare strings
                    // you still use == to compare ints
                    if (userName.Equals("admin")) {
                        Console.WriteLine($"Hey Admin!");
                    }
                }
            }

            // using logical or
            if (isAdmin || isRegistered) {
                Console.WriteLine("You are logged in");
            }

            Console.Read();
        }
    }
}
