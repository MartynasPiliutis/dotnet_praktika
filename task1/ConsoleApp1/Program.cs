using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string vardas = "";
            string pavarde = "";
            Console.Write("Iveskite varda: ");
            vardas = Console.ReadLine();
            Console.Write("Iveskite pavarde: ");
            pavarde = Console.ReadLine();
            Console.WriteLine($"{vardas}, {pavarde}");
            Console.ReadLine();
        }
    }
}
