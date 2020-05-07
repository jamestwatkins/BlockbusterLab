using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; } = 0;

       public VHS(string title, int runTime, Genres category, List<string> scenes) : base(title, runTime, category, scenes)
        {
            
        }

        public override void Play()
        {
            for (int i = CurrentTime; i < Scenes.Count; i++)
            {
                Console.WriteLine($"{i}. {Scenes[i]}");

                CurrentTime++;
            }

            Rewind();
        }

        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}
