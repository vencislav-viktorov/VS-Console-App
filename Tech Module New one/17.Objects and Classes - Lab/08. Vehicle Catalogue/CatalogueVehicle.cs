using System;
using System.Collections.Generic;
using System.Text;

class CatalogueVehicle
{
    public List<Car> Cars { get; set; }

    public List<Trucks> Trucks { get; set; }

    public CatalogueVehicle(List<Car> car, List<Trucks> truck)
    {
        this.Cars = car;

        this.Trucks = truck;
    }
}
