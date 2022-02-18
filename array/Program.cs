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

            //===============================================
            Console.WriteLine("=================================");
            
            int[,] matrix = { // 2d array
                 { 1, 2, 3 },
                 { 4, 5, 6 },
                 { 7, 8, 9 }  //9, 9, 9
            };

            Console.WriteLine(matrix[1, 1]); // 5
            var cirno = matrix[2, 2]; // 9
            int woi = matrix[2, 1] = 9;
            var funky = matrix[2, 0] = 9;
            Console.WriteLine($"{woi}{cirno}{funky}");
            Console.WriteLine($"cirno coyyy {cirno}");

            Console.WriteLine("=================================");

            string[,] name = new string[2, 2]; //row and column
            name[0, 0] = "alok";
            name[0, 1] = "asep";
            name[1, 0] = "udin";
            name[1, 1] = "mamat";
            for (int i = 0; i < name.GetLength(0); i++)
            {
                for (int j = 0; j < name.GetLength(1); j++)
                {
                    Console.WriteLine(name[i, j]);
                }
            }
        }
    }
}