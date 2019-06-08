namespace DefinintgClasses
{
    using System;

    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKM)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKM = fuelConsumptionPerKM;
        }
        
        public int TraveledKM { get; set; }

        public double FuelConsumptionPerKM { get; set; }

        public double FuelAmount { get; set; }

        public string Model { get; set; }

        public void Drive(int KM)
        {
            if (this.FuelAmount >= (KM * this.FuelConsumptionPerKM))
            {
                this.FuelAmount -= KM * this.FuelConsumptionPerKM;
                this.TraveledKM += KM;
            }

            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}