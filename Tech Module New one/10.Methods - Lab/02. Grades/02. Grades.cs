using System;

namespace _02._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            Console.WriteLine(GradeInWord(grade));
        }

        static string GradeInWord(double grade)
        {
            if (grade <= 2.99 && grade >= 2)
            {
                return "Fail";
            }

            else if (grade <= 3.49)
            {
                return "Poor";
            }

            else if (grade <= 4.49)
            {
                return "Good";
            }

            else if (grade <= 5.49)
            {
                return "Very good";
            }

            else if (grade <= 6)
            {
                return "Excellent";
            }

            else
            {
                return "Invalid grade";
            }
        }
    }
}
