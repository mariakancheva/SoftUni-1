﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = 
                Console.ReadLine()
                .Split()
                .Select(decimal.Parse)
                .ToList();

            numbers.Sort();

            Console.WriteLine(String.Join(" <= ", numbers));
        }
    }
}
