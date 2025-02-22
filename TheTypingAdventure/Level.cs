using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingAdventureProgram
{
    class Level
    {
        public bool isUnlocked{get;}
        public bool runLevel(string text, float time)
        {
            string userInput = "";
            Console.WriteLine(text);
            // Get user input
            while(userInput != text&&time>0)
            {
                userInput = Console.ReadLine();
                // Decrease time by seconds
                Console.WriteLine("Time left: " + time);
                Thread.sleep(1000);
                time--;
            }

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

        public bool runLevel(string text, float time)
        {
            // Run level 1
        }
    }

    class Level2 : Level
    {
        public Level2()
        {
            isUnlocked = false;
        }

        public bool runLevel(string text, float time)
        {
            // Run level 2
        }
    }

    class Level3 : Level
    {
        public Level3()
        {
            isUnlocked = false;
        }

        public bool runLevel(string text, float time)
        {
            // Run level 3
        }
    }
}