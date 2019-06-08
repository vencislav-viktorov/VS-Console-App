namespace ComparingObjects
{
    using System;

    public class Person : IComparable<Person>
    {
        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Town { get; set; }

        public int CompareTo(Person other)
        {
            var resultName = this.Name.CompareTo(other.Name);

            if (resultName == 0)
            {
                var resultAge = this.Age.CompareTo(other.Age);

                if (resultAge == 0)
                {
                    return this.Town.CompareTo(other.Town);
                }

                return resultAge;
            }

            return resultName;
        }
    }
}
