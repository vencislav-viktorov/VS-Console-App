namespace DefiningClasses
{
    using System.Collections.Generic;

    public class Department
    {
        public Department(string name)
        {
            this.Name = name;
            this.Employees = new List<Employee>();
        }

        public List<Employee> Employees { get; set; }

        public string Name { get; set; }

        public decimal GetAverageSalary()
        {
            var avgSalary = 0m;

            foreach (var emp in Employees)
            {
                avgSalary += emp.Salary;
            }

            return avgSalary / Employees.Count;
        }
    }
}