using System;
using System.Collections.Generic;
using System.Text;

class Vehicles
{
    public Vehicles(string type, string model, string colour, int horsePower)
    {
        this.Type = type;
        this.Model = model;
        this.Colour = colour;
        this.HorsePower = horsePower;
    }

    public string Type { get; set; }

    public string Model { get; set; }

    public string Colour { get; set; }

    public int HorsePower { get; set; }
}