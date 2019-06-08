namespace DefiningClasses
{
    public class Engine
    {
        public Engine(int engineSpeed, int enginePower)
        {
            this.Speed = engineSpeed;
            this.Power = enginePower;
        }

        public int Power { get; set; }

        public int Speed { get; set; }
    }
}