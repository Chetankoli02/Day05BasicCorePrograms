﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    internal class Factors
    {
        public void CalculateFactor()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Prime factors of {number}:");
            ComputePrimeFactors(number);
        }
        static void ComputePrimeFactors(int number)
        {
            while (number % 2 == 0)
            {
                Console.Write("2 ");
                number /= 2;
            }
            for (int i = 3; i * i <= number; i += 2)
            {
                while (number % i == 0)
                {
                    Console.Write($"{i} ");
                    number /= i;
                }
            }
            if (number > 2)
                Console.Write(number);
        }
    }
}
