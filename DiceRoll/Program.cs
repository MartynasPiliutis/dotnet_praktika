using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace DiceRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rollDice = new Random();
            int dice1;
            int dice2;
            string answer;

            DiceRoll(rollDice, out dice1, out dice2, out answer);
        }

        private static void DiceRoll(Random rollDice, out int dice1, out int dice2, out string answer)
        {
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(28591);
            Console.Write("Press any key for dice roll...");
            Console.ReadKey();
            Console.Clear();

            dice1 = rollDice.Next(1, 7);
            dice2 = rollDice.Next(1, 7);
            int dice;
            Console.WriteLine($"First dice: {dice1}");
            dice = dice1;
            TheDice(dice);
            Console.WriteLine($"Second dice: {dice2}");
            dice = dice2;
            TheDice(dice);
            Console.WriteLine("");
            Console.Write("Again? y/n");
            answer = Console.ReadLine();
            if (answer == "y")
            {
                Console.Clear();
                DiceRoll(rollDice, out dice1, out dice2, out answer);
            }
        }

        private static void TheDice(int dice)
        {
            Console.WriteLine(" _________");
            Console.WriteLine("|         |");
            if (dice == 1)
            {
                RollOne();
            }
            if (dice == 2)
            {
                RollTwo();
            }
            if (dice == 3)
            {
                RollThree();
            }
            if (dice == 4)
            {
                RollFour();
            }
            if (dice == 5)
            {
                RollFive();
            }
            if (dice == 6)
            {
                RollSix();
            }

            Console.WriteLine("|_________|");
        }

        private static void RollOne()
        {
            Console.WriteLine("|         |");
            Console.WriteLine("|    *    |");
            Console.WriteLine("|         |");
        }
        private static void RollTwo()
        {
            Console.WriteLine("|  *      |");
            Console.WriteLine("|         |");
            Console.WriteLine("|      *  |");
        }
        private static void RollThree()
        {
            Console.WriteLine("|  *      |");
            Console.WriteLine("|    *    |");
            Console.WriteLine("|      *  |");
        }
        private static void RollFour()
        {
            Console.WriteLine("|  *   *  |");
            Console.WriteLine("|         |");
            Console.WriteLine("|  *   *  |");
        }
        private static void RollFive()
        {
            Console.WriteLine("|  *   *  |");
            Console.WriteLine("|    *    |");
            Console.WriteLine("|  *   *  |");
        }
        private static void RollSix()
        {
            Console.WriteLine("|  *   *  |");
            Console.WriteLine("|  *   *  |");
            Console.WriteLine("|  *   *  |");
        }
    }
}
