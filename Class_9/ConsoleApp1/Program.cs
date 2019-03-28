using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaApp;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           Movie movie1 = new Movie("Scary Movie", Genre.Comedy,2);
            Movie movie2 = new Movie("American Pie", Genre.Comedy, 4);
            Movie movie3 = new Movie("Saw", Genre.Horror, 4);
            Movie movie4 = new Movie("The Shining", Genre.Horror, 4);
            Movie movie5 = new Movie("Rambo", Genre.Action, 4);
            Movie movie6 = new Movie("The Terminator", Genre.Action, 4);
            Movie movie7 = new Movie("Forrest Gump", Genre.Drama, 4);
            Movie movie8 = new Movie("12 Angru Men", Genre.Drama, 4);
            Movie movie9 = new Movie("Passengers", Genre.Sci_Fi, 4);
            Movie movie10 = new Movie("Interstellar", Genre.Sci_Fi, 4);
            List<Movie> MovieSet1 = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };
            Movie movie11 = new Movie("Airplane", Genre.Comedy, 4);
            Movie movie12 = new Movie("Johnny English", Genre.Comedy, 4);
            Movie movie13 = new Movie("The Ring", Genre.Horror, 4);
            Movie movie14 = new Movie("Sinister", Genre.Horror, 4);
            Movie movie15 = new Movie("RoboCop", Genre.Action, 4);
            Movie movie16 = new Movie("Judge Dredd", Genre.Action, 4);
            Movie movie17 = new Movie("The Social Network", Genre.Drama, 4);
            Movie movie18 = new Movie("The Shawshank Redemption", Genre.Drama, 4);
            Movie movie19 = new Movie("Inception", Genre.Sci_Fi, 4);
            Movie movie20 = new Movie("Avatar", Genre.Sci_Fi, 4);
            List<Movie> MovieSet2 = new List<Movie>() { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };

            Cinema cinema1 = new Cinema("Cineplex");
            cinema1.Halls = new List<int>() { 1, 2, 3, 4 };
            cinema1.ListOfMovies = MovieSet1;
            Cinema cinema2 = new Cinema("Milenium");
            cinema2.Halls = new List<int>() { 1, 2 };
            cinema2.ListOfMovies = MovieSet2;


            Console.WriteLine("Please choose a cinema!");
            Console.WriteLine($"Please enter 1 for cinema {cinema1.Name}");
            Console.WriteLine($"Please enter 2 for cinema {cinema2.Name}");
            Cinema currentCinema = new Cinema();
            string userInput = Console.ReadLine();
            if(userInput == "1")
            {
                Console.WriteLine($"Welcome to {cinema1.Name} the best cinema in the city!");
                currentCinema = cinema1;
                Console.WriteLine($"Please enter 1 to see all the movies showing on here!");
                Console.WriteLine($"Please enter 2 if you want to filter through specific genre");
                string secondChoise = Console.ReadLine();
                if (secondChoise == "1")
                {
                    DisplayAllMovies(cinema1.ListOfMovies);
                }
                else if (secondChoise == "2")
                {
                    Console.WriteLine("Please enter the genre you want to filtter the movies through!");
                    string genreChoise = Console.ReadLine();
                    switch (genreChoise)
                    {
                        case "Horror":
                            {
                                List<Movie> horrorMovies = currentCinema.ListOfMovies.Where(x => x.Genre == Genre.Horror).ToList();
                                DisplayAllMovies(horrorMovies);
                                Console.WriteLine("Please write the name of the movie you want to watch!");
                                string movieInput = Console.ReadLine();
                                List<Movie> moviePlaying1 = horrorMovies.Where(x => movieInput == x.Title).ToList();
                                foreach (var movie in moviePlaying1)
                                {
                                    Console.WriteLine("The movie" + movie.Title + "is playing");
                                }
                                break;
                            }
                        case "Comedy":
                            {
                                List<Movie> comedyMovies = currentCinema.ListOfMovies.Where(x => x.Genre == Genre.Comedy).ToList();
                                DisplayAllMovies(comedyMovies);
                                Console.WriteLine("Please write the name of the movie you want to watch!");
                                string inputMovie2 = Console.ReadLine();
                                List<Movie> moviePlaying2 = comedyMovies.Where(x => inputMovie2 == x.Title).ToList();
                                foreach (var movie in moviePlaying2)
                                {
                                    Console.WriteLine("The movie" + movie.Title + "is playing");
                                }
                                break;
                            }
                        case "Drama":
                            List<Movie> dramaMovies = currentCinema.ListOfMovies.Where(x => x.Genre == Genre.Drama).ToList();
                            DisplayAllMovies(dramaMovies);
                            Console.WriteLine("Please write the name of the movie you want to watch!");
                            string inputMovie3 = Console.ReadLine();
                            List<Movie> moviePlaying3 = dramaMovies.Where(x => inputMovie3 == x.Title).ToList();
                            foreach (var movie in moviePlaying3)
                            {
                                Console.WriteLine("The movie" + movie.Title + "is playing");
                            }
                            break;
                        case "Action":
                            List<Movie> action = currentCinema.ListOfMovies.Where(x => x.Genre == Genre.Action).ToList();
                            DisplayAllMovies(action);
                            Console.WriteLine("Please write the name of the movie you want to watch!");
                            string inputMovie4 = Console.ReadLine();
                            List<Movie> moviePlaying4 = action.Where(x => inputMovie4 == x.Title).ToList();
                            foreach (var movie in moviePlaying4)
                            {
                                Console.WriteLine("The movie" + movie.Title + "is playing");
                            }
                            break;
                        case "SciFi":
                            List<Movie> sciFi = currentCinema.ListOfMovies.Where(x => x.Genre == Genre.Sci_Fi).ToList();
                            DisplayAllMovies(sciFi);
                            Console.WriteLine("Please write the name of the movie you want to watch!");
                            string inputMovie5 = Console.ReadLine();
                            List<Movie> moviePlaying5 = sciFi.Where(x => inputMovie5 == x.Title).ToList();
                            foreach (var movie in moviePlaying5)
                            {
                                Console.WriteLine("The movie" + movie.Title + "is playing");
                            }
                            break;
                        default:
                            throw new Exception("You must enter the correct genre name!");
                    }
                }
            }
            else if (userInput == "2")
            {
                Console.WriteLine($"Welcome to {cinema2.Name} the best cinema in the city!");
                currentCinema = cinema2;
                Console.WriteLine($"Please enter 1 to see all the movies showing on here!");
                Console.WriteLine($"Please enter the genre if you want to filter through specific genre");
                string secondChoise = Console.ReadLine();
                if (secondChoise == "1")
                {
                    DisplayAllMovies(cinema2.ListOfMovies);
                }
                else if(secondChoise == "2")
                {
                    Console.WriteLine("Please enter the genre you want to filtter the movies through!");
                    Console.WriteLine("Please enter the genre you want to filtter the movies through!");
                    string genreChoise = Console.ReadLine();
                    switch (genreChoise)
                    {
                        case "Horror":
                            {
                                List<Movie> horrorMovies = currentCinema.ListOfMovies.Where(x => x.Genre == Genre.Horror).ToList();
                                DisplayAllMovies(horrorMovies);
                                Console.WriteLine("Please write the name of the movie you want to watch!");
                                string movieInput = Console.ReadLine();
                                List<Movie> moviePlaying1 = horrorMovies.Where(x => movieInput == x.Title).ToList();
                                foreach (var movie in moviePlaying1)
                                {
                                    Console.WriteLine("The movie" + movie.Title + "is playing");
                                }
                                break;
                            }
                        case "Comedy":
                            {
                                List<Movie> comedyMovies = currentCinema.ListOfMovies.Where(x => x.Genre == Genre.Comedy).ToList();
                                DisplayAllMovies(comedyMovies);
                                Console.WriteLine("Please write the name of the movie you want to watch!");
                                string inputMovie2 = Console.ReadLine();
                                List<Movie> moviePlaying2 = comedyMovies.Where(x => inputMovie2 == x.Title).ToList();
                                foreach (var movie in moviePlaying2)
                                {
                                    Console.WriteLine("The movie" + movie.Title + "is playing");
                                }
                                break;
                            }
                        case "Drama":
                            List<Movie> dramaMovies = currentCinema.ListOfMovies.Where(x => x.Genre == Genre.Drama).ToList();
                            DisplayAllMovies(dramaMovies);
                            Console.WriteLine("Please write the name of the movie you want to watch!");
                            string inputMovie3 = Console.ReadLine();
                            List<Movie> moviePlaying3 = dramaMovies.Where(x => inputMovie3 == x.Title).ToList();
                            foreach (var movie in moviePlaying3)
                            {
                                Console.WriteLine("The movie" + movie.Title + "is playing");
                            }
                            break;
                        case "Action":
                            List<Movie> action = currentCinema.ListOfMovies.Where(x => x.Genre == Genre.Action).ToList();
                            DisplayAllMovies(action);
                            Console.WriteLine("Please write the name of the movie you want to watch!");
                            string inputMovie4 = Console.ReadLine();
                            List<Movie> moviePlaying4 = action.Where(x => inputMovie4 == x.Title).ToList();
                            foreach (var movie in moviePlaying4)
                            {
                                Console.WriteLine("The movie" + movie.Title + "is playing");
                            }
                            break;
                        case "SciFi":
                            List<Movie> sciFi = currentCinema.ListOfMovies.Where(x => x.Genre == Genre.Sci_Fi).ToList();
                            DisplayAllMovies(sciFi);
                            Console.WriteLine("Please write the name of the movie you want to watch!");
                            string inputMovie5 = Console.ReadLine();
                            List<Movie> moviePlaying5 = sciFi.Where(x => inputMovie5 == x.Title).ToList();
                            foreach (var movie in moviePlaying5)
                            {
                                Console.WriteLine("The movie" + movie.Title + "is playing");
                            }
                            break;
                        default:
                            throw new Exception("You must enter the correct genre name!");
                    }
                }
            }
            else
            {
                throw new Exception("You must enter eather 1 or 2");
            }

            

            Console.Read();
        }
        static void DisplayAllMovies(List<Movie> moviesShowingOn)
        {
            foreach (var movie in moviesShowingOn)
            {
                Console.WriteLine(movie.Title);
            }
        }
    }
}
