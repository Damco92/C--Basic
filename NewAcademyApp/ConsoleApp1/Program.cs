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
            User orce = new Admin("orce","2013","Orce Petrovski",Role.Admin);
            User dejan = new Admin("deki","2014","Dejan Zdravkosvki", Role.Admin);
            User risto = new Teacher("riste","Risto Panchevski",2,Role.Teacher);
            User martin = new Teacher("macko","Martin Panovski",1,Role.Teacher);
            User damjan = new Student("damco", "Damjan Stojanovski", Role.Student,1);
            User igor = new Student("ige","Igor Mitevski",Role.Student,1);
            User samir = new Student("samir","Sameer Ali",Role.Student,1);
            User danaya = new Student("danny","Danaya Bay", Role.Student,1);
            User stefanija = new Student("stefi","Stefanija Makarovska",Role.Student,1);
            User bojana = new Student("boka","Bojana Naumoska",Role.Student,1);
            User david = new Student("david","David Ilievski", Role.Student,1);
            User aleksandra = new Student("aleksa","Aleksandra Krstevksa",Role.Student,1);
            User riste = new Student("riki","Riste Spasov", Role.Student,1);
            User borislav = new Student("boki", "Borislav Manevski",Role.Student,1);
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

            LogIn(users);

            List<User> admins = users.Where(x => x.Role == Role.Admin).ToList();
            List<User> teachers = users.Where(x => x.Role == Role.Teacher).ToList();
            List<User> students = users.Where(x => x.Role == Role.Student).ToList();

            User loggedUser = LogIn(users);
            if(loggedUser.Role == Role.Admin)
            {
                Console.WriteLine($"Hello {loggedUser.FullName}.");
                Console.WriteLine("Please enter 1 to add new user or 2 to remove user!");
                string adminInput = Console.ReadLine();

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
