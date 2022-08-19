using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_MultiCastDelegates {
    internal class RenderingEngine {

        // constructor -- read notes in AudioSystem constructor for explanation
        public RenderingEngine() {

            // subscribe to OnGameStart and OnGameOver events
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        // at start of game 
        // enable rendering engine and start drawing visuals
        private void StartGame() {
            Console.WriteLine("Rendering Engine Started.");
            Console.WriteLine("Drawing visuals...");
        }

        // when game is over, stop rendering engine
        private void GameOver() {
            Console.WriteLine("Rendering Engine Stopped.");
        }
    }
}
