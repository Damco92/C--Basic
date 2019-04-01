using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy_App;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            User orce = new Admin("orce","2013","Orce Petrovski");
            User dejan = new Admin("deki","2014","Dejan Zdravkosvki");
            User risto = new Teacher("riste","Risto Panchevski",2,Role.Teacher);
            User martin = new Teacher("macko","Martin Panovski",1,Role.Teacher);
            Student damjan = new Student("damco", "Damjan Stojanovski", Role.Student,new Dictionary<string, int> { {"C#",4 },{"JavaScript",4 },{ "CSS",3} });
            Student igor = new Student("ige","Igor Mitevski",Role.Student, new Dictionary<string, int> { { "C#", 4 }, { "JavaScript", 4 }, { "CSS", 3 } });
            Student samir = new Student("samir","Sameer Ali",Role.Student, new Dictionary<string, int> { { "C#", 5 }, { "JavaScript", 5 }, { "CSS", 4 } });
            Student danaya = new Student("danny","Danaya Bay", Role.Student, new Dictionary<string, int> { { "C#", 3 }, { "JavaScript", 3 }, { "CSS", 3 } });
            Student stefanija = new Student("stefi","Stefanija Makarovska",Role.Student, new Dictionary<string, int> { { "C#", 3}, { "JavaScript", 4 }, { "CSS", 4 } });
            Student bojana = new Student("boka","Bojana Naumoska",Role.Student, new Dictionary<string, int> { { "C#", 4 }, { "JavaScript", 4 }, { "CSS", 4 } });
            Student david = new Student("david","David Ilievski", Role.Student, new Dictionary<string, int> { { "C#", 5 }, { "JavaScript", 5 }, { "CSS", 3 } });
            Student aleksandra = new Student("aleksa","Aleksandra Krstevksa",Role.Student, new Dictionary<string, int> { { "C#", 3 }, { "JavaScript", 4 }, { "CSS", 5 } });
            Student riste = new Student("riki","Riste Spasov", Role.Student, new Dictionary<string, int> { { "C#", 3 }, { "JavaScript", 4 }, { "CSS", 5 } });
            Student borislav = new Student("boki", "Borislav Manevski",Role.Student, new Dictionary<string, int> { { "C#", 3 }, { "JavaScript", 4 }, { "CSS", 4 } });
            List<User> users = new List<User> { orce,dejan,risto,martin,damjan,igor,samir,danaya,stefanija,bojana,david,aleksandra,riste,borislav};

            orce.SetPass("orce1233");
            dejan.SetPass("dejan1234");
            risto.SetPass("risto1234");
            martin.SetPass("martin1234");
            damjan.SetPass("damjan1234");
            igor.SetPass("igor1234");
            samir.SetPass("samir1234");
            danaya.SetPass("danaya1234");
            stefanija.SetPass("stefi1234");
            bojana.SetPass("bojana1234");
            david.SetPass("david1234");
            aleksandra.SetPass("aleksa1234");
            riste.SetPass("riki1234");
            borislav.SetPass("boki1234");

            List<User> admins = users.Where(x => x.Role == Role.Admin).ToList();
            List<Admin> myAdmins = admins.ConvertAll(x => new Admin {UserName = x.UserName,FullName = x.FullName, Role = Role.Admin }).ToList();
            List<User> teachers = users.Where(x => x.Role == Role.Teacher).ToList();
            List<Teacher> myTeachers = teachers.ConvertAll(x => new Teacher { UserName = x.UserName, FullName = x.FullName, Role = Role.Admin }).ToList();
            List<User> students = users.Where(x => x.Role == Role.Student).ToList();
            List<Student> myStudents = new List<Student> { damjan, igor, samir, danaya, borislav, riste, bojana, stefanija, david, aleksandra };
            User loggedUser = LogIn(users);
            if(loggedUser.Role == Role.Admin)
            {
                Admin newAdmin = (Admin)loggedUser;
                Console.WriteLine($"Hello {newAdmin.FullName}.");
                Console.WriteLine("Please enter 1 to add new user or 2 to remove user!");
                string adminInput = Console.ReadLine();
                if (adminInput == "1")
                {
                    newAdmin.AddAdmin(myAdmins);
                }
                else if (adminInput == "2")
                {
                    newAdmin.RemoveAdmin(myAdmins,newAdmin);
                }

            }
            else if(loggedUser.Role == Role.Teacher)
            {
                Teacher newTeacher = (Teacher)loggedUser;
                Console.WriteLine("Please chose 1 to show all student names!");
                Console.WriteLine("Pleae chose 2 to choose by student and to see his/hers subjects and grades!");
                string choise = Console.ReadLine();
                if(choise == "1")
                {
                    newTeacher.ShowStudents(myStudents);
                }
                else if (choise == "2")
                {
                    newTeacher.showSubsAndGrades(myStudents);
                }
            }
            else if(loggedUser.Role == Role.Student)
            {
                Student newStudent = (Student)loggedUser;
                Console.WriteLine("Please choose 1 to enroll a new subject!");
                string userInput = Console.ReadLine();
                if(userInput == "1")
                {
                    newStudent.Enroll(myStudents);
                }
            } 


            Console.ReadLine();
        }

        static User LogIn(List<User> myUsers)
        {
            User newUser = new User();
            Console.WriteLine("Pleae enter your username!");
            string userName = Console.ReadLine();
            Console.WriteLine("Please enter password!");
            string passInput = Console.ReadLine();
            bool found = false;
            foreach (var user in myUsers)
            {
                if (userName == user.UserName && passInput == user.GetPass())
                {
                    found = true;
                    newUser = user;
                    Console.WriteLine($"The user {user.UserName} is {user.FullName} exists in our data base and he/she is {user.Role}");
                    return newUser;
                }
            }
            if(found == false)
            {
                Console.WriteLine("User does not exists!Do you want to try again?(y/n)");
                string choise = Console.ReadLine();
                while (choise == "y")
                {
                    Console.WriteLine("Pleaes enter your username");
                    string inputName2 = Console.ReadLine();
                    Console.WriteLine("Please enter password!");
                    string inputPass = Console.ReadLine();
                    foreach (var user in myUsers)
                    {
                        if (inputName2 == user.UserName && inputPass == user.GetPass())
                        {
                            found = true;
                            Console.WriteLine($"The user {user.UserName} is {user.FullName} exists in our data base and he/she is {user.Role}");
                            newUser = user;
                            break;
                        }
                    }
                    if (found == false)
                    {
                        Console.WriteLine("Plesae enter y or anything else(y/n)");
                        string secChoise = Console.ReadLine();
                        if (secChoise == "y")
                            continue;
                        else if (secChoise == "n") break;
                        else throw new Exception("You must enter eather y or n!");
                    }
                    break;
                }
            }
            return newUser;
        }
    }
}
