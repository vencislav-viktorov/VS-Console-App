using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());

            List<Students> students = new List<Students>();

            for (int i = 0; i < studentsCount; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();

                string firstName = input[0];

                string lastName = input[1] + ":";

                double grade = double.Parse(input[2]);

                Students student = new Students(firstName, lastName, grade);

                students.Add(student);
            }

            students = students.OrderByDescending(x => x.Grade).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, students));
        }
    }
}
