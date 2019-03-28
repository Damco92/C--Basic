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

        public void RemoveAdmin(List<Admin> adminss)
        {
            foreach (var admin in adminss)
            {
                if (admin == !LogIn(admins))
                {
                    Console.WriteLine($"Please press 1 to remove the admin {admin.FullName}!");
                    int adminErase =Convert.ToInt32(Console.ReadLine());
                    if (adminErase == 1)
                    {
                        adminss.Remove(admin);
                    }
                    else
                    {
                        continue;
                    }

                }
                else if (admin == LogIn(admins))
                {
                    Console.WriteLine("SOrry you can not erase yourself!");
                    throw new Exception("Can not remove your self!");
                }
            }
        }

        public Admin AddAdmin(List<Admin admins>)
        {

        }
    }
}
