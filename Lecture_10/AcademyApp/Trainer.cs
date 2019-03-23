using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp
{
    public class Trainer : User
    {
        public string FullName { get; set; }

        public Trainer(string fullName, string userName,Role role) : base( userName, Role.Trainer)
        {
            FullName = fullName;
        }
    }
}
