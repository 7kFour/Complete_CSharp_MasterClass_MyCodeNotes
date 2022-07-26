using System;

namespace MultipleConstructors {
    internal class Program {
        static void Main(string[] args) {

            // testing main constructor
            Human anthony = new Human("Anthony", "Spradlin", "Green", 36);
            anthony.IntroduceMyself();
            Human amber = new Human("Amber", "Spradlin", "Green", 33);
            amber.IntroduceMyself();

            // constructor with no age
            Human glorpo = new Human("Glorpo", "Zipnor", "Red");
            glorpo.IntroduceMyself();

            // constructor with no eye color 
            Human noEyes = new Human("Nilzi", "Umhbra", 134);
            noEyes.IntroduceMyself();

            // this will use our default constructor
            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();

            // first+last name constructor
            Human twoNames = new Human("Dilbor", "Frankle");
            twoNames.IntroduceMyself();

            // first name constructor 
            Human oneName = new Human("Prago");
            oneName.IntroduceMyself();

            Console.Read();
        }
    }
}
