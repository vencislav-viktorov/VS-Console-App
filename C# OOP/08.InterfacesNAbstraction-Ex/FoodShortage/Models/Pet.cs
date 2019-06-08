namespace FoodShortage
{
    using System;

    public class Pet : IBirthable
    {
        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = DateTime
                .ParseExact(birthdate, "dd/mm/yyyy", null);
        }

        public string Name { get; }

        public DateTime Birthdate { get; }
    }
}