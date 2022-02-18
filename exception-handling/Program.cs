using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { // kaya try catch javascript coyyyy
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The number is: {0}", number);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can't divide by zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("You didn't enter a number");
            }
            finally
            {
                Console.WriteLine("Good bye"); //pasti dijalankan
            }
        }
    }
}