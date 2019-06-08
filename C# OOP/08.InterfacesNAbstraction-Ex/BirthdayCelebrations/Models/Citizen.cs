namespace BirthdayCelebrations
{
    using System;

    public class Citizen : IIdentifiable, IBirthable
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = DateTime
                .ParseExact(birthdate, "dd/mm/yyyy", null);
        }

        public string Name { get; }

        public int Age { get; }

        public string Id { get; }

        public DateTime Birthdate { get; }
    }
}