namespace ExplicitInterfaces
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var line = Console.ReadLine();

            while (line != "End")
            {
                var citizenArgs = line
                    .Split();

                var name = citizenArgs[0];
                var country = citizenArgs[1];
                var age = int.Parse(citizenArgs[2]);

                var citizen = new Citizen(name, age, country);

                Console.WriteLine(((IPerson)citizen).GetName());
                Console.WriteLine(((IResident)citizen).GetName());

                line = Console.ReadLine();
            }
        }
    }
}