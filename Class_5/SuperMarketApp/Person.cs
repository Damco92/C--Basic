using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketApp
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public DateTime dateOfBirth = new DateTime();
        private string SSN;
        public bool loyalCard;
        public bool buyer;
        public bool cashier;

      

        public void Itroduction()
        {
            if (buyer)
            {
                Console.WriteLine($"Hello my name is {FirstName} {LastName} and I would like to purchase theese items!");
            }
            if (cashier)
            {
                Console.WriteLine($"Hello my name is {FirstName} {LastName} and I will help you with the puchase!");

            }

        }



        public Person()
        {

        }

    }
}
