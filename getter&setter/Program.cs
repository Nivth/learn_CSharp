using System;

// to run this code you need cd to this folder and <b>dotnet run</b> in the terminal

namespace CSharp
{
    class Program
    {
        static void Main() // yang main itu yang di utamakan si program
        {
            Film film1 = new Film("The Shawshank Redemption", 9.3, 142);
            Film film2 = new Film("The Godfather", 9.2, 175);
            Film film3 = new Film("The Godfather: Part II", 9.0, 200);
            Film film4 = new Film("The Dark Knight", 9.0, 152);
            
            Console.WriteLine($"{film1.name} has a rating of {film1.rating} and a duration of {film1.duration} minutes");
        }
    }
}