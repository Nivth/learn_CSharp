using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 }; // array coyyyy
            luckyNumbers[0] = 2; // array coyyyy
            luckyNumbers[4] = 22;
            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }
            //===============================================
            Console.WriteLine("=================================");
            string[] friends = new string[5];
            friends[0] = "alok";
            friends[1] = "asep kenalpot";
            friends[2] = "mamat";
            friends[3] = "valdi";
            for (int i = 0; i < friends.Length; i++)
            {
                Console.WriteLine(friends[i]);
            }
        }
    }
}