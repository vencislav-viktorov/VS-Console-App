using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.JSON_Stringify
{
    public class Student
    {
        public string Name { get; set; }

        public string Age { get; set; }

        public List<string> Grades { get; set; }
    }

    public class JSON_Stringify
    {
        public static void Main()
        {
            var studentsSoftUni = new List<Student>();

            var inputLine = Console.ReadLine().Split(new[] { ' ', ':', ',', '-', '>' }, 
                StringSplitOptions.RemoveEmptyEntries).ToList();

            while (inputLine[0] != "stringify")
            {
                var name = inputLine[0];

                var age = inputLine[1];

                var grades = inputLine.Skip(2);

                //Console.WriteLine(string.Join(" ", grades));

                var currentStudent = new Student();
                {
                    currentStudent.Name = name;

                    currentStudent.Age = age;

                    currentStudent.Grades = grades.ToList();
                };

                studentsSoftUni.Add(currentStudent);

                inputLine = Console.ReadLine().Split(new[] { ' ', ':', ',', '-', '>' }, 
                    StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            var stringBuilder = new StringBuilder();

            foreach (var student in studentsSoftUni)
            {
                stringBuilder = stringBuilder
                    .Append($"{{name:\"{student.Name}\",age:{student.Age},grades:[{string.Join(", ", student.Grades)}]}},");
            }

            var printStringBuilder = "[" + stringBuilder.ToString().Trim(',') + "]";

            Console.Write(printStringBuilder);
        }
    }
}