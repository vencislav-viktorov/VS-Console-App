using System;

namespace _5._Messages
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string message = String.Empty;

            for (int i = 0; i < n; i++)
            {
                string digits = Console.ReadLine();

                int mainDigit = int.Parse(digits[0].ToString());
                int offset = (mainDigit - 2) * 3;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset += 1;
                }

                int letterIndex = offset + digits.Length - 1;

                if (mainDigit == 0)
                {
                    message += " ";
                }

                else
                {
                    message += (char)(97 + letterIndex);
                }
            }

            Console.WriteLine(message);
        }
    }
}
