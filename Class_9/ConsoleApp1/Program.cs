using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Scary Movie", Genre.Comedy,4,2);
            Movie movie2 = new Movie("American Pie", Genre.Comedy, 4, 2);
            Movie movie3 = new Movie("Saw", Genre.Horror, 4, 2);
            Movie movie4 = new Movie("The Shining", Genre.Horror, 4, 2);
            Movie movie5 = new Movie("Rambo", Genre.Action, 4, 2);
            Movie movie6 = new Movie("The Terminator", Genre.Action, 4, 2);
            Movie movie7 = new Movie("Forrest Gump", Genre.Comedy, 4, 2);
            Movie movie8 = new Movie("12 Angru Men", Genre.Comedy, 4, 2);
            Movie movie9 = new Movie("Passengers", Genre.Action, 4, 2);
            Movie movie10 = new Movie("Interstellar", Genre.Action, 4, 2);
            List<Movie> MovieSet1 = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };
            Movie movie11 = new Movie("Airplane", Genre.Comedy, 4, 2);
            Movie movie12 = new Movie("Johnny English", Genre.Comedy, 4, 2);
            Movie movie13 = new Movie("The Ring", Genre.Horror, 4, 2);
            Movie movie14 = new Movie("Sinister", Genre.Horror, 4, 2);
            Movie movie15 = new Movie("RoboCop", Genre.Action, 4, 2);
            Movie movie16 = new Movie("Judge Dredd", Genre.Action, 4, 2);
            Movie movie17 = new Movie("The Social Network", Genre.Horror, 4, 2);
            Movie movie18 = new Movie("The Shawshank Redemption", Genre.Horror, 4, 2);
            Movie movie19 = new Movie("Inception", Genre.Action, 4, 2);
            Movie movie20 = new Movie("Avatar", Genre.Action, 4, 2);
            List<Movie> MovieSet2 = new List<Movie>() { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };

            Hall cinema1 = new Hall("Cineplex");
            cinema1.Halls = new List<int>() { 1, 2, 3, 4 };
            cinema1.moviesList = MovieSet1;
            Hall cinema2 = new Hall("Milenium");
            cinema2.Halls = new List<int>() { 1, 2 };
            cinema2.moviesList = MovieSet2;



        }
    }
}
