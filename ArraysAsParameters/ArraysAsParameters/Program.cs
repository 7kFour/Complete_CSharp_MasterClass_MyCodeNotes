using System;

namespace ArraysAsParameters {
    internal class Program {
        static void Main(string[] args) {
            int[] studentsGrades = new int[] { 83, 51, 89, 93, 94, 62, 78, 77 };
            double averageResult = GetAverage(studentsGrades);

            Console.Write("Individual grades:");
            foreach (int grade in studentsGrades) {
                Console.Write($"{grade} ");
            }

            Console.WriteLine($"\n\nThe class average score is: {averageResult}");
            Console.ReadKey();
        }

        // method to calculate the average of values in an array that has been passed as an argument
        static double GetAverage(int[] gradesArray) {
            // creating a size variable since we need size later to properly 
            // calculate average anyway
            int size = gradesArray.Length;
            double average = 0;
            int sum = 0;

            // iterate through array and add values to sum
            for(int i = 0; i < size; i++) {
                sum += gradesArray[i];
            }

            //casting to double so that we get a precise size
            average = (double)sum / size;
            return average;
        }

    }
}
