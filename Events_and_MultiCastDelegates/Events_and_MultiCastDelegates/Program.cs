using System;

namespace Events_and_MultiCastDelegates {
    internal class Program {
        static void Main(string[] args) {
            
            // create audio system object
            AudioSystem audioSystem = new AudioSystem();

            // create rendering engine object
            RenderingEngine renderingEngine = new RenderingEngine();

            // create two player objects and give them ID's
            Player player1 = new Player("SteelCow");
            Player player2 = new Player("DoggoSilva");

            // start audio system and rendering engine 
            audioSystem.StartGame();
            renderingEngine.StartGame();

            // spawn players
            player1.StartGame();
            player2.StartGame();

            Console.WriteLine("Game is Running...\nPress any key to end the game.");

            // pause - simulating needing to press a key to shut everything down 
            Console.ReadKey();

            // stop audio system and rendering engine
            audioSystem.GameOver();
            renderingEngine.GameOver();

            // despawn players
            player1.GameOver();
            player2.GameOver();
        }
    }
}
