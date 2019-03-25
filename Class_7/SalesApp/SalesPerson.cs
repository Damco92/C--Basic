using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp
{
    public class SalesPerson : Employee
    {
        private double SuccessRateRevenue { get; set; }

        public SalesPerson(string firstName, string lastName) : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = Role.Sales;
            Salary = 500;
        }

        public double AddSuccessRevenue(double success)
        {
            SuccessRateRevenue += success;
            return SuccessRateRevenue;
        }

        public override double GetSalary()
        {
            double bonus;
            if (SuccessRateRevenue <= 2000)
            {
                bonus = 500;
                Console.WriteLine($"Your salary is {Salary} and your bonus is {bonus} so total salary is {Salary + bonus}");
                return Salary + bonus;
            }
            else if (SuccessRateRevenue > 2000 && SuccessRateRevenue < 5000)
            {
                bonus = 1000;
                Console.WriteLine($"Your salary is {Salary} and your bonus is {bonus} so total salary is {Salary + bonus}");
                return Salary + bonus;
            }
            else if (SuccessRateRevenue > 5000)
            {
                bonus = 1500;
                Console.WriteLine($"Your salary is {Salary} and your bonus is {bonus} so total salary is {Salary + bonus}");
                return Salary + bonus;
            }
            else
            {
                return Salary;
            }
        }
    }
}
