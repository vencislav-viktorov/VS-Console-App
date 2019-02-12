using System;
using System.Collections.Generic;
using System.Text;

class Trucks
{
    public string Type { get; set; }

    public string Brand { get; set; }

    public string Model { get; set; }

    public string Weight { get; set; }

    public Trucks(string type, string brand, string model, string weight)
    {
        this.Type = type;

        this.Brand = brand;

        this.Model = model;

        this.Weight = weight;
    }
}
