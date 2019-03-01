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
            const double denToEur = 61.5;
            const double denToDollars = 54.5;
            const double denToGBP = 73.6;
            const double denToAud = 39.3;
            double euros;
            double dollars;
            double GBP;
            double AUD;
            Console.WriteLine("Please enter EUR for Euros, USD for US Dollars, GBP for Britain Pound and AUD for Australian Dollar!");
            string chooseCur = Console.ReadLine();
            if (chooseCur == "EUR")
            {
                bool castEur = Double.TryParse(denarValue, out euros);
                if (castEur == true)
                {
                    double resultEur = euros / denToEur;
                    Console.WriteLine("For the " + euros + "denars exchanged to Euros at the rate of" + denToEur + " you will get total " + resultEur);
                }
                else
                {
                    Console.WriteLine("There was an error in the input");
                }
            }
            else if (chooseCur == "USD")
            {
                bool castUSD = Double.TryParse(denarValue, out dollars);
                if (castUSD == true)
                {
                    double resultUSD = dollars / denToDollars;
                    Console.WriteLine("For the " + dollars + "denars exchanged to American Dollars at the rate of" + denToDollars + " you will get total " + resultUSD);
                }
                else
                {
                    Console.WriteLine("There was an error in the input");
                }
            }
            else if (chooseCur == "GBP")
            {
                bool castGBP = Double.TryParse(denarValue, out GBP);
                if (castGBP == true)
                {
                    double resultGDP = GBP / denToGBP;
                    Console.WriteLine("For the " + GBP + "denars exchanged to Pounds at the rate of" + denToGBP + " you will get total " + resultGDP);
                }
                else
                {
                    Console.WriteLine("There was an error in the input");
                }
            }
            else if (chooseCur == "AUD")
            {
                bool castAUD = Double.TryParse(denarValue, out AUD);
                if (castAUD == true)
                {
                    double resultAUD = AUD / denToAud;
                    Console.WriteLine("For the " + AUD + "denars exchanged to Australian dollars at the rate of" + denToAud + " you will get total " + resultAUD);
                }
                else
                {
                    Console.WriteLine("There was an error in the input");
                }
            }
            else
            {
                Console.WriteLine("There is no such currency");
            }
            Console.Read();
        }
    }
}
