using System;
using System.Globalization;

namespace _13._1000_Days_After_Birth
{
    class Program
    {
        static void Main()
        {
            string dateString = Console.ReadLine();

            string format = "dd-MM-yyyy";

            DateTime result = DateTime.ParseExact(
                dateString, 
                format, 
                CultureInfo.InvariantCulture);

            CultureInfo provider = CultureInfo.InvariantCulture;

            DateTime output = Convert.ToDateTime(result).AddDays(999);

            Console.WriteLine(output.ToString("dd-MM-yyyy"));
        }
    }
}
