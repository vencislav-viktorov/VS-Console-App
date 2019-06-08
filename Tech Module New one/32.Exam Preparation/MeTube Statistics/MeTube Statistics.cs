using System;
using System.Collections.Generic;
using System.Linq;

namespace MeTube_Statistics
{
    class Program
    {
        static void Main()
        {
            string line = Console.ReadLine();

            Dictionary<string, int[]> movies = new Dictionary<string, int[]>();

            while (line != "stats time")
            {
                if (line.Contains('-'))
                {
                    string[] tokens = line.Split('-');

                    string movieName = tokens[0];

                    int view = int.Parse(tokens[1]);

                    if (movies.ContainsKey(movieName))
                    {
                        movies[movieName][0] += view;
                    }

                    else
                    {
                        //movies[movieName] = new int[2];
                        movies.Add(movieName, new int[2]);
                        movies[movieName][0] += view;
                    }
                }

                else if (line.Contains(':'))
                {
                    string[] tokens = line.Split(':');

                    string likeOrUnlike = tokens[0];

                    string movieName = tokens[1];

                    if (movies.ContainsKey(movieName))
                    {
                        if (likeOrUnlike == "like")
                        {
                            movies[movieName][1]++;
                        }

                        else
                        {
                            movies[movieName][1]--;
                        }
                    }
                }

                line = Console.ReadLine();
            }

            string byLikesOrByViews = Console.ReadLine();

            if (byLikesOrByViews == "by likes")
            {
                foreach (var movie in movies.OrderByDescending(m => m.Value[1]))
                {
                    Console.WriteLine($"{movie.Key} - {movie.Value[0]} views - {movie.Value[1]} likes");
                }
            }

            else
            {
                foreach (var movie in movies.OrderByDescending(m => m.Value[0]))
                {
                    Console.WriteLine($"{movie.Key} - {movie.Value[0]} views - {movie.Value[1]} likes");
                }
            }
        }
    }
}
