using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challenge_VideoPost_Timer_Callback {
    internal class Post {

        // will provide a unique ID for posts
        private static int currentPostId;

        // properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SentByUsername { get; set; }
        protected bool IsPublic { get; set; }

        // default constructor
        // called implicitly if a child class doesn't invoke a base 
        // constructor explicilty
        public Post() {
            ID = GetNextID();
            Title = "My First Post";
            IsPublic = true;
            SentByUsername = "Anonymous";
        }

        public Post(string title, bool isPublic, string sentBy) {
            this.ID = GetNextID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SentByUsername = sentBy;
        }

        // creating a unique ID for posts
        protected int GetNextID() {
            return ++currentPostId;
        }

        // ability to edit post title and privacy status
        public void Update(string title, bool isPublic) {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        // override ToString method of System.Object 
        public override string ToString() {

            return String.Format($"{this.ID} - {this.Title} - by {this.SentByUsername}"); 
        }
    }
}
