using System;

namespace TryCatchFinally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {

                Console.WriteLine("Format exception - Please enter the correct type next time.");
            }
            catch (Exception)
            {
                Console.WriteLine("General Exception");
            } 
            finally
            {
                // this is where you enter the code that should be executed when try/catch are done
                // doesn't matter if there is an error or not this code will run 
                Console.WriteLine("This is called anyways");
            }


            Console.ReadKey();  
        }
    }
}
