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
            Console.WriteLine("Wellcome to the ATM!");
            User damjan = new User("Damjan Stojanovski", "2324-4532-1234");
            User riste = new User("Riste Spasov", "1213-5452-3213");
            damjan.SetBalance(10000);
           // riste.SetBalance(5000);
            damjan.SetCardPin();
           // riste.SetCardPin();
            cashWithdraw(damjan.GetBalance());
            Console.Read();
        }

        static void cashWithdraw(int balance)
        {
        while (true)
        { 
            Console.WriteLine("Please enter amount you want to whwithdraw!");
            int currentBalance;
            string whwithdrawAmountString = Console.ReadLine();
            int whwithdrawAmount;
            bool castwhwithdrawAmount = Int32.TryParse(whwithdrawAmountString, out whwithdrawAmount);
            if (castwhwithdrawAmount)
            {
                currentBalance = balance;
                if (whwithdrawAmount > currentBalance)
                {
                    throw new Exception("Sorry no sufficant funds on your card");
                }
                else if (whwithdrawAmount == balance)
                {
                    Console.WriteLine("Would you like to whwithdraw all the funds on your card? (y/n)");
                    string choise = Console.ReadLine();
                    if (choise == "y")
                    {
                        currentBalance = 0;
                        Console.WriteLine("Now you have 0 euros on your card!");
                            break;
                    }
                    else if (choise == "n")
                    {
                            continue;
                    }
                    else
                    {
                            Console.WriteLine("You must enter eather y or n");
                            break;
                    }
                }
                else
                {
                   currentBalance = balance - whwithdrawAmount;
                        Console.WriteLine($"Now you have {currentBalance} EUR to your account!");
                        Console.WriteLine("Do you want to make an other transaction? (y/n)");
                        string choise = Console.ReadLine();
                        if (choise == "y")
                        {
                            balance = currentBalance;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Thank you for your trust!");
                            break;
                        }
                }
            } 
            else
            {
                throw new Exception("Sorry wrong input!");
            }

         }
      }
    }
}
