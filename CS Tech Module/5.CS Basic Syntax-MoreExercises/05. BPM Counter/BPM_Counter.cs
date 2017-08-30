using System;

namespace _05.BPM_Counter
{
    public class BPM_Counter
    {
        public static void Main()
        {
            var bmp = double.Parse(Console.ReadLine());

            var beats = double.Parse(Console.ReadLine());

            double bars = Math.Round(beats / 4.0, 1);

            double bmbOnBeats = beats / bmp;

            double totalSeconds = bmbOnBeats * 60;

            int minutes = (int)totalSeconds / 60;

            int seconds = (int)totalSeconds % 60;

            Console.WriteLine($"{bars} bars - {minutes}m {seconds}s"); 
        }
    }
}