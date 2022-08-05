using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challenge_VideoPost_Timer_Callback {

    // VideoPost class derives from Post
    internal class VideoPost : Post {

        // member fields 
        protected bool isPlaying = false;
        protected int currDuration = 0;
        // make sure you are using the timer from System.Threading 
        // VS will automatically make it the timer from System.Timer if you don't change it
        Timer timer;

        // unique class properties
        // protected can only be used by base class and derivative classes
        protected string VideoURL { get; set; }
        protected int VideoLength { get; set; }

        // constructors 

        // empty default constructor needed so that Post will use its own
        // default constructor if no parameters are passed on object instantiation
        public VideoPost() { }

        public VideoPost(string title, string sentBy, string url, int length, bool isPublic) {

            // the following properties and methods are inherited from Post
            this.ID = GetNextID();
            this.Title = title;
            this.SentByUsername = sentBy;
            this.IsPublic = isPublic;

            // These properties are members of VideoPost only 
            this.VideoURL = url;
            this.VideoLength = length;
        }

        // overriding ToString() method of Post class to handle URL property
        public override string ToString() {
            return String.Format($"{this.ID} - {this.Title} - {this.VideoURL} - by {this.SentByUsername}");
        }

        //initialize timer whenever Play() is called "play button pressed"
        public void Play() {

            // only need to initialize the timer if the video is "playing"
            // notice the negation
            if (!isPlaying) {
                // setting isPlaying to true so that Stop() functionality will work
                isPlaying = true;
                Console.WriteLine("Video playback started...");

                // TimerCallback executes the code you put in it in each time the duration lapses 
                //Timer(FunctionToDo, Object state, when it should start, how often to be repeated(duration))
                // null means object state doesn't matter, 0 means start immediately, 1000 repeats every 1000ms - 1 second
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        // will be called every 1000ms as set above
        // using private instead of protected because only this class needs to utilize the timer
        private void TimerCallback(Object o) {
            if (currDuration < VideoLength) {
                currDuration++;
                Console.WriteLine($"Video at {currDuration}s");

                // forcing garbage collector to clean up any messes from the timer
                GC.Collect();
            } else {
                Stop();
            }
        }

        public void Stop() {
           
            // only need to stop if video is playing
            if (isPlaying) {

                // setting isPlaying back to false so that Play() method if statement will work again
                isPlaying = false;
                Console.WriteLine($"Stopped at {currDuration}s");
                currDuration = 0;

                // stops Timer and resets it - otherwise it can cause a memory leak
                timer.Dispose();
            }
        }

    }
}
