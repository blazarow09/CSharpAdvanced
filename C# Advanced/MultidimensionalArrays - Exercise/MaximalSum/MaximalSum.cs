﻿namespace MaximalSum
{
    using System;
    using System.Linq;

    class MaximalSum
    {
        static void Main(string[] args)
        {
            var sizes = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            var rows = sizes[0];
            var cols = sizes[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var inputNumbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputNumbers[col];
                }
            }

            var sum = 0;
            var tempSum = 0;
            var rowIndex = 0;
            var colIndex = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    tempSum += matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (tempSum > sum)
                    {
                        sum = tempSum;
                        rowIndex = row;
                        colIndex = col;
                    }
                    tempSum = 0;
                }
            }

            Console.WriteLine($"Sum = {sum}");

            Console.WriteLine(matrix[rowIndex, colIndex] + " "
                + matrix[rowIndex, colIndex + 1] + " "
                + matrix[rowIndex, colIndex + 2]);

            Console.WriteLine(matrix[rowIndex + 1, colIndex] + " "
                + matrix[rowIndex + 1, colIndex + 1] + " "
                + matrix[rowIndex + 1, colIndex + 2]);

            Console.WriteLine(matrix[rowIndex + 2, colIndex] + " "
                + matrix[rowIndex + 2, colIndex + 1] + " "
                + matrix[rowIndex + 2, colIndex + 2]);
        }
    }
}
