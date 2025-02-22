using System;
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

            // Give time remaining
            Console.WriteLine("Time left: " + remainingTime + "\n");

            // Write challengeText with userText overtop of it. Put red characters starting at the first mistake
            (int left, int top) pos = Console.GetCursorPosition();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(challengeText);
            Console.SetCursorPosition(0, Console.WindowHeight - (challengeText.Length / Console.WindowWidth) - 1);
            Console.ForegroundColor = ConsoleColor.Gray;
            for (int i = 0; i < userText.Length; i++)
            {
                if (i > challengeText.Length - 1 || userText.ElementAt(i) != challengeText.ElementAt(i))
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(userText.ElementAt(i));
            }
            Console.ForegroundColor = ConsoleColor.Gray;
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
