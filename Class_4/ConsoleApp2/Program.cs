using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            SumEven();
            Console.Read();
        }

        private static void SumEven()
        {
            int[] myArray = new int[6];
            int sumEvens = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Please enter a number");
                string input = Console.ReadLine();
                bool castInput = int.TryParse(input, out myArray[i]);
                if (castInput == true)
                {
                    if (myArray[i] % 2 == 0)
                    {
                        sumEvens += myArray[i];
                    } 
                } else
                {
                    Console.WriteLine("Sorry the input is not a number! You must etner only numbers! Exit!");
                    break;
                }
            }
            Console.WriteLine($"The sum of the even numbers in the  array is {sumEvens}");
        }
    }
}
