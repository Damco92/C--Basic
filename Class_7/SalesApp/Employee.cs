using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp
{
    public class Employee
    {
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = Role.Other;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"My name is {FirstName} {LastName} and i am a {Role}");
        }

        public virtual double GetSalary()
        {;
            return Salary;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected double Salary = 300;
        public Role Role { get; set; }

    }
}
