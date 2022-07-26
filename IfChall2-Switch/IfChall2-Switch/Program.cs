using System;

namespace IfChall2_Switch {
    // see onenote for challenge question
    // CSharp > Csharp Masterclass > Switch/If Statement Chall 2
    internal class Program {
        // global variables go here 
        public static int highscore = 125000;
        public static string highscorePlayer = "Dumptruck Face";
        
        static void Main(string[] args) {

            EnterScore();
        }

        public static void EnterScore() {
            Console.Write("Please enter your score: ");
            string score = Console.ReadLine();

            Console.Write("Please enter your name: ");
            string playerName = Console.ReadLine();

            ScoreCheck(score, playerName);
        }

        public static void DidntBeatScore() {
            Console.WriteLine($"The old highscore of {highscore} could not be broken and is " +
                $"still held by {highscorePlayer}.");
        }

        public static void BeatScore(string score, string playerName) {
            Console.WriteLine($"New highscore is {score}!\nNew highscore holder is {playerName}!");
        }

        public static void ScoreCheck(string score, string playerName) {
            int s = 0;
            bool goodParse = int.TryParse(score, out s);
            if (goodParse) {
                if (s > highscore) {
                    BeatScore(score, playerName);
                    highscore = s;
                    highscorePlayer = playerName;
                } else {
                    DidntBeatScore();
                }
            } else {
                Console.WriteLine("Please enter only integers for your score value!");
            }

        }

    }
}
