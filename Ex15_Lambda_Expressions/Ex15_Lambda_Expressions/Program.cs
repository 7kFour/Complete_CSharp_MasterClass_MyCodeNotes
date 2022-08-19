using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Ex15_Lambda_Expressions {
    internal class Program {

        // see readme.txt for instructions
        static void Main(string[] args) {

            // create static lambda expressions to store in dictionary
            // Func<T1, T2, Result> -- Func<> is basically a built in delegate to save lambdas too
            // so you don't have to create your own delegate
            // https://docs.microsoft.com/en-us/dotnet/api/system.func-2?view=net-6.0
            Func<float, float, float> Plus = (x, y) => x + y;
            Func<float, float, float> Minus = (x, y) => x - y;
            Func<float, float, float> Divide = (x, y) => x / y;
            Func<float, float, float> Multiply = (x, y) => x * y;

            // dictionary to store lambdas
            Dictionary<string, Func<float, float, float>> Operators = new Dictionary<string, Func<float, float, float>>() {
                {"+", Plus },
                {"-", Minus },
                {"/", Divide },
                {"*", Multiply },
            };


        }

        static void OperationGet(string s) {

            // check if s is key in dictionary 
        }
    }
}
