using System;
using System.Collections.Generic;
using System.Text;

class Team
{
    public Team(string name, string creatorName)
    {
        this.Name = name;
        this.CreatorName = creatorName;
        this.Members = new List<string>();
    }

    public string Name { get; set; }

    public string CreatorName { get; set; }

    public List<string> Members { get; set; }
}
