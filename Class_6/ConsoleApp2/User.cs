using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        private string Password { get; set; }
        public string[] Messages;

        public string SetPassword(string myPass)
        {
            if (!string.IsNullOrWhiteSpace(myPass))
            {
                Password = myPass;
                return Password;
            }
            else throw new Exception("Password must not be an empty field or null");
        }

        public User()
        {

        }
        
    }
}
