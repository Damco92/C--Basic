using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp
{
    public class Student : User
    {
        public string FullName { get; set; }
        public Dictionary<string, int> SubjectsAndGrades = new Dictionary<string, int>();



        public Student(string fullName, string userName, Role role,Dictionary<string, int> subAndGra) : base(userName, Role.Student)
        {
            FullName = fullName;
            SubjectsAndGrades = subAndGra;
        }
    }
}
