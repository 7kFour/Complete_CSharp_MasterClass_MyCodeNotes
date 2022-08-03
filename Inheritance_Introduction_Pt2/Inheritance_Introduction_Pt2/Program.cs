using System;

namespace Inheritance_Introduction_Pt2 {
    internal class Program {
        static void Main(string[] args) {

            // if we left it this way the default constructor would be used
            //Post post1 = new Post();

            // using the constructor with parameters
            Post post1 = new Post("Thanks for the birthday wishes!", true, "Anthony S");
            Console.WriteLine(post1.ToString());

            // now overriding ToString() method in Post with one from ImageURL
            ImagePost imagePost1 = new ImagePost("Check out my new shoes muh dude!", "Anthony S", 
                "https://images.fakeurl.com/shoes", true);
            Console.WriteLine(imagePost1.ToString());
        }
    }
}
