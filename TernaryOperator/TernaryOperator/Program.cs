using System;

namespace TernaryOperator {
    internal class Program {
        static void Main(string[] args) {
            // ternary is like a shortcut for an if statement
            // condition ? first_expression : second_expression;
            // condition has to be either true or false
            // the conditional operator is right - associative
            // the expression a ? b : c ? d : e
            // is evaluated as  a ? b : (c ? d : e)
            // not as (a ? b : c) ? d : e
            // the conditional operator cannot be overloaded 

            // temp in celsius
            int temperature = -5;
            string stateOfMatter = "";

            if (temperature < 0) {
                stateOfMatter = "solid";
            } else {
                stateOfMatter = "liquid";
            }
            Console.WriteLine($"State of matter is {stateOfMatter}");

            temperature += 30; // temp is now 25

            // ternary version also called enhanced if statement
            stateOfMatter = temperature < 0 ? "solid" : "liquid";
            Console.WriteLine($"State of matter is {stateOfMatter}");

            // if temperature is over 100c state will become gas
            temperature += 80; // temp is now 105
            stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";
            Console.WriteLine($"State of matter is {stateOfMatter}");

            Console.ReadKey();
        }
    }
}
