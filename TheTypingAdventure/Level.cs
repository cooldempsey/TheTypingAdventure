using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Threading.Tasks;

namespace TypingAdventureProgram
{
    abstract class Level
    {
        public const double TIME_BEFORE_PRINT = 0.3;

        public bool isUnlocked{get; set;}

        public static bool RunLevel(string text, double time)
        {
            double prevPrintTime = -TIME_BEFORE_PRINT; // Previous time a print has been made (starts at -TIME_BEFORE_PRINT to print right away on start)
            string userInput = ""; // User input so far
            ConsoleKeyInfo newKey; // Next key inputted by user
            Stopwatch timer = new Stopwatch(); // Timer to figure out when time is up

            // Start the timer
            timer.Start();

            // Get user input until they succeed or time runs out
            while (userInput != text && timer.Elapsed.TotalSeconds<=time)
            {
                if (Console.KeyAvailable)
                {
                    newKey = Console.ReadKey();
                    if (newKey.Key == ConsoleKey.Backspace && userInput.Length != 0)
                    {
                        userInput = userInput.Remove(userInput.Length - 1);
                        Console.Write(" ");
                        Console.CursorLeft--;
                    }
                    else if (MainProgram.ALLOWED_CHARS.Contains(newKey.KeyChar))
                        userInput += newKey.KeyChar;
                }
                // Decrease time by seconds
                if (timer.Elapsed.TotalSeconds > prevPrintTime + TIME_BEFORE_PRINT)
                {
                    prevPrintTime = timer.Elapsed.TotalSeconds;
                    DisplayScreen.Level(text, userInput, time - timer.Elapsed.TotalSeconds);
                }
            }

            // Display win or lose message
            if (userInput == text)
            {
                return true;
            }
            DisplayScreen.LoseScreen();
            return false;
        }
    }

    class Level1 : Level
    {
        public Level1()
        {
            isUnlocked = true;
        }

        public static bool RunLevel()
        {
            Random random = new Random();
            if (RunLevel(Level1Info.levels[random.Next(0, Level1Info.levels.Count)], 80))
            {
                DisplayScreen.WinScreen(1);
                return true;
            }
            DisplayScreen.LoseScreen();
            return false;
        }
    }

    class Level2 : Level
    {
        public Level2()
        {
            isUnlocked = false;
        }

        public static bool RunLevel()
        {
            Random random = new Random();
            if (RunLevel(Level2Info.levels[random.Next(0,Level2Info.levels.Count)], 10))
            {
                DisplayScreen.WinScreen(2);
                return true;
            }
            DisplayScreen.LoseScreen();
            return false;
        }
    }

    class Level3 : Level
    {
        public Level3()
        {
            isUnlocked = false;
        }

        public static bool RunLevel()
        {
            Random random = new Random();
            if (RunLevel(Level3Info.levels[random.Next(0,Level3Info.levels.Count)], 12))
            {
                DisplayScreen.WinScreen(3);
                return true;
            }
            DisplayScreen.LoseScreen();
            return false;
        }
    }
}
