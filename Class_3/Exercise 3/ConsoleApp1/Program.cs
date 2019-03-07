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
            string[] group1Arr = new string[4] { "Damjan", "Bojana", "Stefi", "Samir" };
            string[] group2Arr = new string[4] { "Riste", "Borsilav", "Igor", "David" };
            string[] group3Arr = new string[4] { "Aleksandra", "Lidija", "Rezart", "Flora" };
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                foreach(string person in group1Arr)
                {
                    Console.WriteLine(person);
                }
            } else if (userInput == "2")
            {
                foreach(string person in group2Arr )
                {
                    Console.WriteLine(person);
                }
            }
            else if (userInput == "3")
            {
                foreach (string person in group3Arr)
                {
                    Console.WriteLine(person);
                }
            }
            Console.Read();
        }
    }
}
