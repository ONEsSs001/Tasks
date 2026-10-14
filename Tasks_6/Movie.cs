using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks_6
{
    internal class Movie
    {

        public string Name;
        public string ReleaseDate;
        public string Genre;
        public int Runtime;

        public int[] Rates;

        double rate = 0;

        double time = 0;
        int hours = 0;
        
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Release Date: {ReleaseDate}, Genre: {Genre}, Runtime: {Runtime} Minutes");
        }

        public void ShowRate() 
        {
            foreach (var item in Rates)
            {
                rate += item;
            }

            rate = rate / Rates.Length;

            Console.WriteLine(rate);
        }
        
        public void FormatRuntime()
        {
            hours = Runtime / 60;
            time = Runtime % 60;

            Console.WriteLine($"{hours} Hours {time} Minutes");
   

        }

          
        

        


    }
}
