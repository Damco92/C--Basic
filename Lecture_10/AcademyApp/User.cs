using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp
{
    public class User
    {
        public string Username { get; set; }
        private string Password { get; set; }
        public Role role;

        public User(string userName,Role myRole)
        {
            Username = userName;
            role = myRole;
        }
        public User()
        {

        }

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
    }
}
