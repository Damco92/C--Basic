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
            //while (true)
            // {
            //     int num;
            //     string input = Console.ReadLine();
            //     bool cast = Int32.TryParse(input, out num);
            //     if (cast == true)
            //     {
            //         Console.WriteLine("You entered a num");
            //         break;
            //     }
            // }
            //Console.WriteLine("Please enter a number");
            //string inputOne = Console.ReadLine();
            //int num;
            //bool cast = Int32.TryParse(inputOne, out num );
            //if (cast)
            //{
            //    for (int i = 1; i < num; i++)
            //    {
            //        Console.Write(i);
            //    }
            //}
            //Console.WriteLine("Pleas enter second number");
            //string inputTwo = Console.ReadLine();
            //int secNum;
            //bool castTwo = Int32.TryParse(inputTwo, out secNum);
            //if (castTwo)
            //{
            //    for (int k = secNum; k > 0; k--)
            //    {
            //        Console.Write(k);
            //    }

            //}
            //Console.WriteLine("Please enter a number ");
            //string stringNum = Console.ReadLine();
            //int numOne;
            //bool castOne = Int32.TryParse(stringNum, out numOne);
            //int evenSum = 0;
            //if (castOne)
            //{
            //    for (int i = 1; i <= numOne; i++)
            //    {
            //        if(i%2 == 0)
            //        {
            //            //Console.WriteLine(i);
            //            evenSum = evenSum + i;

            //        }

            //    }
            //    Console.WriteLine(evenSum);
            //}
            //Console.WriteLine("Please enter a number ");
            //string stringNumTwo = Console.ReadLine();
            //int numTwo;
            //bool castTwo = Int32.TryParse(stringNum, out numTwo);

            //if (castTwo)
            //{
            //    for (int i = 1; i <= numOne; i++)
            //    {
            //        if (i % 2 == 1)
            //        {
            //            Console.WriteLine(i);
            //        }

            //    }
            //    Console.WriteLine(evenSum);
            //}
            //Console.WriteLine("Please enter a num");
            //string numOne = Console.ReadLine();
            //int number;
            //bool cast = Int32.TryParse(numOne,out number);
            //if (cast)
            //{
            //   for (int i = 1; i <= number; i++)
            //    {
            //       if (i % 3 == 0 || i % 7 == 0)
            //        {
            //            continue;
            //        }

            //        if (i >= 100)
            //        {
            //            Console.WriteLine("Number too big stop");
            //            break;
            //        }

            //        Console.WriteLine(i);
            //    }
            //}

            //Console.Read();
            //int[] myArray = new int[5];
            //string[] stringArr = new string[5];
            //double[] decimalArr = new double[5];
            //char[] charArr = new char[5];
            //bool[] boolArr = new bool[5];
            //int[,] twoDim = new int[2, 2];
            //int[] numbers = new int[5];
            //  int total = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //   Console.WriteLine("Plesae enter number");
            //   string myNum = Console.ReadLine();
            //   int num;
            //   bool cast = Int32.TryParse(myNum, out num);
            //   numbers[i] = num;
            //      total += num;
            //      Console.WriteLine("Total sum of the given number is {0}", total);
            //}
            //foreach (int item in numbers)
            //{
            //   Console.WriteLine(item);
            //}
            string[] namesArr = new string[0];
            Console.WriteLine("Please enter yes if you want to start adding names to the array or no if you want to quit");
            string choise = Console.ReadLine();
            if (choise == "yes")
            {
                namesArr = new string[1];
                int i = 0;
                Console.WriteLine("Please enter the first name");
                string firstName = Console.ReadLine();
                namesArr[i] = firstName;
                Console.WriteLine("Please enter y if you want to continue or n if you want to stop");
                string goOn = Console.ReadLine();

                while (true)
                {
                    if (goOn == "y")
                    {
                        i++;
                        Console.WriteLine("Pleae enter next name");
                        string nextName = Console.ReadLine();
                        Array.Resize<string>(ref namesArr, i + 1);
                        namesArr[i] = nextName;
                        Console.WriteLine("Please enter y to con or n to break");
                        string secCheck = Console.ReadLine();
                        if (secCheck == "y")
                        {
                            continue;
                        } else if (secCheck == "n")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input you MUST ENTER Y OR N");
                            break;
                        }
                    } else if (goOn == "n")
                    {
                        break;
                    } 
                }
                foreach (string arrItem in namesArr)
                {
                    Console.WriteLine(arrItem);
                }

            }
            else if (choise == "no")
            {
                Console.WriteLine(namesArr);
            }
            Console.ReadLine();
        }
    }
}
