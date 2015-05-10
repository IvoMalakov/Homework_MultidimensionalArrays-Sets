using System;
using System.Collections.Generic;

public class Phonebook
{
    public static void Main()
    {
        Console.WriteLine("Write your information! First the name of the person and second his");
        Console.WriteLine("phone number separated be \"-\" If you want to search in the phonebook");
        Console.WriteLine("please eneter the key word \"search\": ");
        Console.WriteLine();
        string information = Console.ReadLine();

        Dictionary<string, List<string>> phoneBook = new Dictionary<string, List<string>>();

        while (information != "search")
        {
            string[] tempPhoneBook = new string[2];
            tempPhoneBook = information.Split('-');

            if (!phoneBook.ContainsKey(tempPhoneBook[0]))
            {
                phoneBook[tempPhoneBook[0]] = new List<string>();
            }

            phoneBook[tempPhoneBook[0]].Add(tempPhoneBook[1]);

            information = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine("Enter a name to search in the phonebook: ");
        string nameToSearch = Console.ReadLine();

        while (!String.IsNullOrEmpty(nameToSearch))
        {
            if (phoneBook.ContainsKey(nameToSearch))
            {
                Console.WriteLine("{0} -> {1}", nameToSearch, string.Join(", ", phoneBook[nameToSearch]));
            }

            else
            {
                Console.WriteLine("Contact {0} does not exist", nameToSearch);
            }

            nameToSearch = Console.ReadLine();
        }
    }
}