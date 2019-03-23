using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp
{
    public class Admin : User
    {
        public string Username { get; set; }
        private string Password { get; set; }

        public string GetPassword()
        {
            return Password;
        }

        public string SetPassword(string myPassword)
        {
            if (myPassword.Length < 8)
            {
                throw new Exception("Password is too week!");
            }
            else
            {
                Password = myPassword;
                return Password;
            }
        }

        public Admin(string username)
        {
            Username = username;
        }

        public void addOrRemoveAdmin(List<Admin> admins)
        {
            Console.WriteLine("Please enter an admin name you want to remove");
            string chooseAdming = Console.ReadLine();
        }
    }
}
