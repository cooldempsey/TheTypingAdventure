﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingAdventureProgram
{
    class MainProgram
    {
        public const int NUM_LEVELS = 3; // Total number of levels in the game
        public const string ALLOWED_CHARS = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789~`!@#$%^&*()-_=+[{]}\\|;:'\",<.>/? "; // String containing all of the allowed characters for strings to have

        public static int currLevel = 1; // Current level that the user is on; default is 1

        public static void Main(string[] args)
        {
            // Load any save data
            FileStorer.LoadFile();

            // Display welcome screen
            DisplayScreen.WelcomeScreen();

            // Run main menu until user quits
            MainMenu();

            // Save any save data
            FileStorer.SaveFile();

            // Give quitting message
            DisplayScreen.GameQuit();
        }

        public static void MainMenu()
        {
            int levelOpt = 0; // Level currently selected
            ConsoleKey pressedKey; // Key most recently pressed by user

            // Run MainMenu until the user chooses to quit
            do
            {
                // Get level user input
                do
                {
                    DisplayScreen.MainMenu(levelOpt);
                    do
                    {
                        pressedKey = Console.ReadKey(true).Key;
                    } while (pressedKey != ConsoleKey.LeftArrow && pressedKey != ConsoleKey.RightArrow && pressedKey != ConsoleKey.Enter && pressedKey != ConsoleKey.Q);

                    if (pressedKey == ConsoleKey.LeftArrow)
                        levelOpt = levelOpt > 0 ? levelOpt - 1 : currLevel - 1;
                    else if (pressedKey == ConsoleKey.RightArrow)
                        levelOpt = (levelOpt + 1) % currLevel;
                } while (pressedKey != ConsoleKey.Enter && pressedKey != ConsoleKey.Q);

                // Send user to level
                if (pressedKey != ConsoleKey.Q)
                    switch (levelOpt)
                    {
                        case 0: if (Level1.RunLevel() && currLevel == 1) { currLevel++; }; break;
                        case 1: if (Level2.RunLevel() && currLevel == 2) { currLevel++; }; break;
                        case 2: if (Level3.RunLevel()) { DisplayScreen.GameCompletedScreen(); }; break;
                    }
            } while (pressedKey != ConsoleKey.Q);
        }
    }
}
