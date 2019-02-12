using System;
using System.Collections.Generic;
using System.Text;

public class Box
{
    public Box(string serialNumber, string itemName, int Quantity, decimal itemPrice)
    {
        this.Item = new Item();

        this.SerialNumber = serialNumber;

        this.Item.Name = itemName;

        this.Quantity = Quantity;

        this.Item.Price = itemPrice;

        this.PriceBox = itemPrice * Quantity;
    }

    public string SerialNumber { get; set; }

    public Item Item { get; set; }

    public int Quantity { get; set; }

    public decimal PriceBox { get; set; }
}

