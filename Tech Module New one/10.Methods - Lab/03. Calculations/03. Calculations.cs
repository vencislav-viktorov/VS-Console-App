using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main()
        {
            string comand = Console.ReadLine().ToLower();

            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            switch (comand)
            {
                case "add":
                    AddBetweenTwoNumbers(firstNum, secondNum);
                    break;

                case "subtract":
                    SubtractBetweenTwoNumbers(firstNum, secondNum);
                    break;

                case "multiply":
                    MultiplyBetweenTwoNumbers(firstNum, secondNum);
                    break;

                case "divide":
                    DivideBetweenTwoNumbers(firstNum, secondNum);
                    break;
                    
                default:
                    break;
            }
        }

        static void DivideBetweenTwoNumbers(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum / secondNum);
        }

        static void MultiplyBetweenTwoNumbers(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum * secondNum);
        }

        static void SubtractBetweenTwoNumbers(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum - secondNum);
        }

        static void AddBetweenTwoNumbers(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum + secondNum);
        }
    }
}
