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
            string rep = "";
            int score = 0;
            int position = 10;
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
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.CursorTop);
            Console.Write("Press any key to start...");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ReadKey();
            Console.Clear();
            Console.ReadLine();

            //CARD 1
            GenerateCard(CardDrop, out color, out face, out cardFace, out cardValue);
            cardColor = SelectCardColor(color, hearts, diamonds, clubs, spades);
            position = DrawCard(face, cardColor, cardFace, position);
            score = ShowScore(score, cardValue);

            //Card 2
            GenerateCard(CardDrop, out color, out face, out cardFace, out cardValue);
            cardColor = SelectCardColor(color, hearts, diamonds, clubs, spades);
            position = DrawCard(face, cardColor, cardFace, position);
            score = ShowScore(score, cardValue);

            if (score == 21)
            {
                Console.WriteLine("BLACKJACK!!!");
            }
            else
            {
                Console.Write("Hit? y/n");
                rep = Console.ReadLine();
            }
            

            while (rep == "y")
            {
                GenerateCard(CardDrop, out color, out face, out cardFace, out cardValue);
                cardColor = SelectCardColor(color, hearts, diamonds, clubs, spades);
                position = DrawCard(face, cardColor, cardFace, position);
                score = ShowScore(score, cardValue);
                if (score < 21)
                {
                    Console.Write("Hit? y/n");
                    rep = Console.ReadLine();
                }
                else if (score == 21)
                {
                    Console.WriteLine("You won!");
                    rep = "n";
                }
                else
                {
                    Console.WriteLine("You LOST!");
                    rep = "n";
                }

            }

            Console.ReadLine();

        }

        private static int ShowScore(int score, int cardValue)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(Console.WindowWidth / 3 * 2, Console.CursorTop);
            score = score + cardValue;
            Console.WriteLine(" " + score.ToString("D2") + " ");
            return score;
        }

        private static int DrawCard(int face, char cardColor, string cardFace, int position)
        {
            Console.BackgroundColor = ConsoleColor.White;

            if (face != 10)
            {
                Console.SetCursorPosition(position, 10);
                Console.WriteLine("    ");
                Console.SetCursorPosition(position, Console.CursorTop);
                Console.WriteLine(" " + cardColor + cardFace + " ");
                Console.SetCursorPosition(position, Console.CursorTop);
                Console.WriteLine("    ");
                position = position + 5;
            }
            else
            {
                Console.SetCursorPosition(position, 10);
                Console.WriteLine("     ");
                Console.SetCursorPosition(position, Console.CursorTop);
                Console.WriteLine(" " + cardColor + cardFace + " ");
                Console.SetCursorPosition(position, Console.CursorTop);
                Console.WriteLine("     ");
                position = position + 6;
            }

            return position;
        }

        private static char SelectCardColor(int color, char hearts, char diamonds, char clubs, char spades)
        {
            char cardColor;
            if (color == 1)
            {
                cardColor = hearts;
                Console.ForegroundColor = ConsoleColor.Red;

            }
            else if (color == 2)
            {
                cardColor = clubs;
                Console.ForegroundColor = ConsoleColor.Black;

            }
            else if (color == 3)
            {
                cardColor = diamonds;
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                cardColor = spades;
                Console.ForegroundColor = ConsoleColor.Black;
            }

            return cardColor;
        }

        private static void GenerateCard(Random CardDrop, out int color, out int face, out string cardFace, out int cardValue)
        {
            color = CardDrop.Next(1, 5);
            face = CardDrop.Next(1, 14);

            if (face == 1) { cardFace = "A"; cardValue = 11; }
            else if (face == 2) { cardFace = "2"; cardValue = 2; }
            else if (face == 3) { cardFace = "3"; cardValue = 3; }
            else if (face == 4) { cardFace = "4"; cardValue = 4; }
            else if (face == 5) { cardFace = "5"; cardValue = 5; }
            else if (face == 6) { cardFace = "6"; cardValue = 6; }
            else if (face == 7) { cardFace = "7"; cardValue = 7; }
            else if (face == 8) { cardFace = "8"; cardValue = 8; }
            else if (face == 9) { cardFace = "9"; cardValue = 9; }
            else if (face == 10) { cardFace = "10"; cardValue = 10; }
            else if (face == 11) { cardFace = "J"; cardValue = 10; }
            else if (face == 12) { cardFace = "Q"; cardValue = 10; }
            else { cardFace = "K"; cardValue = 10; }
        }
    }   
}
