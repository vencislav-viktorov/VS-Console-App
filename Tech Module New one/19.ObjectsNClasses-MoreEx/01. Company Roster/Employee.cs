using System;
using System.Collections.Generic;
using System.Text;

class Employee
{
    public Employee(string name, double salary, string department)
    {
        this.Name = name;
        this.Salary = salary;
        this.Department = department;
    }

    public string Name { get; set; }
    public double Salary { get; set; }
    public string Department { get; set; }
}
