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
            Console.Write("Press any key for dice roll...");
            Console.ReadKey();
            Console.Clear();

            dice1 = rollDice.Next(1, 7);
            dice2 = rollDice.Next(1, 7);

            Console.WriteLine($"First dice: {dice1}");
            Console.WriteLine($"Second dice: {dice2}");
            Console.WriteLine("");
            Console.Write("Again? y/n");
            answer = Console.ReadLine();
            if (answer == "y")
            {
                Console.Clear();
                DiceRoll(rollDice, out dice1, out dice2, out answer);
            }
        }
    }
}
