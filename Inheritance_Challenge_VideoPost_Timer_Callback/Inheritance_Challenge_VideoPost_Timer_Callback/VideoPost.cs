using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challenge_VideoPost_Timer_Callback {

    // VideoPost class derives from Post
    internal class VideoPost : Post {

        // unique class properties
        public string VideoURL { get; set; }
        public Timer VideoLength { get; set; }

        // constructors 

        // empty default constructor needed so that Post will use its own
        // default constructor if no parameters are passed on object instantiation
        public VideoPost() { }

        public VideoPost(string title, string sentBy, string url, Timer length, bool isPublic) {

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

        // creates a timer to mimic a video playback time
        public void GetVideoLength() {
            // creating a timer and setting interval to 1000ms 
            Timer vidLen = new Timer(1000);
            // each 1000ms this will execute the OnTimedEvent method
            vidLen.Elapsed += new ElapsedEventHandler(OnTimedEvent);

            // starting timer when method gets called
            vidLen.Enabled = true; 
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e) {
            
        }

        // create method to stop timer and dispose of it
        // must dispose of timers when you are done with them with timerName.Dispose()

    }
}
