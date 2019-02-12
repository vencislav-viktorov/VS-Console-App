using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            GetType(type);
        }

        private static void GetType(string type)
        {
            switch (type)
            {
                case "int":
                    double number = int.Parse(Console.ReadLine());
                    PrintNumberMultiplyBy2(number);
                    break;

                case "real":
                    number = double.Parse(Console.ReadLine());
                    PrintNumberMultiplyByOneNHalf(number);
                    break;

                case "string":
                    string text = Console.ReadLine();
                    PrintStringFrontNRearWithDollar(text);
                    break;

                default:
                    break;
            }
        }

        private static void PrintNumberMultiplyBy2(double number)
        {
            Console.WriteLine(number * 2);
        }

        private static void PrintNumberMultiplyByOneNHalf(double number)
        {
            Console.WriteLine($"{(number * 1.5):f2}");
        }

        private static void PrintStringFrontNRearWithDollar(string text)
        {
            Console.WriteLine($"${text}$");
        }
    }
}
