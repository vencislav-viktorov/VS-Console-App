namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double airConditionersConsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption + airConditionersConsumption)
        {
        }
    }
}