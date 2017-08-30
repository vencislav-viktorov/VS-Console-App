using System;

namespace _05.Boolean_Variable
{
    public class Boolean_Variable
    {
        public static void Main()
        {
            bool convertedBool = Convert.ToBoolean(Console.ReadLine());

            if (convertedBool)
            {
                Console.WriteLine("Yes");
            }

            else
            {
                Console.WriteLine("No");
            }
        }
    }
}