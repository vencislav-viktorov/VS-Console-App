namespace VehiclesExtension
{
    public class Bus : Vehicle
    {
        private const double airConditionersConsumption = 1.4;
        
        public Bus(double fuelQuantity, double fuelConsumption, int tankCapacity) 
            : base(fuelQuantity, fuelConsumption + airConditionersConsumption, tankCapacity)
        {
        }

        public string DriveEmpty(double distance)
        {
            this.FuelConsumption -= airConditionersConsumption;

            return base.Drive(distance);
        }
    }
}