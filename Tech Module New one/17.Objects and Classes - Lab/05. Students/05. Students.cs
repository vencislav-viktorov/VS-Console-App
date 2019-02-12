using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] tokens = line.Split();

                string firstName = tokens[0];

                string lastName = tokens[1];

                int age = int.Parse(tokens[2]);

                string city = tokens[3];

                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    City = city
                };

                students.Add(student);

                line = Console.ReadLine();
            }

            string filterCity = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.City == filterCity)
                {
                    Console.WriteLine
                        ($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }

            //List<Student> filteredStudents = students
            //    .Where(s => s.City == filterCity)
            //    .ToList();

            //foreach (Student student in filteredStudents)
            //{
            //    Console.WriteLine
            //        ($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            //}

        }
    }
}
