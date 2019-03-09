using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateAge(1989);
            Console.Read();
        }

        static void CalculateAge(int birthYear)
        {
            Console.WriteLine($"Your birth year is {birthYear}");
            int currentYear = DateTime.Now.Year;
            int personsAge = currentYear - birthYear;
            Console.WriteLine($"The persons age is {personsAge}");
        }
    }
}
