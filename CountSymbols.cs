using System;
using System.Collections.Generic;

public class CountSymbols
{
    public static void Main()
    {
        Console.WriteLine("Enter your string: ");
        string input = Console.ReadLine();

        SortedDictionary<char, int> symbolHolder = new SortedDictionary<char, int>();

        foreach (char symbol in input)
        {
            if (symbolHolder.ContainsKey(symbol))
            {
                symbolHolder[symbol]++;
            }

            else
            {
                symbolHolder.Add(symbol, 1);
            }
        }

        foreach (var symbol in symbolHolder)
        {
            Console.WriteLine("{0}: {1} time/s ", symbol.Key, symbol.Value);
        }
    }
}