using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Introduction_Pt2 {

    // like a social media post 
    // we want to inherit from this class to make specific types of posts
    // like an image post, video post etc
    internal class Post {

        private static int currentPostId;

        // properties - we make properties that give us information about our class
        // protected properties can only be used by the class they are part of 
        // and any of the classes that derive from that class
        // so these can be used by Post and anything that derives from Post
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SentByUsername { get; set; }
        protected bool IsPublic { get; set; }

        // Default constructor
        // if a derived class does not invoke a base class constructor explicitly
        // the default constructor is called implicitly 
        // eg all children of this class will use this constructor if a different isn't 
        // created inside them
        public Post() {
            ID = GetNextID();
            Title = "My First Post";
            IsPublic = true;
            SentByUsername = "Anthony S";
        }

        // Instance constructor with 3 parameters
        public Post(string title, bool isPublic, string sentByUsername) {
            this.ID = GetNextID();
            this.Title = title;
            this.SentByUsername = sentByUsername;
            this.IsPublic = isPublic;
        }

        // we want the post ID to be unique 
        protected int GetNextID() {

            // pre-incrementing -- increment the value then return it
            // we declared currentPostId but did not initialize it so
            // before this return gets called it has a default value of 0 assigned to it
            // on the first call it will increment to 1 then GetNextID() will return the value 1
            // and Post() will set ID to that returned 1 
            // on the next call it will increment to 2 
            // etc
            return ++currentPostId;
        }

        // want to be able to edit the text of a post 
        public void Update(string title, bool isPublic) {
            // the user obviously doesn't need to be update the post ID 
            // or their username 

            this.Title = title;
            this.IsPublic = isPublic;
        }

        // virtual method override of the ToString method that is inherited from System.Object
        public override string ToString() {

            // String.Format() just formated a string the way you specify 
            // Ex below 1 - Hi Everyone! - by Anthony S -- when yourPostObject.ToString() is called
            return String.Format($"{this.ID} - {this.Title} - by {this.SentByUsername}");
        }
    }
}
