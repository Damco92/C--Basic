using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_App
{
    public class Teacher : User
    {
        public Teacher(string userName,string fullName, int yearsOfExperience,Role role) : base(userName,fullName,Role.Teacher)
        {
            Experience = yearsOfExperience;
        }

        public Teacher()
        {

        }

        public int Experience { get; set; }

        public void ShowStudents(List<Student> students)
        {
            Console.WriteLine("Students in this academy are:");
            foreach (var student in students)
            {
                Console.WriteLine(student.FullName);
            }
        }
        public void showSubsAndGrades(List<Student> students)
        {
            List<int> grades = new List<int>();
            List<string> subjects = new List<string>();
            Console.WriteLine("Pleae enter students name!");
            string inputStudentName = Console.ReadLine();
            bool foundStudent = false;
            foreach (var student in students)
            {
                if(inputStudentName == student.FullName)
                {
                    Console.WriteLine(student.FullName);
                    foundStudent = true;
                    foreach (var grade in student.SubjectsAndGrades)
                    {
                        grades.Add(grade.Value);
                    }
                    foreach (var sub in student.SubjectsAndGrades)
                    {
                        subjects.Add(sub.Key);
                    }
                }
            }
            if(foundStudent = false)
            {
                throw new Exception("Student does not exists!");
            }
            foreach (var sub in subjects)
            {
                Console.WriteLine(sub);
            }
            foreach (var grade in grades)
            {
                Console.WriteLine(grade);
            }
          
        }

    }
}
