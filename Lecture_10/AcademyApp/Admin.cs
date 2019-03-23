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

        
    }
}
