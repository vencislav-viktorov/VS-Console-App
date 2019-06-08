namespace TrafficLights
{
    using System;

    public class TrafficLight
    {
        private Signal currentSignal;

        public TrafficLight(string signal)
        {
            this.currentSignal = (Signal)Enum.Parse(typeof(Signal), signal);
        }

        public void Update()
        {
            var previous = (int)currentSignal;

            currentSignal = (Signal)(++previous % Enum.GetNames(typeof(Signal)).Length);
        }
    }
}