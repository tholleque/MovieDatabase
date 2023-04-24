using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    internal class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public string ReleaseYear { get; set; }
        public string RunTime { get; set; }


        public Movie(string Title, string Category, string ReleaseYear, string RunTime)
        {
            this.Title = Title;
            this.Category = Category;
            this.ReleaseYear = ReleaseYear;
            this.RunTime = RunTime;

        }

        public override string ToString()
        {
            return Title;
        }
        public string DisplayTitle(string input)
        {
            if (Category.ToLower() == input.ToLower())
            {
                return Title;
            }
            return ""; 
        }
        public string DisplayReleaseYear(string input)
        {
            if (Category.ToLower() == input.ToLower())
            {
                return ReleaseYear;
            }
            return "";
        }
        public string DisplayRunTime(string input)
        {
            if (Category.ToLower() == input.ToLower())
            {
                return RunTime;
            }
            return "";
        }



    }
}
