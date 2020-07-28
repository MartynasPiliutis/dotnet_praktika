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
        }
    }   
}
