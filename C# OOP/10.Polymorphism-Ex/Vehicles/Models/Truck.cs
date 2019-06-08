namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double airConditionersConsumption = 1.6;
        private const double wastedFuel = 0.05;

        public Truck(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption + airConditionersConsumption)
        {
        }

        public override void Refuel(double amount)
        {
            base.Refuel(amount);
            this.FuelQuantity -= amount * wastedFuel;
        }
    }
}