using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Read the matrix dimensions: rows, cols
        int[] dimensions = Console.ReadLine().Split(", ")
            .Select(int.Parse).ToArray();
        (int rowsCount, int colsCount) = (dimensions[0], dimensions[1]);

        // Read the numbers for the matrix
        int[,] matrix = new int[rowsCount, colsCount];
        for (int row = 0; row < rowsCount; row++)
        {
            int[] line = Console.ReadLine().Split(", ")
                .Select(int.Parse).ToArray();
            for (int col = 0; col < colsCount; col++)
            {
                matrix[row, col] = line[col];
            }
        }

        //// Print the matrix
        //for (int row = 0; row < rowsCount; row++)
        //{
        //    for (int col = 0; col < colsCount; col++)
        //    {
        //        Console.Write(matrix[row, col] + " ");
        //    }
        //    Console.WriteLine();
        //}

        // Calculate the matrix sum
        long sum = 0;
        for (int row = 0; row < rowsCount; row++)
            for (int col = 0; col < colsCount; col++)
                sum += matrix[row, col];

        Console.WriteLine(rowsCount);
        Console.WriteLine(colsCount);
        Console.WriteLine(sum);

    }
}

