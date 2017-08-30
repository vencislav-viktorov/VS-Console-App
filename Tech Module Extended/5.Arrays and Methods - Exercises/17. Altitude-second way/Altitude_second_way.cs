using System;

namespace _17.Altitude_second_way
{
    public class Altitude_second_way
    {
        public static void Main()
        {
            string[] massive = Console.ReadLine().Split(' ');

            decimal sum = decimal.Parse(massive[0]);

            bool lamp = false;

            for (int i = 0; i < massive.Length; i++)
            {
                if (i % 2 != 0)
                {
                    if (massive[i] == "up")
                    {
                        sum += decimal.Parse(massive[i + 1]);
                    }

                    else if (massive[i] == "down")
                    {
                        sum -= decimal.Parse(massive[i + 1]);
                    }

                    if (sum <= 0)
                    {
                        lamp = true;

                        break;
                    }
                }
            }

            if (lamp == true)
            {
                Console.WriteLine("crashed");
            }

            else
            {
                Console.WriteLine("got through safely. current altitude: {0}m", sum);
            }
        }
    }
}
