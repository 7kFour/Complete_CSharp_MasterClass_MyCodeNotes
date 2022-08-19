using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_MultiCastDelegates {
    internal class RenderingEngine {

        // at start of game 
        // enable rendering engine and start drawing visuals

        public void StartGame() {
            Console.WriteLine("Rendering Engine Started.");
            Console.WriteLine("Drawing visuals...");
        }

        // when game is over, stop rendering engine
        public void GameOver() {
            Console.WriteLine("Rendering Engine Stopped.");
        }
    }
}
