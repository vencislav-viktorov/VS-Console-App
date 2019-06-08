namespace Mankind
{
    using System;
    using System.Linq;
    using System.Text;

    public class Student : Human
    {
        private string facultyNumber;

        public Student(
            string firstName,
            string lastName,
            string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get => this.facultyNumber;

            private set
            {
                if ((value.Length < 5 || value.Length > 10) ||
                    value.All(x => char.IsLetterOrDigit(x)) == false)
                {
                    throw new ArgumentException($"Invalid faculty number!");
                }

                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(base.ToString());
            stringBuilder.AppendLine($"Faculty number: {this.FacultyNumber}");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}