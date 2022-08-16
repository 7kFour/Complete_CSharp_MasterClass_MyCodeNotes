using System;
using System.ComponentModel;
using System.IO;

namespace File_IO {
    internal class Program {
        static void Main(string[] args) {

            // when reading from a file you need to create a string into which
            // you want to save the text of the file 

            // need to use @ and specify full directory of the location of your file
            string text = System.IO.File.ReadAllText(@"D:\dev\c#\Complete_CSharp_MasterClass_MyCodeNotes\File_IO\Assets\textFile.txt");

            // this will keep any whitespace in the original text file 
            Console.WriteLine($"Textfile contains following text:{text}");

            // slightly different method from above - reading every line of the text file
            // this gives you more control over formating 
            string[] lines = System.IO.File.ReadAllLines(@"D:\dev\c#\Complete_CSharp_MasterClass_MyCodeNotes\File_IO\Assets\textFile.txt");
            Console.WriteLine("\nContents of the text file by line");
            foreach (string line in lines) { 
                Console.WriteLine($"\t{line}");
            }


            // Writing to a file 
            // 2 ways to write to a file as well - by line or writing a string to a file

            // line by line version
            // if the file exists will write to it and overwrite whats in it-- if it doesn't will create it 
            // can insert some things like \t and \n
            string[] writeLines = { "\tfirst line", "\nsecond line", "Third line" };
            File.WriteAllLines(@"D:\dev\c#\Complete_CSharp_MasterClass_MyCodeNotes\File_IO\Assets\writeFile.txt", writeLines);

            // second method of writing to file
            Console.WriteLine("Please give the file a name:");
            // create a file name just to show more functionality
            string fileN = Console.ReadLine();
            Console.WriteLine("Please enter the text for the file:");
            // read what the user enters and write it to file
            string input = Console.ReadLine();
            File.WriteAllText(@"D:\dev\c#\Complete_CSharp_MasterClass_MyCodeNotes\File_IO\Assets\" + $"{fileN}.txt", input);

            // third method of writing to file
            // a stream writer
            // using() defines scope or creates an alias for a namespcae or imports types defined in other namespaces
            using (StreamWriter file2 = new StreamWriter(@"D:\dev\c#\Complete_CSharp_MasterClass_MyCodeNotes\File_IO\Assets\moreText.txt")) {

                // check strings in arr to see if they contain the word 'Third' - if they do - write them to the file moreText.txt
                foreach (string l in writeLines) {
                    // .Contains() is a useful method for checking for content
                    if (l.Contains("Third")) {
                        file2.WriteLine(l);
                    }
                }
            }

            // adding content to the end of a text file -- appending it --
            using(StreamWriter theFile = new StreamWriter(@"D:\dev\c#\Complete_CSharp_MasterClass_MyCodeNotes\File_IO\Assets\moreText.txt", true)) {
                theFile.WriteLine("additional line!1");
            }

                Console.ReadKey();
        }
    }
}
