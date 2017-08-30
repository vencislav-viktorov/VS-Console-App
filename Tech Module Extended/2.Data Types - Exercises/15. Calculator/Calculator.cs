using System;

namespace _15.Calculator
{
    public class Calculator
    {
        public static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());

            char operatori = char.Parse(Console.ReadLine());

            int number2 = int.Parse(Console.ReadLine());

            int result = 0;

            {
                switch (operatori)
                {
                    case '-':
                        result = number1 - number2;
                        break;

                    case '+':
                        result = number2 + number2;
                        break;

                    case '*':
                        result = number1 * number2;
                        break;

                    case '/':
                        result = number1 / number2;
                        break;

                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
            }

            Console.WriteLine($"{number1} {operatori} {number2} = {result}");
        }
    }
}