using System;

public class MaximalSum
{
    public static void Main()
    {
        Console.WriteLine("Enter the size of your matrix. First the number of rows and second the number ");
        Console.Write ("of coloms separated by a space: ");
        string[] matrixSize = Console.ReadLine().Split(' ');

        int n = int.Parse(matrixSize[0]);
        int m = int.Parse(matrixSize[1]);
        int[,] matrix = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine();
            Console.WriteLine("Enter the numbers in the {0} row in your matrix separated by a space: ", i);
            string[] row = Console.ReadLine().Split(' ');

            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(row[j]);
            }
        }

        int sum = 0;
        int bestSum = 0;
        int[,] bestMatrix = new int[3, 3];

        for (int row = 0; row < n - 2; row++)
        {
            for (int col = 0; col < m - 2; col++)
            {
                sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] +
                      matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] +
                      matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if (sum > bestSum)
                {
                    bestSum = sum;

                    for (int i = 0; i < bestMatrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < bestMatrix.GetLength(1); j++)
                        {
                            bestMatrix[i, j] = matrix[row + i, col + j];
                        }
                    }
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("The best sum of matrix with size [3 x 3] in your matris is: Sum = {0} ", bestSum);
        Console.WriteLine();
        Console.WriteLine("Your best matrix looks like that: ");
        Console.WriteLine();

        for (int row = 0; row < bestMatrix.GetLength(0); row++)
        {
            Console.WriteLine();

            for (int col = 0; col < bestMatrix.GetLength(1); col++)
            {
                Console.Write("{0, 4}", bestMatrix[row, col]);
            }
        }

        Console.WriteLine();
    }
}