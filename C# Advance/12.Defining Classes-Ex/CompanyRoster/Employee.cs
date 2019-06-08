namespace DefiningClasses
{
    public class Employee
    {
        public Employee(string name, decimal salary, string position, Department department, string email, int age)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
            this.Email = email;
            this.Age = age;
        }

        public Employee(string name, decimal salary, string position, Department department, string email)
            : this(name, salary, position, department, email, -1)
        {
        }

        public Employee(string name, decimal salary, string position, Department department, int age)
            : this(name, salary, position, department, "n/a", age)
        {
        }

        public Employee(string name, decimal salary, string position, Department department)
            : this(name, salary, position, department, "n/a", -1)
        {
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        public string Position { get; set; }

        public decimal Salary { get; set; }

        public Department Department { get; set; }
    }
}