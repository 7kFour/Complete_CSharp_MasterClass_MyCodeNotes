using System;

namespace Random_Class {
    internal class Program {
        static void Main(string[] args) {

            // create and initialize a new object of type Random
            Random dice = new Random();

            // number of eyes on dice
            int numEyes = 0;

            for (int i = 0; i < 10; i++) {

                // Next(min, max) can also have just a max value
                // max is exclusive - this is a 6 sided dice
                numEyes = dice.Next(1, 7);
                Console.Write($"{numEyes} "); // 6 5 1 1 4 2 2 4 3 6
            }

            Console.WriteLine("\nYes, No, Maybe question answer thing");
            Random yesNoMaybe = new Random();
            int ansNum = dice.Next(1, 4);

            switch (ansNum) {
                case 1:
                    Console.WriteLine("yes");
                    break;
                case 2:
                    Console.WriteLine("no");
                    break;
                case 3:
                    Console.WriteLine("maybe");
                    break;
                default:
                    Console.WriteLine("uhh");
                    break;
            }
        }
    }
}
