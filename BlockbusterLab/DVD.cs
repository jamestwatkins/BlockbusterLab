using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class DVD : Movie
    {
        public DVD(string title, int runTime, Genres category, List<string> scenes) : base(title, runTime, category, scenes) { }

        public override void Play()
        {
            int i = 0;
            foreach(string scene in Scenes)
            {
                i++;
                Console.WriteLine($"{i}. {scene}");
            }

            Console.WriteLine("Select the index of the scene you'd like to watch:");

            while (true)
            {
                string input = Console.ReadLine();

                int sceneNum = 0;

                bool isNum = int.TryParse(input, out sceneNum);

                if (isNum)
                {
                    try
                    {
                        Console.WriteLine(Scenes[sceneNum - 1]);
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Please choose a valid scene index:");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Please choose a valid scene index:");
                    continue;
                }

            }
        }
    }
}
