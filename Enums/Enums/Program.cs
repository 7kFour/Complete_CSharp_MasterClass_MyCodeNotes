using System;

namespace Enums {

    // Enums - an immutable set of constants
    // placed at the namespace level to be useable by the entire library in all classes
    // keeps your library consistent - don't have to recreate constants in all classes

    // enums are 0 indexed
    // Mon = 0 ... Sun = 6
    enum Day { Mon, Tue, Weds, Thurs, Fri, Sat, Sun };

    // can change index value as much as you want
    // enum will continue counting from the last changed index
    // Jan = 1, Feb = 2... May = 5, Jun = 21, Jul = 22... Nov = 6, Dec = 7
    enum Month { Jan = 1, Feb, Mar, Apr, May, Jun = 21, Jul, Aug, Sept, Oct, Nov = 6, Dec};

    internal class Program {
        static void Main(string[] args) {

            Day friday = Day.Fri;
            Day monday = Day.Mon;

            Day a = friday;

            // output - Fri
            Console.WriteLine(friday);
            // output - Mon
            Console.WriteLine(monday);
            // output - Fri
            Console.WriteLine(a);
            // output - True
            Console.WriteLine(a == friday);

            // access index value by casting

            // output - 2
            Console.WriteLine((int)Day.Weds);
            // output - 7
            Console.WriteLine((int)Month.Dec);


        }
    }
}
