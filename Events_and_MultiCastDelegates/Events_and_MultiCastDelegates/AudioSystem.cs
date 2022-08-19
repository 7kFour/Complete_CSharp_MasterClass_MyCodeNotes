using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_MultiCastDelegates {
    internal class AudioSystem {

        // constructor so that methods can be made private
        public AudioSystem() {
            //subscribe to the OnGameStart and OnGameOver events
            // when an object is created it's method will automatically get added (subscribe to)
            // the methods --- using += because we want to add it each time -- we will see what happens 
            // if we use = later
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        // at start of game, enable audio system and start playing audio clips
        private void StartGame() {
            Console.WriteLine("Audio System Started.");
            Console.WriteLine("Playing Audio...");
        }

        // when game is over, stop audio system
        private void GameOver() {
            Console.WriteLine("Audio System Stopped.");
        }
    }
}
