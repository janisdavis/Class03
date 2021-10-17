using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Movie
    {
        public string _title;
        public string _studio;
        public string _rating;

        public Movie(string aTitle, string aStudio, string aRating)
        {
            this._title = aTitle;
            this._studio = aStudio;
            this._rating = aRating;

        }

        public Movie(string aTitle, string aStudio)
        {
            this._title = aTitle;
            this._studio = aStudio;
            _rating = "PG";
        }
        
        public string ReturnRating()
        {
            return _rating;
        }
        
        public string ReturnTitle()
        {
            return _title;
        }
        
        public static Movie[] GetPG(Movie[] movie)
        {
            Movie[] pgMovie = new Movie[movie.Length];

            int newArrayIndex = 0;
            for (int i = 0; i < movie.Length; i++)
            {
                if (movie[i].ReturnRating() == "PG­")
                {
                    pgMovie[newArrayIndex] = movie[i];
                    newArrayIndex++;
                }
            }
            return pgMovie;
        }
        
        public override string ToString()
        {
            return $"{ _title} { _studio} { _rating} ";
        }
    }
}



