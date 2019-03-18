using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            User[] Users = new User[3];

            User user1 = new User()
            {
                Id = 123,
                Username = "dam-dam"
            };
            user1.Messages[0] = $"Hello Damjan nice to meet you";
            user1.SetPassword("mypass123");

            User user2 = new User()
            {
                Id = 345,
                Username = "kimura"
            };
            user2.Messages[0] = "Hello Masahiko  wellcome";
            user2.SetPassword("Masahikokimura1");

            User user3 = new User()
            {
                Id = 567,
                Username = "Bujinkan"
            };
            user3.Messages[0] = "Hello Bujinkan wellcome";
            user3.SetPassword("MasakiHatsumi");

            Users[0] = user1;
            Users[1] = user2;
            Users[2] = user3;
            Console.WriteLine("Please enter your username");
            string name = Console.ReadLine();
            //checkUsers(name, Users);

            Console.Read();
        }

        //static void checkUsers(string name, User[] Users)
        //{
        //    int found = 0;
        //    foreach (User item in Users) 
        //    {
        //        if (item.Username == name )
        //        {
        //            found = 1;
        //            for (int i = 0; i < item.Messages.Length; i++)
        //            {
        //                Console.WriteLine($"The message for the user with username {item.Username} is {item.Messages[i]}");
        //            }
        //        }

        //        if (found == 0)
        //        {
        //            Console.WriteLine("User is not found");
        //            Console.WriteLine("Do you want to register? y/n");
        //            //string choise = Console.ReadLine();
        //            //if (choise == "y")
        //            //{
        //                //Register (User[] Users);
        //            //}
        //        }
        //    }
        //}


    }
}
