using System;

namespace Events_and_MultiCastDelegates {
    internal class Program {

        // a MultiCast Delegate works as a list that can store a reference to more than one method 

        // useful in situations like this program where you have a lot of systems that you are using
        // starting/stopping etc - you can easily forget a call or call something twice - in order to prevent
        // this without MultiCase delegates you would need a lot of protective code to check if objects
        // are alive or have been called

        // you can at the bottom that the original way it was written we would have needed to call 
        // all the methods from the classes multiple times - for instance creating a new call for 
        // every player that is created 
        // with the mulitcast - you only need to trigger the event and it will call all the methods
        // subscribed to it - making it much cleaner and easier to work with and scale

        // things to notice - 
        // if you use = instead of += you will overwrite your event, removing all methods already subscribed 
        // you will not get an error if you use = and will have to figure out what is happening 
        
        // see constructor on Ln 14 of Player.cs for an example of the above and one other example not to do
        
        // so far we have been calling everything an event - but there is actually an event keyword and it is meant to 
        // prevent us from making the mistakes I illustrated in Player.cs
        // example on Ln19 of GameEventManager.cs

        static void Main(string[] args) {
            
            // create audio system object
            AudioSystem audioSystem = new AudioSystem();

            // create rendering engine object
            RenderingEngine renderingEngine = new RenderingEngine();

            // create two player objects and give them ID's
            Player player1 = new Player("SteelCow");
            Player player2 = new Player("DoggoSilva");
            Player player3 = new Player("CatTractorMan");

            // trigger OnGameStart event to fire all StartGame() methods in classes
            GameEventManager.TriggerGameStart();

            Console.WriteLine("Game is Running...\nPress any key to end the game.");

            // pause - simulating needing to press a key to shut everything down 
            Console.ReadKey();

            // trigger OnGameOver event to fire all GameOver() methods in classes
            GameEventManager.TriggerGameOver();
        }
    }
}

// this was all originally in main - I'm just leaving it here to see the difference before
// and after adding a Multicast delegate

//// start audio system and rendering engine 
//audioSystem.StartGame();
//renderingEngine.StartGame();

//// spawn players
//player1.StartGame();
//player2.StartGame();

//Console.WriteLine("Game is Running...\nPress any key to end the game.");

//// pause - simulating needing to press a key to shut everything down 
//Console.ReadKey();

//// stop audio system and rendering engine
//audioSystem.GameOver();
//renderingEngine.GameOver();

//// despawn players
//player1.GameOver();
//player2.GameOver();