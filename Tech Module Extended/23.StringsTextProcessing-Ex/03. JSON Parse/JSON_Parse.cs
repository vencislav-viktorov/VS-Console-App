using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.JSON_Parse
{
    public class Student
    {
        public string Name { get; set; }

        public string Age { get; set; }

        public List<string> Grades { get; set; }

        public static Student ParseTheStudents(List<string> currentList)
        {
            currentList = currentList.ToList();

            if (currentList.Count == 2)
            {
                currentList.Add("None");
            }

            return new Student
            {
                Name = currentList[0],

                Age = currentList[1],

                Grades = currentList.Skip(2).ToList()
            };
        }
    }

    public class JSON_Parse
    {
        public static void Main()
        {
            var studentsSoftUni = new List<Student>();

            var inputLine = Console.ReadLine();

            var stringBuilder = new StringBuilder();

            var outStudent = inputLine.Replace("},{", "|")

                .Replace("name:", string.Empty)

                .Replace("age:", string.Empty)

                .Replace("grades:", string.Empty)

                .Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (var item in outStudent)
            {
                var dataList = item.Split(new[] { '[', ']', '{', '}', ',', ':', '"' },
                    StringSplitOptions.RemoveEmptyEntries).ToList();

                var currentStudent = Student.ParseTheStudents(dataList);

                studentsSoftUni.Add(currentStudent);
            }

            foreach (var student in studentsSoftUni)
            {
                Console.WriteLine($"{student.Name} : {student.Age} -> {string.Join(",", student.Grades)}");
            }
        }
    }
}