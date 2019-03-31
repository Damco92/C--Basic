using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp
{
    public class Admin : User
    {
        public string FullName { get; set; }

        public Admin(string fullName, string userName, Role role) : base(userName, Role.Admin)
        {
            FullName = fullName;
        }
        public Admin()
        {

        }

        public void RemoveAdmin(List<User> admins,Admin me)
        {
            Console.WriteLine("Please write the name of the admin you want to remove");
            string adminName = Console.ReadLine();
            bool found = false;
            foreach (var admin in admins.ToList())
            {
                if (adminName == admin.Username && adminName != me.Username)
                {
                    found = true;
                    admins.Remove(admin);
                    Console.WriteLine($"The admin {admin.Username} has been removed!");
                }
            }
            if (found == false)
            {
                Console.WriteLine("Sorry there is not such user");
                throw new Exception("No such user");
            }
        }

        public void AddAdminUser(List<User> admins,User newAdmin)
        {
            Console.WriteLine("Please enter new username");
            string newUserUsername = Console.ReadLine();
            bool found = false;
            foreach (var user in admins.ToList())
            {
                if (newUserUsername != user.Username && newUserUsername != newAdmin.Username)
                {
                    admins.Add(new User(newAdmin.Username = newUserUsername, Role.Admin));
                    Console.WriteLine($"User {newUserUsername} added to Admins!");
                    found = true;
                }
            }
            if (found == false)
            {
                throw new Exception("User eather exists or not valid input");
            }
        }
    }
}
