using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "jokowi";
            var guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;
            while(guess != secretWord){
                if(guessCount < guessLimit){
                    Console.WriteLine($"your guess is {guessCount} and the limit is {guessLimit}.");
                    Console.Write("Enter your guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else{
                    outOfGuesses = true;
                    break;
                }
            }
            if(outOfGuesses){
                Console.WriteLine("You Lose!");
            }
            else{
                Console.WriteLine("You Win!");
            }
        }
    }
}