using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_App
{
    public class Admin : User
    {
        public Admin()
        {

        }
        public Admin(string userName, string startAsAdmin, string fullName) : base(userName, fullName, Role.Admin)
        {
            EmploymentDate = startAsAdmin;
        }

        public string EmploymentDate { get; set; }

        public List<Admin> AddAdmin(List<Admin> admins)
        {
            Console.WriteLine("Please enter new admins username");
            string newAdminsUsername = Console.ReadLine();
            Console.WriteLine("Please enter in what year did admin became admin of the academy");
            string newAdminStartYear = Console.ReadLine();
            Console.WriteLine("Please enter new admins full name!");
            string newAdminFullName = Console.ReadLine();
            admins.Add(new Admin(newAdminsUsername, newAdminStartYear, newAdminFullName));
            Console.WriteLine("The admins on this academy are:");
            foreach (var admin in admins)
            {
                Console.WriteLine(admin.FullName);
            }
            return admins;
        }

        public List<Admin> RemoveAdmin(List<Admin> admins, Admin me)
        {
            Console.WriteLine("Please enter the username of the admin you want to remove");
            string username = Console.ReadLine();
            bool found = false;
            foreach (var admin in admins.ToList())
            {
                if(username == admin.UserName && username != me.UserName)
                {
                    found = true;
                    admins.Remove(admin);
                    Console.WriteLine($"Admin {admin.FullName} was successfully deleted!");
                }
            }
            if(found == false)
            {
                throw new Exception("Admin with that username does not exists or you are trying to erase yourself!");
            }
            return admins;
        }
        
    }
}
