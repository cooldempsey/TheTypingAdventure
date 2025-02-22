using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingAdventureProgram
{
    class Level
    {
        public bool isUnlocked{get; set;}
        public bool RunLevel(string text, double time)
        {
            string userInput = "";
            Console.WriteLine(text);
            Stopwatch timer = new Stopwatch();
            timer.Start();
            // Get user input
            while(userInput != text&&timer.Elapsed.TotalSeconds>time)
            {
                userInput = Console.ReadLine();
                // Decrease time by seconds
                Console.WriteLine("Time left: " +(time-timer.Elapsed.TotalSeconds));   
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

        public bool RunLevel()
        {
            Random random = new Random();
            return RunLevel(Level1Info.levels[random.Next(0,Level1Info.levels.Count)], 8);
        }
    }

    class Level2 : Level
    {
        public Level2()
        {
            isUnlocked = false;
        }

        public bool RunLevel()
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

        public bool RunLevel()
        {
            Random random = new Random();
            return RunLevel(Level3Info.levels[random.Next(0,Level3Info.levels.Count)], 12);
        }
    }
}
