using System;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main()
        {
            var carParking = new HashSet<string>();
            var input = Console.ReadLine();

            while (input != "END")
            {
                var tokens = input
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                var command = tokens[0];
                var numberPlateOfCar = tokens[1];

                if (command == "IN")
                {
                    carParking.Add(numberPlateOfCar);
                }

                else if (command == "OUT")
                {
                    carParking.Remove(numberPlateOfCar);
                }

                input = Console.ReadLine();
            }

            if (carParking.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
                return;
            }

            foreach (var numberPlate in carParking)
            {
                Console.WriteLine(numberPlate);
            }
        }
    }
}