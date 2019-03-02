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
                        Console.Write("The summed value from " + numOne + operatiorInput + numTwo + " is" + sumResult);
                        break;
                    case "-":
                        int subResult = numOne - numTwo;
                        Console.Write("The substracted value from " + numOne + operatiorInput + numTwo + " is" + subResult);
                        break;
                    case "*":
                        int multyResult = numOne * numTwo;
                        Console.Write("The multiplied value from " + numOne + operatiorInput + numTwo + " is" + multyResult);
                        break;
                    case "/":
                        int devideResult = numOne / numTwo;
                        Console.Write("The devided value from " + numOne + operatiorInput + numTwo + " is" + devideResult);
                        break;
                }
            }
            Console.Read();

        }
    }
}
