﻿using System;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} X {i} = {number*i}");
            }
        }
    }
}
