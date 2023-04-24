using System.Reflection.Metadata.Ecma335;

namespace MovieDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie List App!");
            Console.WriteLine();
           
            Movie m1 = new Movie("Spirited Away", "Animated", "2001", "2 hr 5 min");
            Movie m2 = new Movie("The Lion King", "Animated", "1994", "1 hr 27 min");
            Movie m3 = new Movie("Interstellar", "SciFi", "2014", "2 hr 49 min");
            Movie m4 = new Movie("I, Robot", "SciFi", "2004", "1 hr 55 min");
            Movie m5 = new Movie("No Country For Old Men", "Drama", "2007", "2 hr 2 min");
            Movie m6 = new Movie("Face/Off", "Drama", "1997", "2 hr 13 min");
            Movie m7 = new Movie("Silence of the Lambs", "Horror", "1991", "1 hr 58 min");
            Movie m8 = new Movie("Annihalation", "Horror", "2018", "2 hr");
            Movie m9 = new Movie("Memento", "Drama", "2000", "1 hr 53 min");
            Movie m10 = new Movie("Howl's Moving Castle", "Animated", "2004", "1 hr 59 min");

            List<Movie> movieList = new List<Movie>() { m1, m2, m3, m4, m5, m6, m7, m8, m9, m10};
            
            bool goOn = true;
            while (goOn)
            {
                Console.WriteLine("There are 10 movies in the list.");
                Console.WriteLine("What category would you like to view? (Animated, SciFi, Drama, Horror");
                string input = Console.ReadLine().ToLower();
                if (input == "SciFi".ToLower() || input == "Drama".ToLower() || input == "Horror".ToLower() || input == "Animated".ToLower())
                {
                    foreach (Movie m in movieList)
                    {
                        
                      if(m.DisplayTitle(input) != "")
                        {
                            Console.WriteLine(m.DisplayTitle(input) + " - Release Year: " + m.DisplayReleaseYear(input) + 
                                " - Run Time: " + m.DisplayRunTime(input));
                            
                        }
                        
                    }
                  
                }
                else
                {
                    Console.WriteLine("I didn't understand that. Please enter a category");
                    Console.WriteLine();
                    continue;
                }
                
                Console.WriteLine("Would you like to search again? y/n");
                string cont = Console.ReadLine();
                if (cont == "y")
                {
                    continue;
                }
                else if (cont == "n")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                
            }
          
        }
    }
}