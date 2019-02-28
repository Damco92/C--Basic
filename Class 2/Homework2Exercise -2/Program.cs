using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            //double decimalOne;
            //decimalOne = 2.45;
            //double decimalTwo;
            //decimalTwo = 5.66;
            //double result;
            //result = decimalTwo / decimalOne;
            //Console.WriteLine("The result from " + decimalTwo + " devided with " + decimalOne + " equals to " + result +".");
            //Console.Read();
            //int numberOne;
            //int numberTwo;
            //numberOne = 4;
            //numberTwo = 2;
            //int result;
            //result = numberOne / numberTwo;
            //Console.WriteLine("The result of the two numbers devided is " + result + ".");
            //Console.Read();
            Console.WriteLine("Plesae enter the first number");
            string firstStrNum = Console.ReadLine();
            Console.WriteLine("Please enter the second number");
            string secStrNum = Console.ReadLine();
            int firstNum;
            int secNum;
            bool castNumOne = Int32.TryParse(firstStrNum, out firstNum);
            bool castNumTwo = Int32.TryParse(secStrNum, out secNum);
            if (castNumOne == true && castNumTwo == true)
            {
                if (firstNum > secNum)
                {
                    Console.WriteLine("First Num is bigger");
                }
                else
                {
                    Console.WriteLine("Second num is bigger");
                }
                if (firstNum%2 == 0)
                {
                    Console.WriteLine("First num is even");
                } else
                {
                    Console.WriteLine("First num is odd");
                }
                if (secNum % 2 == 0)
                {
                    Console.WriteLine("Second num is even");
                } else
                {
                    Console.WriteLine("Second num is odd");
                }
            } else
            {
                Console.WriteLine("Some of the numbers is not convertible");
            }
            Console.Read();
        }
    }
}
