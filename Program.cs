using System;
using System.Collections.Generic;
namespace ClubManagementGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Club Manager!");
            Console.WriteLine("Your task is to manage your club and decide who gets in.");

            string[] guests = new string[] { "Alice", "Bob", "Charlie", "Diana" };
            string[] clubMembers = new string[10];

            int guestIndex = 0;

            foreach (var guest in guests)
            {
                Console.WriteLine($"Do you want to let {guest} in? (yes/no)");
                string input = Console.ReadLine().ToLower();

                if (input == "yes")
                {
                    clubMembers[guestIndex] = guest;
                    guestIndex++;
                    Console.WriteLine($"{guest} has been allowed into the club.");
                }
                else
                {
                    Console.WriteLine($"{guestfast} has been denied entry.");
                }
            }

            Console.WriteLine("\nThe following guests are in your club:");
            foreach (var member in clubMembers)
            {
                Console.WriteLine(member);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
