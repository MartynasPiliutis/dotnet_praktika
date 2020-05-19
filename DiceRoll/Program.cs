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

            DrawDicesInline(dice1, dice2);
            //DrawDicesInlineV2(dice1, dice2);




            Console.Write("Again? y/n");
            answer = Console.ReadLine();
            if (answer == "y")
            {
                Console.Clear();
                DiceRoll(rollDice, out dice1, out dice2, out answer);
            }
        }
        /*private static void DrawDicesInlineV2(int dice1, int dice2)
        {
            string DrawDice1Line1 = "";
            string DrawDice1Line2 = "";
            string DrawDice1Line3 = "";

            string DrawDice2Line1 = "";
            string DrawDice2Line2 = "";
            string DrawDice2Line3 = "";

            DrawDice1Line1 = $"roll{dice1}1";
            DrawDice1Line2 = $"roll{dice1}2";
            DrawDice1Line3 = $"roll{dice1}3";

            DrawDice2Line1 = $"roll{dice2}1";
            DrawDice2Line2 = $"roll{dice2}2";
            DrawDice2Line3 = $"roll{dice2}3";

            string line11 = DrawDice1Line1;
            string line12 = DrawDice1Line2;
            string line13 = DrawDice1Line3;

            string line21 = DrawDice2Line1;
            string line22 = DrawDice2Line2;
            string line23 = DrawDice2Line3;

            string roll11 = "|         |";
            string roll12 = "|    *    |";
            string roll13 = "|         |";

            string roll21 = "|  *      |";
            string roll22 = "|         |";
            string roll23 = "|      *  |";

            string roll31 = "|  *      |";
            string roll32 = "|    *    |";
            string roll33 = "|      *  |";

            string roll41 = "|  *   *  |";
            string roll42 = "|         |";
            string roll43 = "|  *   *  |";

            string roll51 = "|  *   *  |";
            string roll52 = "|    *    |";
            string roll53 = "|  *   *  |";

            string roll61 = "|  *   *  |";
            string roll62 = "|  *   *  |";
            string roll63 = "|  *   *  |";




            Console.WriteLine(" _________   _________");
            Console.WriteLine("|         | |         |");
            Console.WriteLine($"{line11} {line21}");
            Console.WriteLine($"{line12} {line22}");
            Console.WriteLine($"{line13} {line23}");
            Console.WriteLine("|_________| |_________|");
        }*/


        private static void DrawDicesInline(int dice1, int dice2)
        {
            string roll11 = "|         |";
            string roll12 = "|    *    |";
            string roll13 = "|         |";

            string roll21 = "|  *      |";
            string roll22 = "|         |";
            string roll23 = "|      *  |";

            string roll31 = "|  *      |";
            string roll32 = "|    *    |";
            string roll33 = "|      *  |";

            string roll41 = "|  *   *  |";
            string roll42 = "|         |";
            string roll43 = "|  *   *  |";

            string roll51 = "|  *   *  |";
            string roll52 = "|    *    |";
            string roll53 = "|  *   *  |";

            string roll61 = "|  *   *  |";
            string roll62 = "|  *   *  |";
            string roll63 = "|  *   *  |";

            string dice1line1 = "";
            string dice1line2 = "";
            string dice1line3 = "";

            string dice2line1 = "";
            string dice2line2 = "";
            string dice2line3 = "";

            if (dice1 == 1)
            {
                dice1line1 = roll11;
                dice1line2 = roll12;
                dice1line3 = roll13;
            }
            if (dice1 == 2)
            {
                dice1line1 = roll21;
                dice1line2 = roll22;
                dice1line3 = roll23;
            }
            if (dice1 == 3)
            {
                dice1line1 = roll31;
                dice1line2 = roll32;
                dice1line3 = roll33;
            }
            if (dice1 == 4)
            {
                dice1line1 = roll41;
                dice1line2 = roll42;
                dice1line3 = roll43;
            }
            if (dice1 == 5)
            {
                dice1line1 = roll51;
                dice1line2 = roll52;
                dice1line3 = roll53;
            }
            if (dice1 == 6)
            {
                dice1line1 = roll61;
                dice1line2 = roll62;
                dice1line3 = roll63;
            }

            if (dice2 == 1)
            {
                dice2line1 = roll11;
                dice2line2 = roll12;
                dice2line3 = roll13;
            }
            if (dice2 == 2)
            {
                dice2line1 = roll21;
                dice2line2 = roll22;
                dice2line3 = roll23;
            }
            if (dice2 == 3)
            {
                dice2line1 = roll31;
                dice2line2 = roll32;
                dice2line3 = roll33;
            }
            if (dice2 == 4)
            {
                dice2line1 = roll41;
                dice2line2 = roll42;
                dice2line3 = roll43;
            }
            if (dice2 == 5)
            {
                dice2line1 = roll51;
                dice2line2 = roll52;
                dice2line3 = roll53;
            }
            if (dice2 == 6)
            {
                dice2line1 = roll61;
                dice2line2 = roll62;
                dice2line3 = roll63;
            }

            Console.WriteLine(" _________   _________");
            Console.WriteLine("|         | |         |");
            Console.WriteLine($"{dice1line1} {dice2line1}");
            Console.WriteLine($"{dice1line2} {dice2line2}");
            Console.WriteLine($"{dice1line3} {dice2line3}");
            Console.WriteLine("|_________| |_________|");
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


/*        private static void Roll1()
        {
            string roll11 = "|         |";
            string roll12 = "|    *    |";
            string roll13 = "|         |";
        }
        private static void Roll2()
        {
            string roll21 = "|  *      |";
            string roll22 = "|         |";
            string roll23 = "|      *  |";
        }
        private static void Roll3()
        {
            string roll31 = "|  *      |";
            string roll32 = "|    *    |";
            string roll33 = "|      *  |";
        }
        private static void Roll4()
        {
            string roll41 = "|  *   *  |";
            string roll42 = "|         |";
            string roll43 = "|  *   *  |";
        }
        private static void Roll5()
        {
            string roll51 = "|  *   *  |";
            string roll52 = "|    *    |";
            string roll53 = "|  *   *  |";
        }
        private static void Roll6()
        {
            string roll61 = "|  *   *  |";
            string roll62 = "|  *   *  |";
            string roll63 = "|  *   *  |";
        }*/
    }
}
