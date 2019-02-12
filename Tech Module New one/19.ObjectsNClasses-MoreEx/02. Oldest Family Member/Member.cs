using System;
using System.Collections.Generic;
using System.Text;

class Member
{
    public Member(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name { get; set; }
    public int Age { get; set; }
}
