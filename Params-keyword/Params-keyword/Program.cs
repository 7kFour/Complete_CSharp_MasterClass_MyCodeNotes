using System;

namespace Params_keyword {
    internal class Program {
        static void Main(string[] args) {

            // can keep adding more params 
            // each string in "" is a parameter 
            ParamsMethod("this", "is", "a", "long", "string");

            Console.WriteLine("\nparamethod 2 below");
            // showing that with the object[] type 
            // we can pass parameters of any type
            int price = 50;
            float pi = 3.14f;
            char at = '@';
            string book = "The Hobbit";

            // can have as many params as you want 
            ParamsMethod2(price, pi, at, book);
            ParamsMethod2("Hello", 5.3, '$');
            ParamsMethod2(); // can even be empty 



        }

        // our params will be of type string[] instead of type object[]
        public static void ParamsMethod(params string[] sentence) {
            for (int i = 0; i < sentence.Length; i++) {
                // write every item of parameters list sent as argument to method 
                // to the console 
                // sentence is an array of strings as we can see 
                Console.Write(sentence[i] + " ");
            }
        }

        public static void ParamsMethod2(params object[] stuff) {
            // foreach loop to go through array of objects
            foreach (object obj in stuff) {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
