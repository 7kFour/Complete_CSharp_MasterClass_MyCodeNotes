using System;

namespace JaggedArraysChall {
    internal class Program {
        static void Main(string[] args) {
            // create a jagged array, which contains 3 "friends arrays", in which two family members
            // should be stored 
            // introduce family members from different families to each other via console 

            // pretty sure he means create a jagged array with 3 sub arrays 
            // each sub array should be a family
            // each sub array should have the names of 2 people from that family

            // array of families
            string[][] theFamilies = new string[][]{
                // the spradlins
                new string[] {"Amber", "Anthony"},
                // the johnstons
                new string[] {"Kevin", "Tracy"},
                // the stoughs
                new string[] {"Patricia", "Larry"}
            };

            Console.WriteLine($"The Spradlins: {theFamilies[0][0]} and {theFamilies[0][1]}");
            Console.WriteLine($"{theFamilies[0][0]}'s aunt is {theFamilies[1][1]}");
            Console.WriteLine($"{theFamilies[0][1]}'s grandfather is {theFamilies[2][1]}. He has not met " +
                $"{theFamilies[0][0]}'s uncle {theFamilies[1][0]}.");
        }
    }
}
