using System;
using System.Collections.Generic;

class Program
{
    static List<string> items = new List<string>();

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose option: add  remove  show  quit");
            var input = Console.ReadLine();

            if (input == null) continue;

            string option = input.Trim().ToLower();

            if (option == "quit") break;

            if (option == "add")
            {
                Console.WriteLine("Enter item to add:");
                var item = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(item)) continue;

                items.Add(item.Trim().ToUpper());
                Console.WriteLine("Item added.");
            }
            else if (option == "remove")
            {
                Console.WriteLine("Enter item to remove:");
                var item = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(item)) continue;

                bool removed = items.Remove(item.Trim().ToUpper());

                Console.WriteLine(removed ? "Item removed." : "Item not found.");
            }
            else if (option == "show")
            {
                Console.WriteLine("List Items:");
                foreach (var item in items)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Invalid command.");
            }
        }
    }
}