using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.AverageGrade
{
    class AverageGrade
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> AllStudent = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine()
                    .Split(' ')
                    .ToList();
                Student student = new Student();
                student.Name = input[0];
                input.RemoveAt(0);
                student.Grades = input.Select(double.Parse).ToList();
                AllStudent.Add(student);
            }
            foreach (var person in AllStudent.Where(x => x.AverageGrades >= 5.00).OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrades))
            {
                Console.WriteLine($"{person.Name} -> {person.AverageGrades:f2}");
            }
        }
    }
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }    
        public double AverageGrades { get { return Grades.Average(); } }
    }
}
