using System;

namespace ChallengesSec2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Challenge 1 String and its Methods
            Console.Write("Please enter your name and press enter: ");
            string userInput = Console.ReadLine();

            // example of using .ToUpper() with $ string interpolation
            Console.WriteLine(String.Format($"Upper case: {userInput.ToUpper()}"));

            // can also assign these to variables 
            string myNameLower = userInput.ToLower();
            Console.WriteLine($"Lower case: {myNameLower}");

            Console.WriteLine(userInput.Trim());
            // can have a range
            // starting point, length you want to go
            Console.WriteLine(userInput.Substring(2, 4));
            // simplified version of .Substring(1)
            // this is basically saying from index 1 (String(1)) to end of string
            Console.WriteLine(userInput[1..]);

            // Challenge 2 String and its Methods 
            Console.Write("Enter a string: ");
            string userString = Console.ReadLine();

            Console.Write("What character in the string would you like to search for?: ");
            int searchChar = Console.Read();
            // need to cast the ascii to char or else it will output an int ascii value
            Console.WriteLine((char)searchChar);
            // find first occurence of user supplied character and output its index
            Console.WriteLine($"First occurence of char is at index {userString.IndexOf((char)searchChar)}");
            // could also do the above by doing
            // char searchChar = Console.ReadLine().[0];
            // this will take the first character of the string entered by the user
            // it will also make it so we don't have to cast to (char) like on line 116

            // Get users full name and output it 
            Console.Write("Enter first name and press enter: ");
            string theFirstName = Console.ReadLine();

            Console.Write("Enter last name and press enter: ");
            string theLastName = Console.ReadLine();

            // concatenate the 2 strings with an eempty string
            string theFullName = String.Concat(theFirstName + " " + theLastName);
            Console.WriteLine($"\nYour name is {theFullName}");

            // Challenge 3 Datatypes and Variables 
            // create variable for each primitive data type in list
            // https://docs.microsoft.com/en-us/previous-versions/visualstudio/visual-studio-2008/ms228360(v=vs.90)?redirectedfrom=MSDN
            byte myByte = 17; // 0 to 255
            sbyte mySByte = 122; // -128 to 127
            int myInt = 75849;
            uint myUInt = 3893;
            short myShort = 27589;
            ushort myUShort = 54328;
            long myLong = 1285855994;
            ulong myULong = 9929409020858508;
            float myFloat = 3.14159f; // need to add f to the end
            double myDouble = 3.14159757588;
            char myChar = 'a';
            bool myBool = true;
            object myObj = null; // he said to leave this one but ill look at it later 
            string myString = "Hello";
            decimal myDecimal = 58.83984983984m; // need to add m to thee end

            string theChall = "I control text";
            string theChallNum = "12345";
            int theCN = int.Parse(theChallNum);

            // you're supposed to output each variable but writing that all out would take a minute is really easy so 


        }
    }
}
