using System;

namespace CSharp// <-class. namespace harus sama sama yang di Program.cs
{
    class song
    {
        public song (string title, string artist, int duration)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            songCount++;
        }
        public string Title;
        public string Artist;
        public int Duration;
        public static int songCount = 0; // static attribute 

        public int GetSongCount() // ada perbedaan static dan non static
        {
            return songCount;
        }
    }
}