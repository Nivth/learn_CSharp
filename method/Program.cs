using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("woi");
            SayHi("nivek");
            Console.WriteLine(Cube(5));
        }
        static void SayHi(string user) // method are like function in javaScript
        {
            Console.WriteLine($"Hi {user}");
        }
        static int Cube(int num)
        {
            int result = num * num * num;
            return result; // return coyy
        }
        static int GetPow(int a, int b)
        {
            int result = 1;
            for (int i = 0; i < b; i++)
            {
                result *= a;
            }
            return result;
        }
    }
}