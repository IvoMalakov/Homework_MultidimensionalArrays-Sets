using System;

public class MatrixShuffling
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

        Console.WriteLine();
        Console.WriteLine("Give your command: ");
        string command = Console.ReadLine();

        while (command != "END")
        {
            string[] commandToMatrix = command.Split(' ');

            if (commandToMatrix.Length == 5 && commandToMatrix[0] == "swap")
            {
                int x1 = int.Parse(commandToMatrix[1]);
                int y1 = int.Parse(commandToMatrix[2]);
                int x2 = int.Parse(commandToMatrix[3]);
                int y2 = int.Parse(commandToMatrix[4]);

                if ((x1 >= 0 && x1 < n) && (y1 >= 0 && y1 < m) && (x2 >= 0 && x2 < n) && (y2 >= 0 && y2 < m))
                {
                    var temp = matrix[x1, y1];
                    matrix[x1, y1] = matrix[x2, y2];
                    matrix[x2, y2] = temp;

                    Console.WriteLine("(After swapping {0} and {1}): ", matrix[x1, y1], matrix[x2, y2]);

                    for (int row = 0; row < n; row++)
                    {
                        Console.WriteLine();

                        for (int col = 0; col < m; col++)
                        {
                            Console.Write("{0, 2} ", matrix[row, col]);
                        }
                    }
                }

                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }

            else
            {
                Console.WriteLine("Invalid input!");
            }

            Console.WriteLine();
            Console.WriteLine("Give your command: ");
            command = Console.ReadLine();
        }
    }
}