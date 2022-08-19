using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_MultiCastDelegates {
    internal class AudioSystem {
        
        // at start of game, enable audio system and start playing audio clips
        public void StartGame() {
            Console.WriteLine("Audio System Started.");
            Console.WriteLine("Playing Audio...");
        }

        // when game is over, stop audio system
        public void GameOver() {
            Console.WriteLine("Audio System Stopped.");
        }
    }
}
