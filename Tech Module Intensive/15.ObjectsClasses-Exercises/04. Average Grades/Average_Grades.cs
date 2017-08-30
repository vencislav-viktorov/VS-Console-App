using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Average_Grades
{
    class Student
    {
        public string Name { get; set; }

        public List<double> Grades { get; set; }

        public double AverageGrade
        {
            get
            { return (double)Grades.Sum() / Grades.Count; }
        }
    }

    public class Average_Grades
    {
        public static void Main()
        {
            Student[] studentGrades = GetStudentGrades();

            string[] topStudents = studentGrades
                                    .Where(x => x.AverageGrade >= 5)
                                    .Select(x => x.Name).Distinct()
                                    .OrderBy(x => x)
                                    .ToArray();

            foreach (string student in topStudents)
            {
                double[] studentAverageGrades = studentGrades
                                                .Where(x => x.Name == student && x.AverageGrade >= 5)
                                                .Select(x => x.AverageGrade)
                                                .OrderByDescending(x => x)
                                                .ToArray();

                foreach (double studentAverageGrade in studentAverageGrades)
                    Console.WriteLine("{0} -> {1:f2}", student, studentAverageGrade);
            }
        }

        private static Student[] GetStudentGrades()
        {
            int n = int.Parse(Console.ReadLine());

            Student[] grades = new Student[n];

            for (int i = 0; i < n; i++)
            {
                List<double> studentGrades = new List<double>();

                string[] data = Console.ReadLine()
                                .Split(new char[] { ' ' }, 
                                StringSplitOptions.RemoveEmptyEntries);

                for (int j = 1; j < data.Length; j++)
                    studentGrades.Add(double.Parse(data[j]));

                grades[i] = new Student() { Name = data[0], Grades = studentGrades };
            }

            return grades;
        }
    }
}
