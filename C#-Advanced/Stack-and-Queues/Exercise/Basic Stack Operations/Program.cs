﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var countToPush = command[0];
            var countsToPop = command[1];
            var numberToSearch = command[2];

            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> numbers = new Stack<int>(input);

            for (int i = 0; i < countsToPop; i++)
            {
                numbers.Pop();
            }

            if (numbers.Contains(numberToSearch))
            {
                Console.WriteLine($"true");
            }

            else if (numbers.Count>0)
            {
                Console.WriteLine(numbers.Min());
            }

            else
            {
                Console.WriteLine($"0");
            }
        }
    }
}
