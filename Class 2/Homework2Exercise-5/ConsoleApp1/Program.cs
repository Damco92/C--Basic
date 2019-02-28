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
            Console.WriteLine("Please enter the ammout in denars");
            string denarValue = Console.ReadLine();
            const int denToEur = 62;
            int denars;
            bool castDenToEur = Int32.TryParse(denarValue, out denars);
            if (castDenToEur == true)
            {
                int result = denToEur / denars;
                Console.WriteLine("You have converted " + denars + " denars to Euros by the following rate" + denToEur + "and your amount in Euros is " + result);
            }
            Console.WriteLine("Please enter the ammout in denars");
            string denarValueStr = Console.ReadLine();
            const int denToDollar = 56;
            int den;
            bool castDenToDol = int.TryParse(denarValue, out den);
            if (castDenToDol == true)
            {
                int resultDol = denToDollar / den;
                Console.WriteLine("You have converted " + den + " denars to Euros by the following rate" + denToDollar + "and your amount in Euros is " + resultDol);
            }
            Console.Read();
        }
        
    }
}
