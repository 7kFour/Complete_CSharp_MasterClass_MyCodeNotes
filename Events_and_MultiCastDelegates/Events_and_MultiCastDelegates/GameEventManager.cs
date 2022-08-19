using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_MultiCastDelegates {

    internal class GameEventManager {
        // a new delegate type called GameEvent
        public delegate void GameEvent();

        // create two delegate variables of our delegates type
        // you can make a Delegate like this but it will open you up to the issues listed in 
        // Player.cs Ln 14-26 and Program.cs Ln 19-26
        //public static GameEvent OnGameStart, OnGameOver;

        // use the event keyword instead 
        public static event GameEvent OnGameStart, OnGameOver;

        // static method to trigger OnGameStart
        // this is static so that we don't have to create an object in order to call this method
        public static void TriggerGameStart() {

            // check if OnGameStart event is not empty
            // meaning that other methods are already subscribed to it
            if (OnGameStart != null) {

                // print a simple message
                Console.WriteLine("The game has started...");

                // call OnGameStart that will trigger all methods subscribed to this event
                // so when this gets called it will trigger the OnGameStart() method in every 
                // class that is subscribed to the OnGameStart delegate 
                // this is basically going to do the work of all the audioSystem.StartGame(), rendering engine
                // and player calls we did in main at once
                OnGameStart();
            }
        }

        // static method to trigger OnGameOver
        public static void TriggerGameOver() {

            // check if OnGameOver event is not empty
            if (OnGameOver != null) {

                // output a message
                Console.WriteLine("The game is ending...");

                // call OnGameOver event triggering all methods subscribed to it
                OnGameOver();
            }
        }
    }
}
