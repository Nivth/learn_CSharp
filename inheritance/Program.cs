using System;

// to run this code you need cd to this folder and <b>dotnet run</b> in the terminal

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef myChef = new Chef();
            ItalianChef myItalianChef = new ItalianChef();
            Console.WriteLine("The Chef:");
            myChef.make_special_dish();
            Console.WriteLine("The ItalianChef:");
            myItalianChef.make_special_dish();

        }
    }
}