﻿using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new PlayerCharacter();
            player.Name = "";
            //player.DaysSinceLastLogin = 42;

            PlayerDisplayer.Write(player);

            Console.ReadLine();
        }
    }
}
