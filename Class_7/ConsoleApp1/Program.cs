using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesApp;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee damjan = new Employee("Damjan", "Stojanovski");
            Employee riste = new Employee("Riste", "Spasov");
            SalesPerson dragan = new SalesPerson("Dragan", "Gelevski");
            SalesPerson martin = new SalesPerson("Martin", "Panovski");
            Manager dejan = new Manager("Dejan","Zdravkosvki");
            dejan.addBonus(500);
            dejan.GetSalary();





            Console.Read();

        }
    }
}
