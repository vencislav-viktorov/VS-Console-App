namespace DefiningClasses
{
    using System;

    public class DateModifier
    {
        public int Difference { get; set; }

        public static int GetDifferenceBetweenDates(string firstDateAsSstr, string secondDateAsStr)
        {
            DateTime firstDate = DateTime.ParseExact(firstDateAsSstr, "yyyy MM dd", null);
            DateTime secondDate = DateTime.ParseExact(secondDateAsStr, "yyyy MM dd", null);

            return (int)Math.Abs((firstDate - secondDate).TotalDays);
        }
    }
}