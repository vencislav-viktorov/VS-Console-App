namespace Vehicles
{
    public abstract class Vehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; protected set; }

        public double FuelConsumption { get; private set; }

        public virtual void Refuel(double amount)
        {
            this.FuelQuantity += amount;
        }

        public string Drive(double distance)
        {
            var vehicleName = this.GetType().Name;
            var neededFuel = this.FuelConsumption * distance;

            if (this.FuelQuantity >= neededFuel)
            {
                this.FuelQuantity -= neededFuel;
                return $"{vehicleName} travelled {distance} km";
            }

            else
            {
                return $"{vehicleName} needs refueling";
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}