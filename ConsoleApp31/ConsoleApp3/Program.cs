﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace GameConsole
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a name");
            string? name = Console.ReadLine();

            if (name is null)
            {
                LogAndExit("Null name was input");
            }

            Console.WriteLine(name.Length);

            Console.ReadLine();
        }

        static void ExitProgramIfNull([NotNull]string? input,
                                      string inputDescription)
        {
            if (input is null)
            {
                Console.WriteLine($"{inputDescription} was null, exiting program.");

                Console.ReadLine();

                Environment.Exit(-1);
            }
        }

        static T? FindFirst<T>(IEnumerable<T> items, Func<T, bool> predicate)
        {
            foreach (T item in items)
            {
                if (predicate(item))
                {
                    return item;
                }
            }
            return default;
        }

        static bool TryGetFirst<T>(IEnumerable<T> items,
                                   [MaybeNullWhen(false)] out T foundItem)
        {
            if (items.Any())
            {
                foundItem = items.First();
                return true;
            }

            foundItem = default;
            return false;
        }

        [return: NotNullIfNotNull("s")]
        static string? ConvertToUpperCase(string? s)
        {
            if (s is null)
            {
                return null;
            }

            return s.ToUpperInvariant();
        }

        [DoesNotReturn]
        static void LogAndExit(string logMessage)
        {
            // Log message

            Console.WriteLine(logMessage);

            Console.ReadLine(); // pause for demo purposes

            Environment.Exit(-1);
        }
    }
}
