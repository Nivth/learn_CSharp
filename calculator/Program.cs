using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the operator: ");
            string method = Console.ReadLine();
            if (method == "+")
            {
                Console.Write("Enter the first number: ");
                int first = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the second number: ");
                int second = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The result is: " + (first + second));
            }
            else if (method == "-")
            {
                Console.Write("Enter the first number: ");
                int first = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the second number: ");
                int second = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The result is: " + (first - second));
            }
            else if (method == "*")
            {
                Console.Write("Enter the first number: ");
                int first = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the second number: ");
                int second = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The result is: " + (first * second));
            }
            else if (method == "/")
            {
                Console.Write("Enter the first number: ");
                int first = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the second number: ");
                int second = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The result is: " + (first / second));
            }
            else if (method == "%")
            {
                Console.Write("Enter the first number: ");
                int first = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the second number: ");
                int second = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The result is: " + (first % second));
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }
        }
    }
}
