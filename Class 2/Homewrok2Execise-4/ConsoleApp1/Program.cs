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
            Console.WriteLine("Pleae insert cal to start calculating or e to exit");
            string start = Console.ReadLine();
            while (start == "cal")
            {
                Console.Write("Pleae enter first num");
                string firstNumStr = Console.ReadLine();
                int numOne;
                Console.Write("Please enter second num");
                string secondNumStr = Console.ReadLine();
                int numTwo;
                Console.WriteLine("Please enter operator");
                string operatiorInput = Console.ReadLine();
                bool castNumOne = Int32.TryParse(firstNumStr, out numOne);
                bool castNumTwo = Int32.TryParse(secondNumStr, out numTwo);

                if (castNumOne == true && castNumTwo == true)
                {
                    switch (operatiorInput)
                    {
                        case "+":
                            int sumResult = numOne + numTwo;
                            Console.Write("The summed value from " + numOne + operatiorInput + numTwo + " is " + sumResult);
                            break;
                        case "-":
                            int subResult = numOne - numTwo;
                            Console.Write("The substracted value from " + numOne + operatiorInput + numTwo + " is " + subResult);
                            break;
                        case "*":
                            int multyResult = numOne * numTwo;
                            Console.Write("The multiplied value from " + numOne + operatiorInput + numTwo + " is " + multyResult);
                            break;
                        case "/":
                            int devideResult = numOne / numTwo;
                            Console.Write("The devided value from " + numOne + operatiorInput + numTwo + " is " + devideResult);
                            break;
                        default:
                            Console.WriteLine( "You entered invalid operator you will now exit");
                            break;
                    }
                }
                Console.WriteLine("Please enter y to continue calculating or n to exit");
                string secCheck = Console.ReadLine();
                if (secCheck == "y")
                {
                    continue;
                } else if (secCheck == "n")
                {
                    Console.WriteLine("You have exit the calculator");
                    break;
                } else
                {
                    Console.WriteLine("You need to insert eather y or n! No other character of value is accepted");
                    break;
                }
            }
            Console.Read();

        }
    }
}
