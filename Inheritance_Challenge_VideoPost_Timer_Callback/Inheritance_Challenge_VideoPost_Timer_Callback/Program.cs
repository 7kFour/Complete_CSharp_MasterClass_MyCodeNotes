using System;
using System.Threading;

namespace Inheritance_Challenge_VideoPost_Timer_Callback {
    internal class Program {

        static void Main(string[] args) {
            
            Post post1 = new Post("Japanese is a bit difficult to learn...", true, "Anthony S");

            ImagePost imagePost1 = new ImagePost("Check out this cool game trailer!", "Anthony S", "https://coolcat.videos.com", true);

            // the 10 is the 'length' in seconds - this means the playback will also stop after 10s
            // without any user input
            VideoPost videoPost1 = new VideoPost("Fail Video", "Anthony", "https://failvid.com/FakeUrl", 10, true);
            
            Console.WriteLine(post1.ToString());
            Console.WriteLine(imagePost1.ToString());
            Console.WriteLine(videoPost1.ToString());

            // start video 
            videoPost1.Play();

            // when user enters key press timer will stop 
            Console.WriteLine("Press any key to stop the video");
            Console.ReadKey();

            // user key press will allow Stop() to be called stopping the timer and outputting the duration
            videoPost1.Stop();
            // allows the timer duration to remain on the console for viewing
            Console.ReadKey();
        }
    }
}