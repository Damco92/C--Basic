using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_App
{
    public class Student : User
    {
        public Student(string userName,string fullName,Role role,int year) : base(userName,fullName,Role.Student)
        {
            YearOfStudies = year;
        }
        public Student()
        {

        }
        public int YearOfStudies { get; set; }

    }
}
