using System;

namespace _08.Trade_Comissions
{
    class Trade_Comissions
    {
        static void Main()
        {
            var town = Console.ReadLine().ToLower();

            var sales = double.Parse(Console.ReadLine());

            var commissions = -1.0;

            if (town == "sofia")
            {
                if (0 <= sales && sales <= 500)
                {
                    commissions = 0.05;
                }

                else if (500 <= sales && sales <= 1000)
                {
                    commissions = 0.07;
                }

                else if (1000 <= sales && sales <= 10000)
                {
                    commissions = 0.08;
                }

                else if (sales >= 10000)
                {
                    commissions = 0.12;
                }
            }

            else if (town == "varna")
            {
                if (0 <= sales && sales <= 500)
                {
                    commissions = 0.045;
                }

                else if (500 <= sales && sales <= 1000)
                {
                    commissions = 0.075;
                }

                else if (1000 <= sales && sales <= 10000)
                {
                    commissions = 0.10;
                }

                else if (sales >= 10000)
                {
                    commissions = 0.13;
                }
            }

            else if (town == "plovdiv")
            {
                if (0 <= sales && sales <= 500)
                {
                    commissions = 0.055;
                }

                else if (500 <= sales && sales <= 1000)
                {
                    commissions = 0.08;
                }

                else if (1000 <= sales && sales <= 10000)
                {
                    commissions = 0.12;
                }

                else if (sales >= 10000)
                {
                    commissions = 0.145;
                }
            }

            if (commissions > -1.0)
            {
                Console.WriteLine("{0:f2}", (commissions * sales));
            }

            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
