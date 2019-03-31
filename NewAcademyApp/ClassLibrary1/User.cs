using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_App
{
    public class User
    {
        public User(string nick, string fullName, Role userRole)
        {
            UserName = nick;
            FullName = fullName;
            Role = userRole;
        }

        public User()
        {

        }

        public string UserName { get; set; }
        public string FullName { get; set; }
        public Role Role { get; set; }
        private string Password;

       

        public string GetPass()
        {
            return Password;
        }

        public string SetPass(string pass)
        {
            if (pass.Length > 6)
            {
                Password = pass;
                return Password;
            } 
            else
            {
                throw new Exception("Pass too weak!");
            }
        }
    }
}
