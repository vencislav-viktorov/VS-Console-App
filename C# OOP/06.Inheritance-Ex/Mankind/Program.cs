namespace Mankind
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var studentArgs = Console.ReadLine()
                    .Split();
                var studentFirstName = studentArgs[0];
                var studentLastName = studentArgs[1];
                var facultyNumber = studentArgs[2];
                var student = new Student(
                    studentFirstName,
                    studentLastName,
                    facultyNumber);

                var workerArgs = Console.ReadLine()
                    .Split();
                var workerFirstName = workerArgs[0];
                var workerLastName = workerArgs[1];
                var weekSalary = double.Parse(workerArgs[2]);
                var workedHoursPerDay = double.Parse(workerArgs[3]);
                var worker = new Worker(
                    workerFirstName,
                    workerLastName,
                    weekSalary,
                    workedHoursPerDay);

                Console.WriteLine(student);
                Console.WriteLine();
                Console.WriteLine(worker);
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}