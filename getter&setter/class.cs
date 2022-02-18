using System;

namespace CSharp// <-class. namespace harus sama sama yang di Program.cs
{
    class Film
    {
        public Film(string aName, double aRating, double aDuration)
        {
            name = aName;
            rating = aRating;
            duration = aDuration;
        }
        public string name = "";
        public double rating;
        public double duration;
    }
}