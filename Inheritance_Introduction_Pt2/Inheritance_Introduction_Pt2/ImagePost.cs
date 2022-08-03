using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Introduction_Pt2 {

    // ImagePost derives (the : indicates this) from Post and adds
    // a property (ImageURL) and two constructors
    internal class ImagePost : Post {

        // you would need a link to where the image being posted is stored
        // to use it in an image post
        public string ImageURL { get; set; }

        // constructors

        // I didn't understand his explanation -- but from what I can tell 
        // if you don't have this blank constructor then the default constructor
        // in Post won't be used and you'll get an error when instantiating a 
        // new ImagePost object if you don't supply the parameters required
        // by the constructor below 
        // because the default constructor in Post will be implicitly used
        // since we aren't explicitly calling anything with the base keyword
        // or our own logic
        public ImagePost() {

        }

        public ImagePost(string title, string sentByUsername, string imageURL, bool isPublic) {
            // Post doesn't know about ImageURL but ImagePost knows about all of the IDs
            // and methods we are inheriting from Post -- and that's inheritance 

            // the following properties and the method GetNextID  are inherited from Post
            this.ID = GetNextID();
            this.Title = title;
            this.SentByUsername = sentByUsername;
            this.IsPublic = isPublic;

            // the ImageURL property is a member of ImagePost, but not of Post
            this.ImageURL = imageURL;
        }

        // virtual method overriding ToString in Post because that is the class this one derives from
        // the ToString in Post overrides from System.Object
        public override string ToString() {
            
            // changing the format to handle the ImageURL property of this class
            return String.Format($"{this.ID} - {this.Title} - {this.ImageURL} - by {this.SentByUsername}");
        }
    }
}
