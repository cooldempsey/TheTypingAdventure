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
        public bool isUnlocked{get; set;}

        public static bool RunLevel(string text, double time)
        {
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
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                Console.WriteLine(userInput);
                Console.WriteLine("Time left: " + (time - timer.Elapsed.TotalSeconds));   
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
            return true;// Run level 1
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
            return true;// Run level 2
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
            return true;// Run level 3
        }
    }
}
