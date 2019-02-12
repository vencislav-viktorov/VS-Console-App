using System;
using System.Collections.Generic;
using System.Text;

class Car
{
    public string Type { get; set; }

    public string Brand { get; set; }

    public string Model { get; set; }

    public string HorsePower { get; set; }

    public Car(string type, string brand, string model, string horsePower)
    {
        this.Type = type;

        this.Brand = brand;

        this.Model = model;

        this.HorsePower = horsePower;
    }
}
