using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }

        public Manager(string firstName, string lastName) : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = Role.Manager;
            Salary =  600;
        }

        public double addBonus(int bonus)
        {
           Bonus = bonus;
            Salary += bonus;
            return Salary;
        }

        public override double GetSalary()
        {
            Console.WriteLine($"Your salary is {Salary}");
            return Salary;
        }
    }
}
