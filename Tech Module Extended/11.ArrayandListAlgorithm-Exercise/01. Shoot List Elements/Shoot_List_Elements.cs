using System;
using System.Collections.Generic;

namespace _01.Shoot_List_Elements
{
    public class Shoot_List_Elements
    {
        public static void Main()
        {
            var userInput = Console.ReadLine();

            var numbersToShoot = new List<int>();

            userInput = ConsoleOutpute(userInput, numbersToShoot);
        }

        static string ConsoleOutpute(string userInput, List<int> numbersToShoot)
        {
            while (userInput != "stop")
            {
                int number;

                var isTrue = false;

                var shotingNumber = 0;

                if (int.TryParse(userInput, out number))
                {
                    if (number > 0)
                    {
                        numbersToShoot.Insert(0, number);
                    }
                }

                else if (userInput == "bang")
                {
                    if (numbersToShoot.Count > 0)
                    {
                        var average = GetAverageSumOfTheElements(numbersToShoot);

                        for (int i = 0; i < numbersToShoot.Count; i++)
                        {
                            shotingNumber = numbersToShoot[i];

                            if (shotingNumber <= average)
                            {
                                Console.WriteLine($"shot {shotingNumber}");

                                numbersToShoot.RemoveAt(i);

                                isTrue = true;

                                break;
                            }
                        }
                    }
                }

                userInput = Console.ReadLine();

                if (userInput == "stop" && numbersToShoot.Count == 0)
                {
                    Console.WriteLine($"you shot them all. last one was {shotingNumber}");
                }

                else if (numbersToShoot.Count == 0)
                {
                    Console.WriteLine($"nobody left to shoot! last one was {shotingNumber}");

                    break;
                }

                DecrementAllNumbersLeftInIt(numbersToShoot, isTrue);
            }

            if (numbersToShoot.Count > 0)
            {
                var result = string.Join(" ", numbersToShoot);

                Console.WriteLine($"survivors: {result}");
            }

            return userInput;
        }

        static List<int> DecrementAllNumbersLeftInIt(List<int> numbersToShoot, bool isTrue)
        {
            if (isTrue)
            {
                for (int i = 0; i < numbersToShoot.Count; i++)
                {
                    numbersToShoot[i]--;
                }
            }

            return numbersToShoot;
        }

        static double GetAverageSumOfTheElements(List<int> numbersToShoot)
        {
            var sum = 0;

            var len = numbersToShoot.Count;

            foreach (var num in numbersToShoot)
            {
                sum += num;
            }

            double averageSum = (double)sum / (double)len;

            return averageSum;
        }
    }
}
