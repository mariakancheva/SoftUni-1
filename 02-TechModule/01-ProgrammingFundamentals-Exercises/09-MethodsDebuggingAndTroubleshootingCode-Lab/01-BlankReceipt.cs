﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BlankReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintCashReceipt();
        }

        static void PrintCashReceipt()
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
