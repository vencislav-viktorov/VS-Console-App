namespace TrafficLights
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split();

            var trafficLights = new TrafficLight[input.Length];

            for (int i = 0; i < trafficLights.Length; i++)
            {
                trafficLights[i] = (TrafficLight)Activator
                    .CreateInstance(typeof(TrafficLight), new object[] { input[i] });
            }

            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var result = new List<string>();

                foreach (var trafficLight in trafficLights)
                {
                    trafficLight.Update();
                    var field = typeof(TrafficLight)
                        .GetField("currentSignal",
                        BindingFlags.NonPublic |
                        BindingFlags.Instance);
                    result.Add(field.GetValue(trafficLight).ToString());
                }

                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}