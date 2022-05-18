using System;
using System.Linq;

class SumMatrixColumns
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
            int[] line = Console.ReadLine().Split(" ")
                .Select(int.Parse).ToArray();
            for (int col = 0; col < colsCount; col++)
            {
                matrix[row, col] = line[col];
            }
        }


        // Calculate the matrix columns sum
        long[] colSums = new long[colsCount];
        for (int col = 0; col < colsCount; col++)
        {
            long sum = 0;
            for (int row = 0; row < rowsCount; row++)
            {
                sum += matrix[row, col];
                //colSums[col] += matrix[row, col];
            }
            Console.WriteLine(sum);
        }

        //// Print the columns sum
        //for (int col = 0; col < colsCount; col++)
        //    Console.WriteLine(colSums[col]);

    }
}

