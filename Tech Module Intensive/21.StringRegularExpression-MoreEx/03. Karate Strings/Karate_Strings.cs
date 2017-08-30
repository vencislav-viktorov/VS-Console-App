using System;
using System.Linq;
using System.Text;

namespace _03.Karate_Strings
{
    public class Karate_Strings
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split('>').ToList();

            var result = new StringBuilder();

            result.Append(text[0]);

            var carrystrength = 0;

            for (int i = 1; i < text.Count; i++)
            {
                var strength = int.Parse(text[i][0].ToString()) + carrystrength;

                if (strength > text[i].Length)
                {
                    carrystrength = strength - text[i].Length;

                    result.Append(">");
                }

                else
                {
                    carrystrength = 0;

                    result.Append(">" + text[i].Substring(strength));
                }
            }

            Console.WriteLine(result);
        }
    }
}
