using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nb1;
            int nb2;
            Console.Write("Iveskite pirma skaiciu: ");
            nb1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite antra skaiciu: ");
            nb2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Skaiciu suma yra {nb1 + nb2}");
            Console.ReadLine();
        }
    }
}
