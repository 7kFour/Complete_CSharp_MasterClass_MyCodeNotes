using System;
using System.IO;

namespace Parsing_Game_Pt1 {
    internal class Program {

        // the rules 
        // Read from the input.txt line by line
        // Split() the text into an array
        // Take the returned elements from split and write the element with index 4 into the output.txt
        // Add a space between each element to make it readable
        // If your output is not a readable sentence, your answer is wrong

        static void Main(string[] args) {

            // read entire file to a string
            string[] lines = System.IO.File.ReadAllLines(@"D:\dev\c#\Complete_CSharp_MasterClass_MyCodeNotes\Parsing_Game_Pt1\Parsing_Game_Pt1\input.txt");

            
        }
    }
}
