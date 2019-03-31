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
        public Admin(string userName, string startAsAdmin, string fullName, Role role) : base(userName, fullName, Role.Admin)
        {
            EmploymentDate = startAsAdmin;
        }

        public string EmploymentDate { get; set; }
        
    }
}
