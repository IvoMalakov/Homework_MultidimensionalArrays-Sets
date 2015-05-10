using System;

public class FillTheMatrix
{
    public static void Main()
    {
        Console.SetBufferSize(400, 400);
        Console.WriteLine("Enter the size \"n\" of your matricies. Your matricies will have size n x n: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix1 = new int[n, n];
        int number = 1;

        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                matrix1[row, col] = number;
                number++;
            }
        }

        Console.WriteLine();
        Console.WriteLine("You first matrix looks like that: ");
        Console.WriteLine();

        for (int row = 0; row < n; row++)
        {
            Console.WriteLine();

            for (int col = 0; col < n; col++)
            {
                Console.Write("{0, 4} ", matrix1[row, col]);
            }
        }

        Console.WriteLine();

        int[,] matrix2 = new int[n, n];
        int maxNumber = n * n;
        int r = 0;
        int c = 0;
        string direction = "down";

        for (int i = 1; i <= maxNumber; i++)
        {
            if ((direction == "down") && (r > n - 1 || matrix2[r, c] != 0))
            {
                direction = "up";
                r--;
                c++;
            }

            else if ((direction == "up") && (r < 0 || matrix2[r, c] != 0))
            {
                direction = "down";
                r++;
                c++;
            }

            matrix2[r, c] = i;

            switch (direction)
            {
                case "up" :
                    r--;
                    break;

                case "down" :
                    r++;
                    break;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Your second matrix looks like that: ");
        Console.WriteLine();

        for (int row = 0; row < n; row++)
        {
            Console.WriteLine();

            for (int col = 0; col < n; col++)
            {
                Console.Write("{0, 4} ", matrix2[row, col]);
            }
        }

        Console.WriteLine();
    }
}