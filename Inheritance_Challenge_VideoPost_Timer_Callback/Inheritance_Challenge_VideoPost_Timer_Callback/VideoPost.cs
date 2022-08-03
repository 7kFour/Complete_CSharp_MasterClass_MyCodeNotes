using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challenge_VideoPost_Timer_Callback {

    // VideoPost class derives from Post
    internal class VideoPost : Post {

        // unique class properties
        public string VideoURL { get; set; }
        public float VideoLength { get; set; }

        // constructors 

        // empty default constructor needed so that Post will use its own
        // default constructor if no parameters are passed on object instantiation
        public VideoPost() { }

        public VideoPost(string title, string sentBy, string url, float length, bool isPublic) {

            // the following properties and methods are inherited from Post
            this.ID = GetNextID();
            this.Title = title;
            this.SentByUsername = sentBy;
            this.IsPublic = isPublic;

            this.VideoURL = url;
            this.VideoLength = length;
        }

        // overriding ToString() method of Post class to handle URL property
        public override string ToString() {
            return String.Format($"{this.ID} - {this.Title} - {this.VideoURL} - by {this.SentByUsername}");
        }
    }
}
