using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class User
    {
        public string FullName { get; set; }
        public string CardNumber { get; set; }
        private int Pin { get; set; }
        private int Balance { get; set; }

       

        public int GetCardPin()
        {
            return Pin;
        }

        public int SetCardPin()
        {
            Console.WriteLine("Please enter your PIN!");
            string newPin = Console.ReadLine();
            int realPin;
            bool castPin = Int32.TryParse(newPin, out realPin);
            if (newPin.Length == 4 && castPin)
            {
                Pin = realPin;
            } 
            else
            {
                throw new Exception("Sorry wrong pin input the PIN must be 4 digits long!");
            }
            return Pin;
        }

        public int GetBalance()
        {
            return Balance;
        }

        public int SetBalance(int myBalance)
        {
            Balance = myBalance;
            return Balance;
        }
        public User(string name, string cardNum)
        {
            FullName = name;
            CardNumber = cardNum;
        }
    }
}
