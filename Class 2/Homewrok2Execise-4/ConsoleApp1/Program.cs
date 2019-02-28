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
            string operatiorSum = "+";
            string operatiorSubstract = "-";
            string operatorMulti = "*";
            string operatorDevide = "/";
            bool castNumOne = Int32.TryParse(firstNumStr, out numOne);
            bool castNumTwo = Int32.TryParse(secondNumStr, out numTwo);

            if(castNumOne == true && castNumTwo == true)
            {
                if (operatiorInput == operatiorSum)
                {
                    int resultSum = numOne + numTwo;
                    Console.WriteLine("The result  of the summed nums is " + resultSum + " .");
                } else if (operatiorInput == operatiorSubstract) 
                {
                    int resultSubstract = numOne - numTwo;
                    Console.WriteLine("The substracted value of the two nums is " + resultSubstract + ".");
                } else if (operatiorInput == operatorMulti)
                {
                    int resultMulti = numOne * numTwo;
                    Console.WriteLine("The multiplied result of the two values is " + resultMulti + ".");
                } else if (operatiorInput == operatorDevide)
                {
                    int resultDev = numOne / numTwo;
                    Console.WriteLine("The devided result is " + resultDev + ".");
                } else
                {
                    Console.WriteLine("There is not such operator");
                }
            } else
            {
                Console.WriteLine("The inserted input is not a number");
            }
            Console.Read();

        }
    }
}
