using System;
using System.Collections.Generic;

public class NightLife
{
    public static void Main()
    {
            CheckInformation:
            Console.WriteLine("Enter your data in format city;venue;performer. To stop please enter \"END\": ");
            string command = Console.ReadLine();

            Dictionary<string, SortedDictionary<string, SortedSet<string>>> citys =
                new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();

            while (command != "END")
            {
                string[] information = command.Split(';');

                if (information.Length == 3)
                {
                    string city = information[0];
                    string venue = information[1];
                    string performer = information[2];

                    if (!citys.ContainsKey(city))
                    {
                        citys[city] = new SortedDictionary<string, SortedSet<string>>();
                    }

                    if (!citys[city].ContainsKey(venue))
                    {
                        citys[city][venue] = new SortedSet<string>();
                    }

                    citys[city][venue].Add(performer);

                    command = Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Wrong information! Check your information again! ");
                    Console.WriteLine();
                    goto CheckInformation;
                }
            }
        

        foreach (var city in citys)
        {
            Console.WriteLine(city.Key);

            foreach (var venue in city.Value)
            {
                Console.WriteLine("->{0}: {1}", venue.Key, String.Join(", ", venue.Value));
            }
        }
    }
}