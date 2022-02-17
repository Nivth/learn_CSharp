using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            if (isMale)
            {
                Console.WriteLine("You are a man");
            }
            else
            {
                Console.WriteLine("You are a woman");
            }
            Console.WriteLine(GetMax(8, 99, 80));
        }
        static string GetMax(int num1, int num2, int num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                return "the number 1 is bigger";
            }
            else if (num2 > num1 && num2 > num3)
            {
                return "the number 2 is bigger";
            }
            else
            {
                return "the number 3 is bigger"; // return
            }
        }
    }
}