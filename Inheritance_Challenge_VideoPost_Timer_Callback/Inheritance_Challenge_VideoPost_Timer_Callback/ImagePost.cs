using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challenge_VideoPost_Timer_Callback {

    // ImagePost derives from Post 
    internal class ImagePost : Post {

        // unique class property
        public string ImageURL { get; set; }

        // constructors

        // empty default constructor needed so that Post will use its own
        // default constructor if no parameters are passed on object instantiation
        public ImagePost() { }

        public ImagePost(string title, string sentBy, string url, bool  isPublic) {

            // the following properties and methods are inherited from Post
            this.ID = GetNextID();
            this.Title = title;
            this.SentByUsername = sentBy;
            this.IsPublic = isPublic;

            this.ImageURL = url;
        }

        // overriding ToString() method of Post class to handle URL property
        public override string ToString() {
            return String.Format($"{this.ID} - {this.Title} - {this.ImageURL} - by {this.SentByUsername}");
        }

    }
}
