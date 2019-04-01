using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_App
{
    public class Student : User
    {
        public Student(string userName,string fullName,Role role,Dictionary<string,int> subAndGra) : base(userName,fullName,Role.Student)
        {
            SubjectsAndGrades = subAndGra;
        }
        public Student()
        {

        }
        public Dictionary<string,int> SubjectsAndGrades { get; set; }
        
        public void Enroll(List<Student> students)
        {
            List<string> subjects = new List<string>();
            Console.WriteLine("Please write the name of the student!"); Console.WriteLine("Please entr the name of the subject you want to enroll");
            string studentInput = Console.ReadLine();
            string chosenSub = Console.ReadLine();
            bool foundStudent = false;
            foreach (var student in students)
            {
                if(chosenSub == student.FullName)
                {
                    foundStudent = true;
                    foreach (var sub in student.SubjectsAndGrades)
                    {
                        if(chosenSub == sub.Key)
                        {
                            Console.WriteLine("You are already enrolled on that subject!");
                        }
                        else
                        {
                            Console.WriteLine("You just enrolled on the subject " + chosenSub);
                        }
                    }

                }
            }
            if(foundStudent = false)
            {
                Console.WriteLine("Student does not exists!");
                throw new Exception("");
            }
        }

    }
}
