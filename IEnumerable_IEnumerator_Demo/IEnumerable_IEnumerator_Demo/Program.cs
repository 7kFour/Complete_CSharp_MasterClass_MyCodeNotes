using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerable_IEnumerator_Demo {

    // IEnumerable and IEnumerator are very important to understand - frequently used

    // IEnumerable interface is the base interface for many collections in C# and it's job is to provide
    // the way to iterate through a collection
    // this is why a Foreach loop works for going through a list or a dictionary for instance - they are inheriting 
    // from the IEnumerable interface

    // Simply put - when a collection class implements the IEnumerable interface it becomes countable and we can
    // count each element in it individually 

    // 2 versions of IEnumberable interface - one for generics and one for non-generic collections
    // 1. IEnumberable <T> for generic collections
    //      like List<T>, Dictionary<TKey, TValue>, SortedList<TKey, TValue>, Queue<T>, Stack<T>, Hashset<T>
    //      the <T> gets replaced by your type - List<int>, Dictionary<int, string> etc

    // 2. IEnumerable for non-generic collections
    //      Like ArrayList, SortedList, Stack, Queue, Hashtable, BitArray
    // Microsoft recommends not using non-generic collections in new code bases for performance reasons
    // https://github.com/dotnet/platform-compat/blob/master/docs/DE0006.md
    // IEnumerable for non-generic has to perform boxing and unboxing which basically is the conversion
    // of types of objects 
    // this is less effecience 

    /// <summary>
    /// IEnumerable<T> contains a single method that you must implement when imeplementing this interface
    /// GetEnumerator(), which returns an IEnumerator<T> object.
    /// The returned IEnumerator<T> provides the ability to iterate through the collection by 
    /// exposing a Current property that points at the object we are currently at in the collection.
    /// </summary>



    internal class Program {
        static void Main(string[] args) {

            DogShelter shelter = new DogShelter();

            // uncomment the foreach to see the error you would get if you tried to use the list we created
            // which doesn't implement IEnumerable
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1579

            //foreach(Dog dog in shelter) {
            //}

            // can fix this by implementing the IEnumerable<T> with <Dog> 
            // so class DogShelter {} becomes class DogShelter : IEnumerable<Dog>
            // then you can use a foreach loop
            // once the interface is implemented the class must then implement the interface 
            // member GetEnumerator()

            foreach(Dog dog in shelter) {
                if(!dog.IsNaughtyDog) {
                    dog.GiveTreat(2);
                } else {
                    dog.GiveTreat(1);
                }
            }

        }

        // keeping classes in same file to facilitate easier reading of notes

        class Dog {
            //properties
            public string Name { get; set; }
            public bool IsNaughtyDog { get; set; }

            // constructors
            public Dog(string name, bool isNaughty) {
                Name = name;
                IsNaughtyDog = isNaughty;
            }

            // member methods 
            
            // print how many treats the dog received
            // we will check if the dog is naughty or not - based on that
            // give it treats
            public void GiveTreat(int numTreats) {

                // one woof per treat
                // 1 treat if naughty
                // 2 treats if good
                Console.WriteLine($"Dog: {Name} said WOOF {numTreats} times!");
            }

        }

        // DogShelter class contains a generic collection of type Dog
        // objects of this class can't be used inside a foreach loop beacuse it lacks 
        // implementation of the IEnumerable interface
        
        class DogShelter : IEnumerable<Dog> {
            // list of type List<Dog> 
            // using System.Collections.Generic needed for the generic List<T>
            public List<Dog> dogs;

            // constructor to initialize dogs list with values 
            
            public DogShelter() {
                // initialize dogs list using the collection-initializer
                dogs = new List<Dog>() { 
                    new Dog("Casper", false),
                    new Dog("Sif", true),
                    new Dog("Oreo", false),
                    new Dog("Pixel", true),
                };
            }

            // returning an IEnumerator of type Dog
            // can have VS do this automatically when mousing over the error 
            IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator() {
                return dogs.GetEnumerator();
            }

            // this is returning a non-generic IEnumerator - we aren't using this but
            // if we get rid of it we are non longer properly implementing the IEnumerator interface
            // and the warning will come back 
            // so it can just be left like this but does need to be present for the class to be considered
            // implementing the interface 
            IEnumerator IEnumerable.GetEnumerator() {
                throw new NotImplementedException();
            }
        }
    }
}
