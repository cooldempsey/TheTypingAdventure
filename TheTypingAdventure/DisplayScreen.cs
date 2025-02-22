using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingAdventureProgram
{
    static class DisplayScreen
    {
        public static void WelcomeScreen()
        {
            newScreen();
            Console.WriteLine("Welcome to The Typing Adventure!\n");
            Console.WriteLine("In this game, you will be given a challenge to type out a paragraph as fast as you can. You will be timed, and you will have to type out the sentence before the time runs out. If you succeed, you will move on to the next level. If you fail, you will have to try again.\n");
            Console.WriteLine("Good luck!\n");
            PressKeyToContinue();
        }

        public static void MainMenu(int levelSelection)
        {
            newScreen();
            Console.WriteLine("Press the left and right arrow keys to select a level, and press Enter to start the level. Press Q to quit the game.\n");
            Console.WriteLine("Choose your level:");
            for (int i = 0; i < MainProgram.NUM_LEVELS; i++)
            {
                if (i == levelSelection)
                {
                    Console.Write(">");
                }
                if (i > MainProgram.currLevel - 1)
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                else
                    Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write($"Level {i + 1}  ");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void Level(string challengeText, string userText, double remainingTime)
        {
            newScreen();
            Console.WriteLine(challengeText + "\n");
            Console.WriteLine("Time left: " + remainingTime + "\n");
            Console.Write(userText);
        }

        public static void LoseScreen()
        {
            newScreen();
            Console.WriteLine("You lost!");
            PressKeyToContinue();
        }

        public static void WinScreen(int level)
        {
            newScreen();
            Console.WriteLine($"You have completed level {level}!");
            PressKeyToContinue();
        }

        public static void GameCompletedScreen()
        {
            newScreen();
            Console.WriteLine("Congrats!! You have completed the game!");
            PressKeyToContinue();
        }

        public static void GameQuit()
        {
            newScreen();
            Console.WriteLine("Thank you for playing!");
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
