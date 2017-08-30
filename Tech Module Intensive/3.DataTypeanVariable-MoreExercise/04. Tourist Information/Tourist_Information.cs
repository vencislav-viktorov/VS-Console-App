using System;

namespace _04.Tourist_Information
{
    public class Tourist_Information
    {
        public static void Main()
        {
            string type = Console.ReadLine();

            double num = double.Parse(Console.ReadLine());

            double transformation = 0;

            string transformationType = String.Empty;

            switch (type)
            {
                case "miles":
                    transformation = num * 1.6;
                    transformationType = "kilometers";
                    break;

                case "inches":
                    transformation = num * 2.54;
                    transformationType = "centimeters";
                    break;

                case "feet":
                    transformation = num * 30;
                    transformationType = "centimeters";
                    break;

                case "yards":
                    transformation = num * 0.91;
                    transformationType = "meters";
                    break;

                case "gallons":
                    transformation = num * 3.8;
                    transformationType = "liters";
                    break;
                    
                default:
                    break;
            }

            Console.WriteLine($"{num} {type} = {transformation:f2} {transformationType}");
        }
    }
}
