using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_App
{
    public class Teacher : User
    {
        public Teacher(string userName,string fullName, int yearsOfExperience,Role role) : base(userName,fullName,Role.Teacher)
        {
            Experience = yearsOfExperience;
        }

        public Teacher()
        {

        }

        public int Experience { get; set; }
    }
}
