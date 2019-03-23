using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp
{
    public class Student : User
    {
        public string Username { get; set; }
        private string Password { get; set; }
        public Dictionary<string, int> SubjectsAndGrades = new Dictionary<string, int>();

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

        public Student(string username, Dictionary<string,int> subAndGra)
        {
            Username = username;
            SubjectsAndGrades = subAndGra;
        }
    }
}
