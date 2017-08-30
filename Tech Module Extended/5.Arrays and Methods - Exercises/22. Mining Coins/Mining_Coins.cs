using System;

namespace _22.Mining_Coins
{
    public class Mining_Coins
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string decrypted = string.Empty;

            double totalValue = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                int digit1 = number / 100;

                int digit2 = (number % 100) / 10;

                int digit3 = number % 10;

                totalValue += (digit1 + digit2 + digit3) * 1.0 / n;

                int ASCIIcode;

                if (i % 2 != 0)
                {
                    if (digit3 - digit2 < 0)
                    {
                        digit3 = (digit3 + 10) - digit2;

                        digit1--;
                    }

                    else
                    {
                        digit3 = digit3 - digit2;
                    }
                }

                else
                {
                    digit3 = digit3 + digit2;

                    if (digit3 > 9)
                    {
                        digit3 %= 10;

                        digit1++;
                    }
                }

                string sum = digit1.ToString() + digit3.ToString();

                ASCIIcode = int.Parse(sum);

                if ((ASCIIcode >= 65 && ASCIIcode <= 90) || (ASCIIcode >= 97 && ASCIIcode <= 122))
                {

                    decrypted += (char)(ASCIIcode);
                }
            }

            Console.WriteLine("Message: {0}", decrypted);

            Console.WriteLine("Value: {0:0.0000000}", Math.Round(totalValue, 5));
        }
    }
}
