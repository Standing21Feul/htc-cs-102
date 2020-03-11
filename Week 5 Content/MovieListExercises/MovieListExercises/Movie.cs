using System;
using System.Windows;

namespace MovieList
{
    public class Movie
    {
        public string Title
        {
            get;
            set;
        }

        public int ReleaseYear
        {
            get;
            set;
        }

        public double RottenTomatoesScore
        {
            get;
            set;
        }

        public void ShowDetails()
        {
            string infoString = "Title: " + this.Title;
            infoString += "\nRelease Year: " + this.ReleaseYear;
            MessageBox.Show(infoString);
        }

        public Movie(string myTitle, int myReleaseYear, double myRottenTomatoesScore)
        {
            this.Title = myTitle;
            this.ReleaseYear = myReleaseYear;
            this.RottenTomatoesScore = myRottenTomatoesScore;
        }
    }
}
