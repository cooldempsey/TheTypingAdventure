using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingAdventureProgram
{
    class MainProgram
    {
        public const int NUM_LEVELS = 3; // Total number of levels in the game

        private static int currLevel = 1; // Current level that the user is on; default is 1

        public static void Main(string[] args)
        {
            // Load any save data
            SaveFile.LoadFile();

            // Run main menu until user quits
            MainMenu();

            // Save any save data
            SaveFile.SaveFile();
        }

        public static void MainMenu()
        {
            int levelOpt = 0; // Level currently selected
            ConsoleKey pressedKey; // Key most recently pressed by user

            // Get level user input
            do
            {
                DisplayScreen.MainMenu(levelOpt);
                do
                {
                    pressedKey = Console.ReadKey(true).Key;
                } while (pressedKey != ConsoleKey.LeftArrow && pressedKey != ConsoleKey.RightArrow && pressedKey != ConsoleKey.Enter);

                if (pressedKey == ConsoleKey.LeftArrow)
                    levelOpt = levelOpt > 0 ? levelOpt - 1 : NUM_LEVELS - 1;
                else if (pressedKey == ConsoleKey.RightArrow)
                    levelOpt = (levelOpt + 1) % NUM_LEVELS;
            } while (pressedKey != ConsoleKey.Enter);

            // Send user to level
            switch (levelOpt)
            {
                case 0: if (Level1.RunLevel() && currLevel == 1) { currLevel++; }; break;
                case 1: if (Level2.RunLevel() && currLevel == 2) { currLevel++; }; break;
                case 2: if (Level3.RunLevel()) { DisplayScreen.GameCompletedScreen(); }; break;
            }
        }
    }
}
