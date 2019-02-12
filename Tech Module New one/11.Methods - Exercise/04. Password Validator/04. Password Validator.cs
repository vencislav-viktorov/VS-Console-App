using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main()
        {
            string password = Console.ReadLine();

            if (ValidatePassword(password))
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool ValidatePassword(string password)
        {
            bool correctCharCount = ValidataCount(password);

            bool onlyLettersAndDigits = ValidateContain(password);

            bool haveTwoDigits = ValidateDigitsCount(password);

            return correctCharCount && onlyLettersAndDigits && haveTwoDigits;
        }

        private static bool ValidateDigitsCount(string password)
        {
            int digitsCount = 0;

            for (int i = 0; i < password.Length; i++)
            {
                char symbol = password[i];

                if (Char.IsDigit(symbol))
                {
                    digitsCount++;

                    if (digitsCount >= 2)
                    {
                        return true;
                    }
                }
            }

            Console.WriteLine("Password must have at least 2 digits");

            return false;
        }

        private static bool ValidateContain(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                char symbol = password[i];

                if (!Char.IsLetterOrDigit(symbol))
                {
                    Console.WriteLine("Password must consist only of letters and digits");

                    return false;
                }
            }

            return true;
        }

        static bool ValidataCount(string password)
        {
            bool isValid = password.Length > 5 && password.Length < 11;

            if (!isValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");

                return false;
            }

            return true;
        }
    }
}
