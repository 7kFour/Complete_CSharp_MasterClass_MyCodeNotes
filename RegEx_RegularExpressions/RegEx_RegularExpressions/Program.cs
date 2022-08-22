using System;
using System.Text.RegularExpressions;

namespace RegEx_RegularExpressions {
    internal class Program {

        // RegEx is very useful - used in most programming languages
        // ctrl+f then click the square with a * beside it or alt+e lets you search regex in visual studio
        // you can use this to test the regex you create easily

        // check Snippets.txt for many useful regex 

        // https://docs.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-language-quick-reference
        // https://regex101.com/ -- good tool for creating and testing RegEx

        static void Main(string[] args) {

            // need to have @ before your string
            // searching for digits 
            //string pattern = @"\d";
            // searching for 5 digits
            //string pattern = @"\d{5}";
            // searching for "there" it's case sensitive
            string pattern = @"there";
            Regex reg = new Regex(pattern);

            string text = "Hi there, my number is 12314";

            // trying to match pattern to text
            MatchCollection matchCollection = reg.Matches(text);

            Console.WriteLine($"{matchCollection.Count} hits found:\n {text} ");

            foreach (Match hit in matchCollection) {
                GroupCollection group = hit.Groups;
                Console.WriteLine($"{group[0].Value} found at {group[0].Index}");
            }

        }
    }
}
