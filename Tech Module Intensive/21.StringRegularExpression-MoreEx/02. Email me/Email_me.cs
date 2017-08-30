using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Email_me
{
    public class Email_me
    {
        public static void Main()
        {
            var matches = Regex.Split(Console.ReadLine(), "@").ToList();

            var sumleft = 0;

            var sumright = 0;

            foreach (var letter in matches[0])
            {
                sumleft += (int)letter;
            }

            foreach (var letter in matches[1])
            {
                sumright += (int)letter;
            }

            if (sumleft - sumright >= 0) Console.WriteLine("Call her!");

            else Console.WriteLine("She is not the one.");
        }
    }
}
