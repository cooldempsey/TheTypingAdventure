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
            double prevTime = -TIME_BEFORE_PRINT;
            string userInput = "";
            Console.WriteLine(text);
            Stopwatch timer = new Stopwatch();
            timer.Start();

            // Get user input
            while (userInput != text && timer.Elapsed.TotalSeconds<=time)
            {
                if (Console.KeyAvailable)
                {
                    userInput += Console.ReadKey().KeyChar;
                }
                // Decrease time by seconds
                if (timer.Elapsed.TotalSeconds > prevTime + TIME_BEFORE_PRINT)
                {
                    prevTime = timer.Elapsed.TotalSeconds;
                    DisplayScreen.Level(text, userInput, time - timer.Elapsed.TotalSeconds);
                }
            }

            // Display win or lose message

            if(userInput == text)
            {
                return true;
            }
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
            return RunLevel(Level1Info.levels[random.Next(0,Level1Info.levels.Count)], 80);
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
            return RunLevel(Level2Info.levels[random.Next(0,Level2Info.levels.Count)], 10);
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
            return RunLevel(Level3Info.levels[random.Next(0,Level3Info.levels.Count)], 12);
        }
    }
}
