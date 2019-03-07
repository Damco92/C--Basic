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
            bool calculate = true;

            if (start == "cal")
            {
                while (calculate)
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
                                Console.WriteLine("Please enter y to continue calculating or n to exit");
                                string choiseSum = Console.ReadLine();
                                if (choiseSum == "n")
                                {
                                    calculate = false;
                                }
                                break;
                            case "-":
                                int subResult = numOne - numTwo;
                                Console.Write("The substracted value from " + numOne + operatiorInput + numTwo + " is " + subResult);
                                Console.WriteLine("Please enter y to continue calculating or n to exit");
                                string choiseSub = Console.ReadLine();
                                if (choiseSub == "n")
                                {
                                    calculate = false;
                                }
                                break;
                            case "*":
                                int multyResult = numOne * numTwo;
                                Console.Write("The multiplied value from " + numOne + operatiorInput + numTwo + " is " + multyResult);
                                Console.WriteLine("Please enter y to continue calculating or n to exit");
                                string choiseMulti = Console.ReadLine();
                                if (choiseMulti == "n")
                                {
                                    calculate = false;
                                }
                                break;
                            case "/":
                                int devideResult = numOne / numTwo;
                                Console.Write("The devided value from " + numOne + operatiorInput + numTwo + " is " + devideResult);
                                Console.WriteLine("Please enter y to continue calculating or n to exit");
                                string choiseDev = Console.ReadLine();
                                if (choiseDev == "n")
                                {
                                    calculate = false;
                                }
                                break;
                            default:
                                Console.WriteLine("You entered invalid operator please enter y if you want to try again or n to exit");
                                string stopDefault = Console.ReadLine();
                                if (stopDefault == "n")
                                {
                                    calculate = false;
                                    Console.WriteLine("Exit!");
                                }
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("The inputs you entered as numbers were not numbers! Please enter only a number if you want to calculate");
                        Console.WriteLine("Please enter y to continue calculating or n to exit");
                        string secCheck = Console.ReadLine();
                        if (secCheck == "y")
                        {
                            continue;
                        }
                        else if (secCheck == "n")
                        {
                            Console.WriteLine("You have exit the calculator");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You need to insert eather y or n! No other character of value is accepted");
                            break;
                        }
                    }
                }
               
            } else if (start == "e")
            {
                Console.WriteLine( "You have exited the calculator");
            } else
            {
                Console.WriteLine("You etenred an invalid sign next time enter cal or e. Now app is closing");
            }
            Console.Read();

        }
    }
}
