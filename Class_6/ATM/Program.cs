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
            User damjan = new User("Damjan Stojanovski", "1234-1234-1234");
            User riste = new User("Riste Spasov", "9876-9876-9876");

            List<User> users = new List<User> { damjan, riste };

            damjan.SetBalance(10000);
            riste.SetBalance(5000);

            if (checkUser(users) == damjan)
            {
                damjan.SetCardPin();
                cashWithdraw(damjan.GetBalance());
            } else if (checkUser(users) == riste)
            {
                riste.SetCardPin();
                cashWithdraw(riste.GetBalance());
            }

            Console.Read();
        }

        static User checkUser(List<User> users)
        {
            Console.WriteLine("Please enter card number!");
            string checkCardNum = Console.ReadLine();
            int userFound = 0;
            foreach (User user in users)
            {
                if (checkCardNum == user.CardNumber)
                {
                    userFound = 1;
                    Console.WriteLine($"Hello {user.FullName}");
                    return user;
                }
            }
            if (userFound == 0)
            {
                Console.WriteLine("User is not found");
                return null;
            }

        }

        static void checkBalance()
        {
            
        }

        static int cashWithdraw(int balance)
        {
            int currentBalance;
            while (true)
            {
                Console.WriteLine("Please enter amount you want to whwithdraw!");
                string whwithdrawAmountString = Console.ReadLine();
                int whwithdrawAmount;
                bool castwhwithdrawAmount = Int32.TryParse(whwithdrawAmountString, out whwithdrawAmount);
                if (castwhwithdrawAmount)
                {
                    currentBalance = balance;
                    if (whwithdrawAmount > balance)
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
                            throw new Exception("Wrong input! You must enter eather y or n!");
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
                        else if (choise == "n")
                        {
                            Console.WriteLine("Thank you for your trust!");
                            break;
                        }
                        else
                        {
                            throw new Exception("Sorry only y or n allowed!");
                        }
                    }
                }
                else
                {
                    throw new Exception("Sorry wrong input!");
                }
            }
            return currentBalance;
        }
    }
}
