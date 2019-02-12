using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] tokens = line.Split();

                string serialNumber = tokens[0];

                string itemName = tokens[1];

                int itemQuantity = int.Parse(tokens[2]);

                decimal itemPrice = decimal.Parse(tokens[3]);

                Box currentBox = new Box(serialNumber, itemName, itemQuantity, itemPrice);

                boxes.Add(currentBox);

                line = Console.ReadLine();
            }

            foreach (Box box in boxes.OrderByDescending(x => x.PriceBox))
            {
                Console.WriteLine(box.SerialNumber);

                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.Quantity}");

                Console.WriteLine($"-- ${box.PriceBox:F2}");
            }
        }
    }
}
