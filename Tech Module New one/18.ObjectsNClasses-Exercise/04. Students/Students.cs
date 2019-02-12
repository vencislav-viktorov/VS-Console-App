using System;
using System.Collections.Generic;
using System.Text;

class Students
{
    public Students(string firstName, string lastName, double grade)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Grade = grade;
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public double Grade { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName} {Grade:f2}";
    }
}
