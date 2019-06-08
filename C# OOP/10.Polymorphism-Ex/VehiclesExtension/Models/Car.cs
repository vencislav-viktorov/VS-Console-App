namespace VehiclesExtension
{
    public class Car : Vehicle
    {
        private const double airConditionersConsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, int tankCapacity)
            : base(fuelQuantity, fuelConsumption + airConditionersConsumption, tankCapacity)
        {
        }
    }
}