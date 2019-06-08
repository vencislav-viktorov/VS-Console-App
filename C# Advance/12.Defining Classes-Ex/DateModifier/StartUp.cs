namespace DefiningClasses
{
    using System;

    public class StarUp
    {
        public static void Main()
        {
            var firstDateAsStr = Console.ReadLine();
            var secondDateAsStr = Console.ReadLine();

            DateModifier currentModif = new DateModifier();

            currentModif.Difference = DateModifier.GetDifferenceBetweenDates(firstDateAsStr, secondDateAsStr);

            Console.WriteLine(currentModif.Difference);
        }
    }
}