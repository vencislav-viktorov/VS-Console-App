using System;

namespace _10.Data_Overflow_second_way
{
    public class Data_Overflow_second_way
    {
        public static void Main()
        {
            ulong num1 = ulong.Parse(Console.ReadLine());

            ulong num2 = ulong.Parse(Console.ReadLine());

            ulong minNumber = Math.Min(num1, num2);

            ulong maxNumber = Math.Max(num1, num2);

            decimal overflowValue = 0;

            string smallerType = String.Empty;

            if (minNumber <= byte.MaxValue)
            {
                overflowValue = byte.MaxValue;

                smallerType = "byte";
            }

            else if (minNumber <= ushort.MaxValue)
            {
                overflowValue = ushort.MaxValue;

                smallerType = "ushort";
            }

            else if (minNumber <= uint.MaxValue)
            {
                overflowValue = uint.MaxValue;

                smallerType = "uint";
            }

            else if (minNumber <= ulong.MaxValue)
            {
                overflowValue = ulong.MaxValue;

                smallerType = "ulong";
            }

            string maxType = String.Empty;

            if (maxNumber <= byte.MaxValue)
            {
                maxType = "byte";
            }

            else if (maxNumber <= ushort.MaxValue)
            {
                maxType = "ushort";
            }

            else if (maxNumber <= uint.MaxValue)
            {
                maxType = "uint";
            }

            else if (maxNumber <= ulong.MaxValue)
            {
                maxType = "ulong";
            }

            decimal overflowCount = maxNumber / overflowValue;

            Console.WriteLine($"bigger type: {maxType}");

            Console.WriteLine($"smaller type: {smallerType}");

            Console.WriteLine($"{maxNumber} can overflow {smallerType} {Math.Round(overflowCount)} times");
        }
    }
}
