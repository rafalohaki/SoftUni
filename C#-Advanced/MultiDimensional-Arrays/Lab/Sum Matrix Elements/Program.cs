﻿using System;
using System.Linq;

namespace Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int[,] matrix = new int[size[0], size[1]];
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var currentCol = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentCol[col];
                    sum += matrix[row, col];
                }
            }

            Console.WriteLine(size[0]);
            Console.WriteLine(size[1]);
            Console.WriteLine(sum);
        }
    }
}
