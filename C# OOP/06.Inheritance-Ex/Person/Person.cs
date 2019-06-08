namespace Person
{
    using System;
    using System.Text;

    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get => this.name;

            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException($"{nameof(this.Name)}'s length should not be less than 3 symbols!");
                }

                this.name = value;
            }
        }

        public virtual int Age
        {
            get => this.age;

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"{nameof(this.Age)} must be positive!");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append($"{nameof(this.Name)}: {this.Name}, {nameof(this.Age)}: {this.Age}");

            return stringBuilder.ToString();
        }
    }
}