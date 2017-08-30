using System;

namespace _09.Count_the_Integers
{
    public class Count_the_Integers
    {
        public static void Main()
        {
            int counter = 0;

            try
            {
                while (true)
                {
                    var input = int.Parse(Console.ReadLine());

                    counter++;
                }

            }

            catch (Exception)
            {
                Console.WriteLine(counter);
            }
        }
    }
}