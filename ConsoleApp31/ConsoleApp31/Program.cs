﻿using System;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter player = new();
            player.DaysSinceLastLogin = 42;

            int days = player?.DaysSinceLastLogin ?? -1;            

            Console.WriteLine(days);

            Console.ReadLine();
        }
    }
}
