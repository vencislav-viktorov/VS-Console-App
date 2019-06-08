namespace DefiningClasses
{
    public class Car
    {
        public Car(string[] carInfo)
        {
            this.Model = carInfo[0];

            this.Engine = new Engine(int.Parse(carInfo[1]), int.Parse(carInfo[2]));

            this.Cargo = new Cargo(int.Parse(carInfo[3]), carInfo[4]);

            this.TireSet = new Tire[4]
            {
                new Tire(double.Parse(carInfo[5]), int.Parse(carInfo[6])),
                new Tire(double.Parse(carInfo[7]), int.Parse(carInfo[8])),
                new Tire(double.Parse(carInfo[9]), int.Parse(carInfo[10])),
                new Tire(double.Parse(carInfo[11]), int.Parse(carInfo[12]))
            };
        }

        public Tire[] TireSet { get; set; }

        public Cargo Cargo { get; set; }

        public Engine Engine { get; set; }

        public string Model { get; set; }
    }
}