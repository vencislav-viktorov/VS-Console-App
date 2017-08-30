using System;

namespace _08.Employee_Data
{
    public class Employee_Data
    {
        public static void Main()
        {
            string firstName = Console.ReadLine();

            string lastName = Console.ReadLine();

            int age = int.Parse(Console.ReadLine())
                ;
            string gender = Console.ReadLine();

            ulong id = ulong.Parse(Console.ReadLine());

            uint employeeNumber = uint.Parse(Console.ReadLine());

            Console.WriteLine("First name: {0}", firstName);

            Console.WriteLine("Last name: {0}", lastName);

            Console.WriteLine("Age: {0}", age);

            Console.WriteLine("Gender: {0}", gender);

            Console.WriteLine("Personal ID: {0}", id);

            Console.WriteLine("Unique Employee number: {0}", employeeNumber);
        }
    }
}
