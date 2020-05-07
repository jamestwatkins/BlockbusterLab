using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    public enum Genres { Drama, Comedy, Family, Romance, Action };

    abstract class Movie
    {


        private Genres genres;

        public Genres Category
        {
            get { return genres; }
            set { genres = value; }
        }

        public string Title { get; set; }
        public int Runtime { get; set; }
        public List<string> Scenes { get; set; }

        public Movie(string title, int runTime, Genres category, List<string> scenes)
        {
            Title = title;
            Runtime = runTime;
            Category = category;
            Scenes = scenes;
        }


        public virtual void PrintInfo()
        {
            Console.WriteLine($"Movie: {Title} \nRun Time: {Runtime} minutes \nGenre: {Category}");
        }

        public void PrintScenes()
        {
            int i = 0;
            foreach(string scene in Scenes)
            {
                i++;
                Console.WriteLine($"{i}. {scene}");
            }

        }

        public abstract void Play();


        
    }
}
