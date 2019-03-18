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
            NumberStats();
            Console.Read();
        }

        static void NumberStats()
        {
            Console.WriteLine("Please enter the  number");
            bool valid = true;

            while (valid)
            {
                checkIfPositive();
                checkIfIntOrDouble();
                checkIfOddOrEven();

                
                Console.WriteLine("Please enter Y if you want to test an other number or X to exit");
                string continueExe = Console.ReadLine();
                if (continueExe == "Y")
                {
                    Console.WriteLine("Plesae enter new number");
                    continue;
                }
                else if (continueExe == "X")
                {
                    Console.WriteLine("Press enter to exit");
                    break;
                } else
                {
                    Console.WriteLine("You must enter eather Y or N");
                    continue;
                }
            }
            
        }

        static string checkIfPositive()
        {
            string stringNumber = Console.ReadLine();
            double myDouble;
            bool cast = double.TryParse(stringNumber, out myDouble);
            if (cast)
            {
                if (myDouble > 0) Console.WriteLine("POSITIVE");
                else if (myDouble < 0) Console.WriteLine("NEGATIVE");
                else Console.WriteLine("ZERO");
            }
            else
            {
                Console.WriteLine("The input was not a number!");
            }
            return stringNumber;
        }
        static string checkIfIntOrDouble()
        {
            checkIfPositive();
            double myDouble;
            int myIntiger;
            bool castInt = Int32.TryParse(checkIfPositive(), out myIntiger);
            bool cast = double.TryParse(checkIfPositive(), out myDouble);
            if (cast)
            {
                if (myDouble % 1 == 0) Console.WriteLine("INTIGER");
                else if (myDouble % 1 != 0) Console.WriteLine("DOUBLE");
            }
            else if (castInt)
            {
                if (myDouble % 1 == 0) Console.WriteLine("INTIGER");
                else if (myDouble % 1 != 0) Console.WriteLine("DOUBLE");
            }
            else
            {
                Console.WriteLine("The input was not a number!");
            }
            return checkIfPositive();
        }

        static string checkIfOddOrEven()
        {
            checkIfPositive();
            double myDouble;
            bool cast = double.TryParse(checkIfPositive(), out myDouble);
            if (cast)
            {
                if (myDouble % 2 == 0) Console.WriteLine("EVEN");
                else if (myDouble % 2 == 1) Console.WriteLine("ODD");
            }
            else
            {
                Console.WriteLine("The input was not a number!");
            }
            return checkIfPositive();
        }
    }
}
