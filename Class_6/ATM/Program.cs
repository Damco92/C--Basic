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
            User castedUser = checkUser(users);
            Console.WriteLine("Please chose 1 if you want to Withdra money from your account or 2 to put money on your account!");
            string mainManuChoise = Console.ReadLine();
            if (mainManuChoise == "1")
            {
                if (castedUser == riste)
                {
                    riste.SetCardPin();
                    cashWithdraw(riste.GetBalance());
                }
                else if (castedUser == damjan)
                {
                    damjan.SetCardPin();
                    cashWithdraw(damjan.GetBalance());
                }
                else
                {
                    throw new Exception("No such user!");
                }
            } else if (mainManuChoise == "2")
            {
                if (castedUser == riste)
                {
                    riste.SetCardPin();
                    cashInput(riste.GetBalance());
                }
                else if (castedUser == damjan)
                {
                    damjan.SetCardPin();
                    cashInput(damjan.GetBalance());
                }
                else
                {
                    throw new Exception("No such user!");
                }
            } else
            {
                throw new Exception("You must choose eather 1 or 2!");
            }

            Console.Read();
        }


        static int cashInput(int balance)
       {
            int currentBalance = balance;
            while (true)
            {
                Console.WriteLine("Please enter amount you want to input!");
                string inputMoneyString = Console.ReadLine();
                int inputMoney;
                bool castwhwithdrawAmount = Int32.TryParse(inputMoneyString, out inputMoney);
                if (castwhwithdrawAmount)
                {
                    currentBalance +=  inputMoney;
                    Console.WriteLine($"Now you got {currentBalance} on your account! Would you like to add more? (y/n)");
                    string choiseInput = Console.ReadLine();
                    if (choiseInput == "y")
                    {
                        continue;
                    } else if (choiseInput =="n")
                    {
                        Console.WriteLine("Thank you for your trust have a great day!");
                        break;
                    } else
                    {
                        throw new Exception("Wrong input you must enter eather y or n!");
                    }
                }
                else
                {
                    throw new Exception("Sorry wrong input!");
                }
            }
            return currentBalance;
         }


        static User checkUser(List<User> users)
        {
            Console.WriteLine("Please enter card number!");
            string checkCardNum = Console.ReadLine();
            foreach (User user in users)
            {
                if (checkCardNum == user.CardNumber)
                {
                    Console.WriteLine($"Hello {user.FullName}");
                    return user;
                }
            }
            Console.WriteLine("User not found");
            return null;
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
                            Console.WriteLine($"Now you have {currentBalance} EUR to your account!");
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
