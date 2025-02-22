using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TypingAdventureProgram
{
    static class FileStorer
    {
        public const string FILE_NAME = "saveFile.txt";

        public static void SaveFile()
        {
            try 
            {
                DeleteFile();
                using (StreamWriter writer = new StreamWriter(FILE_NAME))
                {
                    writer.WriteLine(MainProgram.currLevel);
                }
            }
            catch (Exception e)
            {

            }
        }

        public static void LoadFile()
        {
            try
            {
                using (StreamReader reader = new StreamReader(FILE_NAME))
                {
                    MainProgram.currLevel = int.Parse(reader.ReadLine());
                }
            }
            catch (Exception e)
            {

            }
        }

        public static void DeleteFile()
        {
            try
            {
                File.Delete(FILE_NAME);
            }
            catch (Exception e)
            {

            }
        }
    }
}
