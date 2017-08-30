﻿using System;

namespace _01.BlankReceipt
{
    public class BlankReceipt
    {
        public static void Main()
        {
            PrintReceipt();
        }

        static void PrintReceipt()
        {
            PrintHeader();

            PrintBody();

            PrintFooter();
        }

        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");

            Console.WriteLine("------------------------------");
        }

        static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");

            Console.WriteLine("Received by___________________");
        }

        static void PrintFooter()
        {
            Console.WriteLine("------------------------------");

            Console.WriteLine("\u00a9 SoftUni");
        }
    }
}
