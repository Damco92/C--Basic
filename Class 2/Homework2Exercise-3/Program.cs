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
            Console.WriteLine("Please enter a number from 1 to 3");
            string firstNum;
            firstNum = Console.ReadLine();
            int num;
            bool castNum = Int32.TryParse(firstNum, out num);
            if (castNum == true)
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Number entered one");
                        break;
                    case 2:
                        Console.WriteLine("Number entered two");
                        break;
                    case 3:
                        Console.WriteLine("Number entered three");
                        break;
                    default:
                        Console.WriteLine("Number entered is smaller then one or bigger then three");
                        break;
                 } 
            } else
            {
                Console.WriteLine("Input enterd is not a number");
            }
            Console.Read();
            
        }
    }
}
