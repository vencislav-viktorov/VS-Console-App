namespace Telephony
{
    using System;
    using System.Linq;


    public class Smartphone : ICaller, IBrowser
    {
        public string Browse(string url)
        {
            if (url.Any(Char.IsDigit))
            {
                return "Invalid URL!";
            }

            return $"Browsing: {url}!";
        }

        public string Call(string number)
        {
            if (number.All(char.IsDigit))
            {
                return $"Calling... {number}";
            }
            return "Invalid number!";

        }
    }
}