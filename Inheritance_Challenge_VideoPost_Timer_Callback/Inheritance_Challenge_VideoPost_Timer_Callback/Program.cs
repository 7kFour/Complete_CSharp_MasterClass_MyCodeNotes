using System;
using System.Threading;

namespace Inheritance_Challenge_VideoPost_Timer_Callback {
    internal class Program {

        static bool isPlaying = false;
        static Timer timer = null;
        static int length = 10;
        static int currDuration = 0;

        static void Main(string[] args) {

            Play();

        }

        public static void Play() {

            // if it's playing
            if (!isPlaying) {
                Console.WriteLine("playing...");
                // do the TimerCallBack, no object state, until I stop it, every 1000ms
                timer = new Timer(TimerCallback, null, 0, 1000);
            } else {
                Stop();
            }
        }

        private static void TimerCallback(Object o) {
            if (currDuration < length) {
                currDuration++;
                Console.WriteLine($"video at {currDuration}");

                // trigger garbage collector to clean up
                GC.Collect();
            } else {
                Stop();
            }
        }

        public static void Stop() {
            Console.WriteLine($"Stopped at {currDuration}");
            currDuration = 0;
            timer.Dispose();
        }

    }
}
