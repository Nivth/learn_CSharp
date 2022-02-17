using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("<h1>Hanya mengingfokan</h1>");
            Console.Write("Mau ngajak apa? ");
            var ajak = Console.ReadLine();
            Console.Write("gaskeun ? ");
            var gas = Console.ReadLine();
            Console.Write("block nomer doi: ");
            var nomer = Console.ReadLine();
            Console.WriteLine("=================================");
            Console.WriteLine($"Bro hayuukk {ajak} bro");
            Console.WriteLine($"Yahahahahahaha hayukk {gas} cuy");
            Console.WriteLine($"{nomer}, yahahahah hayukkk");
        }
    }
}