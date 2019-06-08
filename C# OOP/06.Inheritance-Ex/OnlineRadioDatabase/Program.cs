namespace OnlineRadioDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var songs = new List<Song>();

            for (int i = 0; i < lines; i++)
            {
                try
                {
                    var tokens = Console.ReadLine()
                        .Split(';');
                    var length = tokens[2]
                        .Split(':');

                    if (length.Length != 2 ||
                        !int.TryParse((length[0]), out int minutes) ||
                        !int.TryParse((length[1]), out int seconds))
                    {
                        throw new ArgumentException("Invalid song length.");
                    }

                    songs.Add(new Song(
                        tokens[0],
                        tokens[1],
                        minutes,
                        seconds));
                    Console.WriteLine("Song added.");
                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            var totalLenthInSeconds = 
                songs.Select(s => s.Minutes).Sum() * 60 + 
                songs.Select(s => s.Seconds).Sum();
            var timespan = TimeSpan.FromSeconds(totalLenthInSeconds);

            Console.WriteLine($"Songs added: {songs.Count}");
            Console.WriteLine($"Playlist length: {timespan.Hours}h {timespan.Minutes}m {timespan.Seconds}s");
        }
    }
}