using System;

namespace Properties_Pt2 {
    internal class Program {
        static void Main(string[] args) {

            Box anotherBox = new Box(7, 8, 9);
            anotherBox.Width = 10;
            anotherBox.DisplayInfo();

            Console.WriteLine($"Front surface of box is: {anotherBox.FrontSurface}");
        }
    }
}
