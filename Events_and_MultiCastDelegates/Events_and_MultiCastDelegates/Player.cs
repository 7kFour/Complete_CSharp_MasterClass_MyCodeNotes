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

            // subscribing to OnGameStart and OnGameOver events
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;

            // dont do either one of these things
            // this will overwrite everything subscribed
            //GameEventManager.OnGameStart = StartGame;
            // this will call the method and fire everything each time you instantiate an object of this class
            //GameEventManager.OnGameStart();
        }

        // at start of game, spawn player
        // writing to console to simulate actions
        // this can be a good way to get all the pieces of your program working and connected before adding logic
        private void StartGame() {
            Console.WriteLine($"Spawning Player with ID: {PlayerName}");
        }

        // when the game is over, remove the player from the game world
        private void GameOver() {
            Console.WriteLine($"Removing Player with ID: {PlayerName}");
        }
    }
}
