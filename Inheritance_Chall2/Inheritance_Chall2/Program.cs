using System;
using System.Threading;

namespace Inheritance_Chall2 {



    internal class Program {

        static void Main(string[] args) {

            Boss theBoss = new Boss("Donaldson", "Don", 431000, "Land Rover");
            theBoss.Lead();

            Console.WriteLine();

            Employee theEmployee = new Employee("Erikson", "Lief", 38000);
            theEmployee.Work();
            theEmployee.Pause();

            Console.WriteLine();

            Trainee theTrainee = new Trainee("Paulson", "Paula", 19400, "07-18", "19-23");
            theTrainee.Work();
            theTrainee.Learn();
        }
    }
}
