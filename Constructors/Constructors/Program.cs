using System;

namespace Constructors {
    internal class Program {
        static void Main(string[] args) {

            // when creating a new human we now need to input arguments
            // for our constructor to use in building our Human
            Human anthony = new Human("Anthony", "Spradlin", 36, "Green");
            anthony.IntroduceMyself();

            Human amber = new Human("Amber", "Spradlin", 33, "Green");
            amber.IntroduceMyself();

            Console.Read();
        }
    }
}
