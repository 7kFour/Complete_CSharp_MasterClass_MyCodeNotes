using System;

namespace DateTimeDemo {
    internal class Program {

        // https://docs.microsoft.com/en-us/dotnet/api/system.datetime.kind?view=net-6.0

        static void Main(string[] args) {

            // this will still have a time - so it will be 12:00am since we didn't specify
            DateTime dT = new DateTime(1985, 11, 21);

            Console.WriteLine($"My birthday is {dT}");

            // write current date - this will say 12:00am since nothing is specified
            Console.WriteLine(DateTime.Today);

            // write current time with specific time expressed as local time from the computer
            Console.WriteLine(DateTime.Now);

            // using method to get tomorrows date
            DateTime tomorrow = GetTomorrow();
            Console.WriteLine($"Tomorrow will be {tomorrow}");

            // writing the day of the week 
            Console.WriteLine($"Today is {DateTime.Today.DayOfWeek} ");

            //show first day of year 
            DateTime firstDay = GetFirstDayOfYear(2023);
            Console.WriteLine($"First day of 2023 will be {firstDay}");

            // showing a specific date
            DateTime anni = ShowAniversary();
            Console.WriteLine($"My anniversary is {anni}");

            // show the number of days in Feb 2000
            int days = DateTime.DaysInMonth(2000, 2);
            Console.Write($"Days in Feb 2000: {days}");
            if (days == 29) {
                Console.WriteLine($", a leap year!");
            }

            // getting current minute on system clock when this is called
            DateTime now = DateTime.Now;
            Console.WriteLine($"Minute: {now.Minute}");

            // display time in format x hours y minutes z seconds
            DateTime nowFull = DateTime.Now;
            Console.WriteLine($"The current time is - {now.Hour}:{now.Minute}:{now.Second}");

            // time between now and date entered 
            Console.WriteLine("Write a date in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            // make sure that value entered is a DateTime
            if(DateTime.TryParse(input, out dT)) {
                Console.WriteLine(dT);
                // subtract the entered date from the current date
                TimeSpan daysPassed = now.Subtract(dT);
                Console.WriteLine($"Days passed since: {daysPassed.Days}"); // 89900 days have passed since jul 4 1776
            } else {
                Console.WriteLine("Wrong input");
            }

            // days passed since the entered birthday 
            Console.WriteLine("Please enter your birthday in the format yyyy-mm-dd");
            string bday = Console.ReadLine();

            // make sure input is proper format
            if (DateTime.TryParse(bday, out dT)) {
                TimeSpan dP = now.Subtract(dT);
                Console.WriteLine($"You were born {dP.Days} days ago");
            } else {
                Console.WriteLine("Wrong input");
            }

        }

        // method to get tomorrows date
        static DateTime GetTomorrow() {
            // adding 1 day to today
            return DateTime.Today.AddDays(1);
        }

        // first day of year 1/1/year
        static DateTime GetFirstDayOfYear(int year) {
            return new DateTime(year, 1, 1);
        }

        // show my anniversary 
        static DateTime ShowAniversary() {
            return new DateTime(2022, 4, 30, 13, 00, 00);
        }
    }
}
