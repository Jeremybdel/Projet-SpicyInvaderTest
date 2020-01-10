using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_csvWriteRead
{
    class Program
    {
        static public int HighScore = 0;
        static void Main(string[] args)
        {

            while (true)
            {
                //Incrémentation du highscore
                for (int i = 0; i < 5; i++)
                {
                    IncremantationHighScore();
                }

                Console.ReadLine();
                
                WriteHighScrore();
                HighScore = 0;
            }
        }
        static void WriteHighScrore()
        {
            //écriture dans le csv
            string filePath = @"File.csv";
            File.AppendAllLines(filePath, GetUserInfo());


            List<string> dataFromRead = File.ReadAllText(filePath).Split('\r', '\n').ToList();
            foreach (var item in dataFromRead)
            {
                Console.Write(item + " ");

            }

        }

        static List<string> GetUserInfo()
        {
            List<string> Info = new List<string>();

            Info.Add(Convert.ToString(DateTime.Now));
            Info.Add(Console.ReadLine()); //Pour le username
            Info.Add(Convert.ToString(HighScore));

            return Info;

        }

        static int IncremantationHighScore()
        {
            return HighScore = HighScore + 10;
        }


    }

class Test
    {
        public static void Mainly()
        {
            string path = @"c:\temp\MyTest.txt";

            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                string[] createText = { "Hello", "And", "Welcome" };
                File.WriteAllLines(path, createText, Encoding.UTF8);
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            string appendText = "This is extra text" + Environment.NewLine;
            File.AppendAllText(path, appendText, Encoding.UTF8);

            // Open the file to read from.
            string[] readText = File.ReadAllLines(path, Encoding.UTF8);
            foreach (string s in readText)
            {
                Console.WriteLine(s);
            }
        }
    }

}
