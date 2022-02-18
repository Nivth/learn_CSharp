using System;

// to run this code you need cd to this folder and <b>dotnet run</b> in the terminal

namespace CSharp
{
    class Program
    {
        static void Main() // yang main itu yang di utamakan si program
        {
            song hotelCalifornia = new song("Hotel California", "Eagles", 230);
            Console.WriteLine(hotelCalifornia.GetSongCount());
            song stronger = new song("Stronger", "Prismo", 332);
            Console.WriteLine($"The song {hotelCalifornia.Title} by {hotelCalifornia.Artist} lasts {hotelCalifornia.Duration} seconds");
            Console.WriteLine(song.songCount);
        }
    }
}