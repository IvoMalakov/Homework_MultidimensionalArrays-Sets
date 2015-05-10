using System;

public class CollectTheCoins
{
    public static void Main()
    {
        int numberOfRows = 4;
        char[][] board = new char[numberOfRows][];

        for (int i = 0; i < numberOfRows; i++)
        {
            Console.WriteLine("Enter the string in row [{0}] in your matrix: ", i);
            string rowLine = Console.ReadLine();
            int rowLength = rowLine.Length;
            board[i] = new char[rowLength];

            for (int col = 0; col < rowLength; col++)
            {
                board[i][col] = rowLine[col];
            }
        }

        int collectedCoins = 0;
        int wallHitted = 0;
        int cordinateRow = 0;
        int cordinateCol = 0;

        Console.WriteLine("Enter your commands: ");
        string commands = Console.ReadLine();

        foreach (char currentCommand in commands)
        {
            switch (currentCommand)
            {
                case 'V':
                    cordinateRow++;

                    if (cordinateRow >= numberOfRows)
                    {
                        cordinateRow--;
                        wallHitted++;
                        continue;
                    }

                    if (cordinateCol >= board[cordinateRow].Length)
                    {
                        cordinateRow--;
                        wallHitted++;
                        continue;
                    }
                    break;

                case '^':
                    cordinateRow--;

                    if (cordinateRow < 0)
                    {
                        cordinateRow++;
                        wallHitted++;
                        continue;
                    }

                    if (cordinateCol >= board[cordinateRow].Length)
                    {
                        cordinateRow++;
                        wallHitted++;
                        continue;
                    }
                    break;

                case '>':
                    cordinateCol++;

                    if (cordinateCol >= board[cordinateRow].Length)
                    {
                        cordinateCol--;
                        wallHitted++;
                        continue;
                    }
                    break;

                case '<':
                    cordinateCol--;

                    if (cordinateCol < 0)
                    {
                        cordinateCol++;
                        wallHitted++;
                        continue;
                    }
                    break;
            }

            if (board[cordinateRow][cordinateCol].Equals('$'))
            {
                collectedCoins++;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Coins collected: {0} ", collectedCoins);
        Console.WriteLine("Wall hit: {0} ", wallHitted);
    }
}