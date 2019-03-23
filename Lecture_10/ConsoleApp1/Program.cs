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
            Admin orce = new Admin("Orce");
            Admin dejan = new Admin("dejan");
            Trainer risto = new Trainer("risto");
            Trainer martin = new Trainer("martin");
            Student damjan = new Student("damco",new Dictionary<string, int>
                                                                               { { "C# advanced", 10 },
                                                                               { "JavaScript Basic", 7},
                                                                                                    });
            Student stefi = new Student("stefi", new Dictionary<string, int>
                                                                               { { "C# advanced", 8 },
                                                                               { "JavaScript Basic", 5},
                                                                                                    });
            orce.SetPassword("SeavusEducation");
            dejan.SetPassword("SeavusDevelopment");
            risto.SetPassword("CSharpProgrammer");
            martin.SetPassword("VaterpoloRules");
            damjan.SetPassword("damco123");
            stefi.SetPassword("basketball");

            List<Admin> admins = new List<Admin> { orce, dejan };
            List<Trainer> trainers = new List<Trainer> { risto, martin };
            List<Student> students = new List<Student> { damjan,  stefi };

            LogInAdmin(admins);
            Console.Read();
        }

        static void LogInAdmin(List<Admin> myAdmins)
        {
            Console.WriteLine("Pleae enter your role!");
            string choise = Console.ReadLine();
            if (choise == "admin")
            {
                Console.WriteLine("Wellcome Admin please enter your admin username");
                string adminChoise = Console.ReadLine();
                bool found = false;
                foreach (Admin admin in myAdmins)
                {
                    if (adminChoise == admin.Username)
                    {
                        Console.WriteLine(admin.Username + "you are logged in!");
                        found = true;
                    }
                }
                if (found == false)
                {
                    Console.WriteLine("User is not found!");
                }
            }
        }
    }
}
