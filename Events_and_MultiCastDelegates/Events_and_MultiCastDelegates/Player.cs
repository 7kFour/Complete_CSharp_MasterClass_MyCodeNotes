using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_MultiCastDelegates {
    internal class Player {

        // player name
        public string PlayerName { get; set; }

        // simple constructor 
        public Player(string n) {
            this.PlayerName = n;
        }

        // at start of game, spawn player
        // writing to console to simulate actions
        // this can be a good way to get all the pieces of your program working and connected before adding logic
        public void StartGame() {
            Console.WriteLine($"Spawning Player with ID: {PlayerName}");
        }

        // when the game is over, remove the player from the game world
        public void GameOver() {
            Console.WriteLine($"Removing Player with ID: {PlayerName}");
        }
    }
}
