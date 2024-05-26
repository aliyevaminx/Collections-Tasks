using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections_exceptions_task_3
{
    internal class Student
    {
        private Dictionary<string, List<int>> students;

        public Dictionary<string, List<int>> Students { get; }

        public Student()
        {
            Students = new Dictionary<string, List<int>>();
        }

        public void AddGrade(string name, int grade)
        {
            if (!Students.ContainsKey(name))
                Students[name] = new List<int> { grade };
            else if (Students.ContainsKey(name))
                Students[name].Add(grade);
        }

        public void RemoveGrade(string name, int grade)
        {
            if (Students.ContainsKey(name))
                Students[name].Remove(grade);
            else if (!Students.ContainsKey(name))
                Console.WriteLine("Student doesn't exist");
        }

        public void GetAverageGrade(string name)
        {
            int totalGrade = 0;

            if (Students.ContainsKey(name))
            {
                for (int i = 0; i < Students[name].Count; i++)
                {
                    totalGrade += Students[name][i];
                }
            }
            Console.WriteLine($"Total Grade: {totalGrade / Students[name].Count}");
        }

        public void GetAllGradesByStudent(string name)
        {
            if (Students.ContainsKey(name))
            {
                foreach (var grade in Students[name])
                {
                    Console.WriteLine($"Grade: {grade}");
                }
            } 
            else
                Console.WriteLine("Student not found");
        }
    }
}
