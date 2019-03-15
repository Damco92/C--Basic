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
            Console.WriteLine("Pleaase enter a number");
            string numberInput = Console.ReadLine();
            int num;
            bool castInt = Int32.TryParse(numberInput, out num);
            double dec;
            bool castDouble = Double.TryParse(numberInput, out dec); 
            bool valid = true;
            
            while (valid)
            {
                if (castInt)
                {
                    if (num > 0)
                    {
                        Console.WriteLine("POSITIVE");
                    } else if (num<0)
                    {
                        Console.WriteLine("NEGATIVE");
                    }
                    else 
                    {
                        Console.WriteLine("ZERO");
                    }
                    Console.WriteLine("INTIGER");

                    if (num % 2 == 0)
                    {
                        Console.WriteLine("EVEN");
                    } else if (num % 2 == 1)
                    {
                        Console.WriteLine("ODD");
                    }
                } else if (castDouble)
                {
                    if (dec > 0) Console.WriteLine("Positive");
                    else if (dec < 0) Console.WriteLine("Negative");
                    else Console.WriteLine("Zero");
                    Console.WriteLine("Double");
                    string decimalNumber = dec.ToString();
                    string lastDecimal = decimalNumber.Substring(decimalNumber.Length-1);
                    int finalNum = Convert.ToInt32(lastDecimal);
                    if (finalNum % 2 == 0) Console.WriteLine("Even decimal");
                    else if (finalNum % 2 == 1) Console.WriteLine("Odd decimal");
                }
                else
                {
                    throw new Exception("Wrong input you have to enter either intiger or double");
                }
                Console.WriteLine("Would you like to try again? Press Y to continue or x for exit");
                string goFurther = Console.ReadLine();
                if (goFurther == "Y")
                {
                    Console.WriteLine("Please enter next number");
                    string secondNumber = Console.ReadLine();
                    int newInt;
                    double newDouble;
                    bool castSecondInt = Int32.TryParse(secondNumber, out newInt);
                    bool castSecDouble = Double.TryParse(secondNumber, out newDouble);
                    if (castSecondInt)
                    { 
                        num = newInt;
                        continue;
                    }
                    else if (castSecDouble)
                    {
                        dec = newDouble;
                        continue;
                    }
                } 
                else if (goFurther == "X") break;
                else Console.WriteLine("Invalid input"); break;
            }
        }
    }
}
