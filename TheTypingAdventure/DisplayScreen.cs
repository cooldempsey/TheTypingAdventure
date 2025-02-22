﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingAdventureProgram
{
    static class DisplayScreen
    {
        public static void MainMenu(int levelSelection)
        {
            newScreen();
            Console.WriteLine("Choose your level:");
            for (int i = 0; i < MainProgram.NUM_LEVELS; i++)
            {
                if (i == levelSelection)
                {
                    Console.Write(">");
                }
                Console.Write($"Level {i + 1}  ");
            }
        }

        public static void Level(string challengeText, string userText, double remainingTime)
        {
            newScreen();
            Console.WriteLine(challengeText + "\n");
            Console.WriteLine(userText);
            Console.WriteLine("Time left: " + remainingTime);
        }

        public static void LoseScreen()
        {

        }

        public static void WinScreen()
        {

        }

        public static void GameCompletedScreen()
        {

        }

        private static void PressKeyToContinue()
        {
            Console.Write("Press any key to continue . . .");
            Console.ReadKey(true);
        }

        private static void newScreen()
            => Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
    }
}
