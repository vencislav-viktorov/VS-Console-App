using System;

namespace _08.Personal_Exception
{
    class Personal_Exception
    {
        static void Main(string[] args)
        {
            bool isAnException = false;

            while (isAnException != true)
            {
                try
                {
                    int digit = int.Parse(Console.ReadLine());

                    if (digit < 0)
                    {
                        throw new NegativeNumberException();
                    }

                    Console.WriteLine(digit);
                }

                catch (NegativeNumberException negativeInputEx)
                {
                    isAnException = true;

                    Console.WriteLine(negativeInputEx.Message);
                }
            }
        }
    }

    public class NegativeNumberException : System.Exception
    {
        public NegativeNumberException() : base()
        {

        }

        public NegativeNumberException(string message) : base(message)
        {
            int digit = 0;

            if (digit < 0)
            {
                ;
            }
        }

        public override string Message
        {
            get
            {
                return "My first exception is awesome!!!";
            }
        }
    }
}
