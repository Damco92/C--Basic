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
            Dictionary<string, string> phoneBook = new Dictionary<string, string>()
            {
                {"Damjan", "075-123-432" },
                {"Riste", "072-123-432" },
                {"Ivan", "070-232-131" },
                {"Borjan", "071-123-123" },
                {"Martin", "070-123-123" }
            };

            Console.WriteLine("Please enter your name");
            string inputName = Console.ReadLine();
            string phoneNumber;
            bool foundName = phoneBook.TryGetValue(inputName, out phoneNumber);
            if (foundName)
            {
                Console.WriteLine($"{inputName}'s phone number is {phoneNumber}");
            }
            Console.Read();

        }
    }
}
