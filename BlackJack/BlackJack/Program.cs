using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random CardDrop = new Random();
            int dealer;
            int player;
            int color;
            int face;
            char cardColor;
            string cardFace = "";
            int cardValue;
            char hearts = Convert.ToChar(9829);
            char diamonds = Convert.ToChar(9830);
            char clubs = Convert.ToChar(9827);
            char spades = Convert.ToChar(9824);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(hearts);
            Console.WriteLine(diamonds);
            Console.WriteLine(clubs);
            Console.WriteLine(spades);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(hearts);
            Console.WriteLine(diamonds);
            Console.WriteLine(clubs);
            Console.WriteLine(spades);
            Console.ReadLine();

            Console.Write("Press any key to start...");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ReadKey();
            Console.Clear();
            Console.ReadLine();

            color = CardDrop.Next(1, 5);
            face = CardDrop.Next(1, 14);

            if (color == 1) { cardColor = hearts; }
            if (color == 2) { cardColor = clubs; }
            if (color == 3) { cardColor = diamonds; }
            if (color == 4) { cardColor = spades; }

            if (face == 1) { cardFace = "A"; cardValue = 11; }
            if (face == 2) { cardFace = "2"; cardValue = 2; }
            if (face == 3) { cardFace = "3"; cardValue = 3; }
            if (face == 4) { cardFace = "4"; cardValue = 4; }
            if (face == 5) { cardFace = "5"; cardValue = 5; }
            if (face == 6) { cardFace = "6"; cardValue = 6; }
            if (face == 7) { cardFace = "7"; cardValue = 7; }
            if (face == 8) { cardFace = "8"; cardValue = 8; }
            if (face == 9) { cardFace = "9"; cardValue = 9; }
            if (face == 10) { cardFace = "10"; cardValue = 10; }
            if (face == 11) { cardFace = "J"; cardValue = 10; }
            if (face == 12) { cardFace = "Q"; cardValue = 10; }
            if (face == 13) { cardFace = "K"; cardValue = 10; }

            Console.WriteLine($"{cardColor} {cardFace}");

        }
    }   
}
