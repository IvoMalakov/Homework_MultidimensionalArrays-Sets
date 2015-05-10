using System;
using System.Globalization;

public class SequenceInMatrix
{
    public static void Main()
    {
        Console.Write("Enter the number of the rows in your matrix: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of the coloms in your matrix: ");
        int m = int.Parse(Console.ReadLine());

        string[,] matrix = new string[n, m];

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.WriteLine("Enter the string on position row[{0}], col[{1}]: ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }

        int lenght = 1;
        int bestLength = 1;
        string equalString = String.Empty;
        string bestEqualString = String.Empty;

        for (int row = 0; row < n - 1; row++)
        {
            for (int col = 0; col < m - 1; col++)
            {
                if ((matrix[row, col].Equals(matrix[row, col + 1])) || (matrix[row, col].Equals(matrix[row + 1, col]))
                    || matrix[row, col].Equals(matrix[row + 1, col + 1]))
                {
                    equalString = matrix[row, col];
                    lenght++;

                    if (lenght > bestLength)
                    {
                        bestLength = lenght;
                        bestEqualString = equalString;
                    }
                }
            }
        }

        lenght = 1;
        equalString = String.Empty;

        for (int row = 0; row < n - 1; row++)
        {
            if (matrix[row, m - 1].Equals(matrix[row + 1, m - 1]))
            {
                equalString = matrix[row, m - 1];
                lenght++;

                if (lenght > bestLength)
                {
                    bestLength = lenght;
                    bestEqualString = equalString;
                }
            }
        }


        Console.WriteLine();
        Console.WriteLine("The best equal string in your matrix looks like that: ");
        Console.WriteLine();

        for (int i = 0; i < bestLength - 1; i++)
        {
            Console.Write("{0}, ", bestEqualString);
        }

        Console.WriteLine(bestEqualString);
    }
}