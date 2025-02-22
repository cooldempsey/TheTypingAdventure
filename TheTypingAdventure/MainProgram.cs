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

        private int currLevel = 1; // Current level that the user is on; default is 1

        public static void Main(string[] args)
        {
            // Load any save data

            // Run main menu until user quits
            MainMenu();

            // Save any save data
        }

        public static void MainMenu()
        {
            int levelOpt = 0; // Level currently selected
            ConsoleKey pressedKey; // Key most recently pressed by user

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
        }
    }
}
