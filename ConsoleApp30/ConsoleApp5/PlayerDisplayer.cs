﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    static class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            if (string.IsNullOrWhiteSpace(player.Name))
            {
                Console.WriteLine("Player name is null, empty, or all white space");
            }
            else
            {
                Console.WriteLine(player.Name);
            }

            if (player.DaysSinceLastLogin.HasValue)
            {
                Console.WriteLine(player.DaysSinceLastLogin.Value);                
            }
            else
            {
                Console.WriteLine("No value for DaysSinceLastLogin");
            }

            if (player.DateOfBirth is null)
            {
                Console.WriteLine("No date of birth specified");
            }
            else
            {
                Console.WriteLine(player.DateOfBirth);
            }

            if (player.IsNew is null)
            {
                Console.WriteLine("Player new status is unknown");
            }
            else if (player.IsNew == true)
            {
                Console.WriteLine("Player is new to the game");
            }
            else
            {
                Console.WriteLine("Player is experienced");
            }
        }
    }
}
