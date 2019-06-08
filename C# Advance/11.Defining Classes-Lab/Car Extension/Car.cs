namespace CarManufacturer
{
    using System;
    using System.Text;

    public class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            bool canContinue =
                this.FuelQuantity - (distance / 100) * this.FuelConsumption > 0;

            if (canContinue)
            {
                this.FuelQuantity -= (distance / 100) * this.FuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string GetInformation()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Make: {this.Make}");
            result.AppendLine($"Model: {this.Model}");
            result.AppendLine($"Year: {this.Year}");
            result.Append($"Fuel: {this.FuelQuantity:F2}L");

            return result.ToString();
        }
    }
}
