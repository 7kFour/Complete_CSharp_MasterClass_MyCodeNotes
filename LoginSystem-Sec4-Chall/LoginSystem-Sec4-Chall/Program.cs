using System;

namespace LoginSystem_Sec4_Chall {
    internal class Program {
        // create user login system
        // user can register and create a password 
        // they can then login with this u/p 
        // solve using only - if statements, methods, and user input

        static void Main(string[] args) {

            // prompt username and password creation
            string uName = CreateUser();
            string pWord = CreatePass();
            
            // clear console to allow registration
            Console.Clear();

            // login message prompt
            string uNameCheck = CheckUser();
            string pWordCheck = CheckPass();

            // check registered un/pass vs re-entered un/pass
            LoginSystem(uName, pWord, uNameCheck, pWordCheck);  
        }

        public static string CreateUser() {
            Console.Write("Please create a username: ");
            string uName = Console.ReadLine();
            return uName;
        }
        public static string CreatePass() {
            Console.Write("Please create a password: ");
            string pWord = Console.ReadLine();
            return pWord;
        }
        public static string CheckUser() {
            Console.Write("Please enter your username: ");
            string uNameCheck = Console.ReadLine();
            return uNameCheck;
        }
        public static string CheckPass() {
            Console.Write("Please enter your password: ");
            string pWordCheck = Console.ReadLine();
            return pWordCheck;
        }
        public static void LoginSystem(string uName, string pWord, string uNC, string pWC) {
            if (uNC.Equals(uName) && pWC.Equals(pWord)) {
                Console.WriteLine($"Welcome {uName}");
            } else {
                Console.WriteLine("Incorrect User or Password");
            }
        }
    }
}
