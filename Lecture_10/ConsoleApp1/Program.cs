using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademyApp;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            User orce = new Admin("Orce Petrevski","orce", Role.Admin);
            User dejan = new Admin("Dejan Zdravskovski", "deki",Role.Admin);
            User risto = new Trainer("Risto Panchevski","riki",Role.Trainer);
            User martin = new Trainer("Martin Panovski","macko",Role.Trainer);
            User damjan = new Student("Damjan Stojanovski","damco",Role.Student,new Dictionary<string, int>
                                                                               { { "C# advanced", 10 },
                                                                               { "JavaScript Basic", 7},
                                                                                                    });
            User stefi = new Student("Stefania Makarovska","stefi",Role.Student, new Dictionary<string, int>
                                                                               { { "C# advanced", 8 },
                                                                               { "JavaScript Basic", 5},
                                                                                                    });
            orce.SetPassword("SeavusEducation");
            dejan.SetPassword("SeavusDevelopment");
            risto.SetPassword("CSharpProgrammer");
            martin.SetPassword("VaterpoloRules");
            damjan.SetPassword("damco123");
            stefi.SetPassword("basketball");

            

            List<User> users = new List<User> { orce, dejan, risto, martin, damjan, stefi };

            List<User> admins = users.Where(user => user.role == Role.Admin).ToList();
            List<User> trainers = users.Where(user => user.role == Role.Trainer).ToList();
            List<User> students = users.Where(user => user.role == Role.Student).ToList();
            User loggedUser = LogIn(users);

           if (loggedUser.role == Role.Admin)
            {
                Admin adminCated = (Admin)loggedUser;
                Console.WriteLine("Please enter 1 if you want to remove admin or 2 if you want to insert a new admin!");
                int choiseAdmin = Convert.ToInt32(Console.ReadLine());
                if (choiseAdmin == 1)
                {
                    adminCated.RemoveAdmin(admins, adminCated);
                }
                else if(choiseAdmin == 2)
                {
                    adminCated.AddAdminUser(admins, adminCated);
                    foreach (var admin in admins)
                    {
                        Console.WriteLine(admin.Username);
                    }
                }
            }
           else if (loggedUser.role == Role.Trainer)
            {
                Trainer trainerCasted = (Trainer)loggedUser;
                
            }
           else if (loggedUser.role == Role.Student)
            {
                Student studentCasted = (Student)loggedUser;
            }
           else
            {
                throw new Exception("The user is nieter of the given rolls!");
            }



            Console.Read();
        }




        static User LogIn(List<User> users)
        {
            Console.WriteLine("Plese enter your username");
            string usernameInput = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            string passInput = Console.ReadLine();
            User loggedinUser = new User();
            bool found = false;
            foreach (User user in users)
            {
                if (usernameInput == user.Username && passInput == user.GetPassword())
                {
                    found = true;
                    Console.WriteLine($"User: {user.Username} is a {user.role} and is in our database!");
                    loggedinUser = user;
                }
            }
            if (found == false)
            {
                Console.WriteLine("User does not exists!");
                throw new Exception("Wrong Username!");
            }
            return loggedinUser;
        }
    }
}
