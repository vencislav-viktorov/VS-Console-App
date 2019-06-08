namespace HotelReservation
{
    public class PriceCalculator
    {
        public PriceCalculator(decimal pricePerDay,
            int numberOfDays, Season season, Discount discount)
        {
            this.pricePerDay = pricePerDay;
            this.numberOfDays = numberOfDays;
            this.season = season;
            this.discount = discount;
        }

        public decimal pricePerDay;
        public int numberOfDays;
        public Season season;
        public Discount discount;

        public static decimal CalculatePrice(decimal pricePerDay,
            int numberOfDays, Season season, Discount discount)
        {
            int multiplier = (int)season;
            decimal discountMultiplier = (decimal)discount / 100;

            decimal priceBeforeDiscount = numberOfDays * pricePerDay * multiplier;
            decimal discountedAmount = priceBeforeDiscount * discountMultiplier;
            decimal finalPrice = priceBeforeDiscount - discountedAmount;

            return finalPrice;
        }
    }
}
