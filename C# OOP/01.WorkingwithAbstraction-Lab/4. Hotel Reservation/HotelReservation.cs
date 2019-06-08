namespace HotelReservation
{
    using System;

    public class HotelReservation
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split();

            decimal pricePerDay = decimal.Parse(input[0]);
            int numberOfDays = int.Parse(input[1]);
            Season season = Enum.Parse<Season>(input[2]);
            Discount discount = Discount.None;

            if (input.Length > 3)
            {
                discount = Enum.Parse<Discount>(input[3]);
            }

            PriceCalculator priceCalculator = new PriceCalculator(pricePerDay, numberOfDays, season, discount);

            decimal finalPrice = PriceCalculator.CalculatePrice(pricePerDay, numberOfDays, season, discount);

            Console.WriteLine($"{finalPrice:f2}");

        }
    }
}
