namespace Ferrari
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Ferrari : IFerrari
    {
        public Ferrari(string driverName)
        {
            this.Driver = driverName;
        }

        public string Model => "488-Spider";

        public string Driver { get; private set; }

        public string PushBrakes => "Brakes!";

        public string Gas => "Gas!";

        public override string ToString()
        {
            return $"{this.Model}/{this.PushBrakes}/{this.Gas}/{this.Driver}";
        }
    }
}