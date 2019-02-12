using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmdArgs = command.Split();

                if (cmdArgs[0] == "exchange")
                {
                    int index = int.Parse(cmdArgs[1]);

                    if (index >= 0 && index < number.Length)
                    {
                        Exchange(number, index);
                    }

                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }

                else if (cmdArgs[0] == "max")
                {
                    if (cmdArgs[1] == "even")
                    {
                        int index = FindMaxEvenIndex(number);

                        if (index != -1)
                        {
                            Console.WriteLine(index);
                        }

                        else
                        {
                            Console.WriteLine("No matches");
                        }

                    }

                    else
                    {
                        int index = FindMaxOddIndex(number);

                        if (index != -1)
                        {
                            Console.WriteLine(index);
                        }

                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                }

                else if (cmdArgs[0] == "min")
                {
                    if (cmdArgs[1] == "even")
                    {
                        int index = FindMinEvenIndex(number);

                        if (index != -1)
                        {
                            Console.WriteLine(index);
                        }

                        else
                        {
                            Console.WriteLine("No matches");
                        }

                    }

                    else
                    {
                        int index = FindMinOddIndex(number);

                        if (index != -1)
                        {
                            Console.WriteLine(index);
                        }

                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                }

                else if (cmdArgs[0] == "first")
                {
                    int count = int.Parse(cmdArgs[1]);

                    if (cmdArgs[2] == "even")
                    {
                        if (count <= number.Length)
                        {
                            PrintFirstEven(number, count);
                        }

                        else
                        {
                            Console.WriteLine("Invalid count");
                        }
                    }

                    else
                    {
                        if (count <= number.Length)
                        {
                            PrintFirstOdd(number, count);
                        }

                        else
                        {
                            Console.WriteLine("Invalid count");
                        }
                    }
                }

                else if (cmdArgs[0] == "last")
                {
                    int count = int.Parse(cmdArgs[1]);

                    if (cmdArgs[2] == "even")
                    {
                        if (count <= number.Length)
                        {
                            PrintLastEven(number, count);
                        }

                        else
                        {
                            Console.WriteLine("Invalid count");
                        }
                    }

                    else
                    {
                        if (count <= number.Length)
                        {
                            PrintLastOdd(number, count);
                        }

                        else
                        {
                            Console.WriteLine("Invalid count");
                        }
                    }
                }

                command = Console.ReadLine();
            }

            PrintArray(number);
        }

        private static void PrintLastOdd(int[] number, int count)
        {
            int[] arr = new int[number.Length];

            for (int i = number.Length - 1; i >= 0; i--)
            {
                if (number[i] % 2 != 0 && count > 0)
                {
                    count--;

                    arr[i] = number[i];
                }

                else
                {
                    arr[i] = -1;
                }
            }

            arr.Reverse();

            PrintArray(arr);
        }

        private static void PrintLastEven(int[] number, int count)
        {
            int[] arr = new int[number.Length];
            
            for (int i = number.Length -1; i >= 0; i--)
            {
                if (number[i] % 2 == 0 && count > 0)
                {
                    count--;

                    arr[i] = number[i];
                }

                else
                {
                    arr[i] = -1;
                }
            }

            arr.Reverse();

            PrintArray(arr);
        }

        private static void PrintFirstOdd(int[] number, int count)
        {
            int[] arr = new int[number.Length];

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 != 0 && count > 0)
                {
                    count--;

                    arr[i] = number[i];
                }

                else
                {
                    arr[i] = -1;
                }
            }

            PrintArray(arr);
        }

        private static void PrintFirstEven(int[] number, int count)
        {
            int[] arr = new int[number.Length];

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 == 0 && count > 0)
                {
                    count--;

                    arr[i] = number[i];
                }

                else
                {
                    arr[i] = -1;
                }
            }

            PrintArray(arr);
        }

        private static int FindMinOddIndex(int[] number)
        {
            int index = -1;

            int maxNum = int.MaxValue;

            for (int i = 0; i < number.Length; i++)
            {
                if (maxNum >= number[i] && number[i] % 2 != 0)
                {
                    maxNum = number[i];
                    index = i;
                }
            }

            return index;
        }

        private static int FindMinEvenIndex(int[] number)
        {
            int index = -1;

            int maxNum = int.MaxValue;

            for (int i = 0; i < number.Length; i++)
            {
                if (maxNum >= number[i] && number[i] % 2 == 0)
                {
                    maxNum = number[i];
                    index = i;
                }
            }

            return index;
        }

        private static int FindMaxOddIndex(int[] number)
        {
            int index = -1;

            int maxNum = int.MinValue;

            for (int i = 0; i < number.Length; i++)
            {
                if (maxNum <= number[i] && number[i] % 2 != 0)
                {
                    maxNum = number[i];
                    index = i;
                }
            }

            return index;
        }

        private static int FindMaxEvenIndex(int[] number)
        {
            int index = -1;

            int maxNum = int.MinValue;

            for (int i = 0; i < number.Length; i++)
            {
                if (maxNum <= number[i] && number[i] % 2 == 0)
                {
                    maxNum = number[i];
                    index = i;
                }
            }

            return index;
        }

        private static void PrintArray(int[] number)
        {
            Console.Write("[");

            bool printsFirst = true;

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] != -1)
                {
                    if (printsFirst)
                    {
                        Console.Write(number[i]);
                        printsFirst = false;

                    }

                    else
                    {
                        Console.Write(", " + number[i]);
                    }
                }
            }

            Console.WriteLine("]");
        }

        private static void Exchange(int[] number, int index)
        {
            int[] first = new int[index + 1];
            int[] second = new int[number.Length - index - 1];

            for (int i = 0; i <= index; i++)
            {
                first[i] = number[i];
            }

            for (int i = index + 1; i < number.Length; i++)
            {
                second[i - index - 1] = number[i];
            }

            for (int i = 0; i < second.Length; i++)
            {
                number[i] = second[i];
            }

            //for (int i = 0; i < first.Length; i++)
            //{
            //    number[i + second.Length] = first[i];
            //}

            for (int i = second.Length; i < number.Length; i++)
            {
                number[i] = first[i - second.Length];
            }
        }
    }
}
