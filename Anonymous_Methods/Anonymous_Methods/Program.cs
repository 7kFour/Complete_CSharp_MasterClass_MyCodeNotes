using System;
using System.Collections.Generic;

namespace Anonymous_Methods
{
    internal class Program
    {

        // anonymous methods in c# can be defined using the delegate keyword
        // can be assigned to a variable of the delegate type 
        // so we dont have to define a method of our own each time we want to call a method
        // that meets a delegate 
        // especially useful if it's a method you only want to call one time 

        // defining a delegate of type called FilterDelegate that takes a person 
        // object and returns a bool
        public delegate bool FilterDelegate(Person p);

        static void Main(string[] args)
        {

            // creating a list of Person objects 
            Person p1 = new Person() { Name = "Aiden", Age = 41 };
            Person p2 = new Person() { Name = "Sif", Age = 69 };
            Person p3 = new Person() { Name = "Walter", Age = 12 };
            Person p4 = new Person() { Name = "Anatoli", Age = 25 };

            // add the objects to the list 
            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            // calling DisplayPeople method - passing "Kids", people list, and IsMinor method
            // we can pass IsMinor (or the other methods we created as filters) with no parameters
            // and no () because they match the signature for the FilterDelegate delegate
            // eg - they return a bool and have one parameter of type person
            DisplayPeople("Kids", people, IsMinor);

            DisplayPeople("Adults", people, IsAdult);

            DisplayPeople("Seniors", people, IsSenior);

            // created a new variable called filter of type FilterDelegate (the type we created above)
            // assigned an anonymous method to it instead of an already defined method
            // don't forget the ; at the end - because this is just declaring a variable but instead
            // of something like x = 3; we are initializing filter with an anomymous method 
            FilterDelegate filter = delegate (Person p)
            {
                return p.Age >= 20 && p.Age <= 30;
            };

            // can use filter variable because it is of type FilterDelegate just like DisplayPeople() expects
            DisplayPeople("Young Adult", people, filter);

            // you can also pass an anonymous method as an argument 
            // using the delegate keyword to define our anonymous function 
            // instead of passing in a filter method we already wrote we are just passing in 
            // (Person p) and returning true; -- this meets the requirements of DisplayPeople
            // because having a Person type object as a parameter and returning true is the 
            // requirement for a FilterDelegate type 
            DisplayPeople("All the people", people, delegate (Person p)
            {
                return true;
            });

        }

        // a method to display the list of people that passes the filter condition (returns true)
        // this method will take a title to be displayed, the list of people, and a filter delegate
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {

            // print the title
            Console.WriteLine(title);

            foreach (Person p in people)
            {
                // check if the person passes the filter
                if (filter(p))
                {
                    // print the person's name and age 
                    Console.WriteLine($"{p.Name}, {p.Age} years old");
                }
            }
        }

        // ========= Filter methods

        static bool IsMinor(Person p)
        {

            // return a bool after checking age against 18
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {

            return p.Age >= 18;
        }

        static bool IsSenior(Person p)
        {

            return p.Age >= 65;
        }


    }
}
