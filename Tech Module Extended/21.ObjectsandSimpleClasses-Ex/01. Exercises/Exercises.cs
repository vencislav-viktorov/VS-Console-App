using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Exercises
{
    public class Exercises
    {
        public string Topic { get; set; }

        public string CourseName { get; set; }

        public string JudgeContestLink { get; set; }

        public List<string> Problems { get; set; }
    }

    public class TaskOneExercises
    {
        public static void Main()
        {
            var exercises = new List<Exercises>();

            var inputData = Console.ReadLine();

            while (inputData != "go go go")
            {
                var temporaryData = inputData.Split(", ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

                string topic = temporaryData[0];

                string courseName = temporaryData[1];

                string judgeContestLink = temporaryData[2];

                List<string> problems = temporaryData.Skip(3).ToList();

                var tempExsercises = new Exercises();
                {
                    tempExsercises.Topic = topic;

                    tempExsercises.CourseName = courseName;

                    tempExsercises.JudgeContestLink = judgeContestLink;

                    tempExsercises.Problems = problems;
                }

                exercises.Add(tempExsercises);

                inputData = Console.ReadLine();
            }

            foreach (Exercises item in exercises)
            {
                Console.WriteLine($"Exercises: {item.Topic}");

                Console.WriteLine($"Problems for exercises and homework for the \"{item.CourseName}\" course @ SoftUni.");

                Console.WriteLine($"Check your solutions here: {item.JudgeContestLink}");

                var count = 1;

                foreach (var problem in item.Problems)
                {
                    Console.WriteLine($"{count}. {problem}");

                    count++;
                }
            }
        }
    }
}
