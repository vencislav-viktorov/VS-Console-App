namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var people = new List<Person>();
            var relations = new List<string>();

            var mainPersonInfo = Console.ReadLine();
            
            var input = Console.ReadLine();

            while (input != "End")
            {
                if (input.Contains('-'))
                {
                    relations.Add(input);
                }

                else
                {
                    var personInfo = input
                        .Split();
                    
                    var name = $"{personInfo[0]} {personInfo[1]}";
                    var date = personInfo[2];

                    people.Add(new Person(name, date));
                }

                input = Console.ReadLine();
            }

            var personToPrint = people.Find(p => p.Name == mainPersonInfo || p.DateOfBirth == mainPersonInfo);

            foreach (var relation in relations)
            {
                var relatinParts = relation
                    .Split(" - ");
                var parentInfo = relatinParts[0];
                var childInfo = relatinParts[1];

                if (parentInfo == personToPrint.Name || parentInfo == personToPrint.DateOfBirth)
                {
                    personToPrint.Children.Add(people.Find(p => p.Name == childInfo || p.DateOfBirth == childInfo));
                }

                else if (childInfo == personToPrint.Name || childInfo == personToPrint.DateOfBirth)
                {
                    personToPrint.Parents.Add(people.Find(p => p.Name == parentInfo || p.DateOfBirth == parentInfo));
                }
            }

            Console.WriteLine(personToPrint);
        }
    }
}