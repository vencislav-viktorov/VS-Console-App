using System;

namespace _02.Advertisement_Message
{
    public class Advertisement_Message
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Random rnd = new Random();

            Message ad = new Message();

            for (int i = 0; i < n; i++)
            {
                int pRandom = rnd.Next(ad.Phrases.Length);

                int eRandom = rnd.Next(ad.Events.Length);

                int aRandom = rnd.Next(ad.Author.Length);

                int cRandom = rnd.Next(ad.Cities.Length);

                Console.WriteLine($"{ad.Phrases[pRandom]} {ad.Events[eRandom]} {ad.Author[aRandom]} – {ad.Cities[cRandom]}.");
            }
        }
    }

    class Message
    {
        public string[] Phrases
        {
            get
            {
                return new string[] { "Excellent product.", "Such a great product.", "I always use that product.",
                    "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            }
        }

        public string[] Events
        {
            get
            {
                return new string[] { "Now I feel good.", "I have succeeded with this product.",
                    "Makes miracles.I am happy of the results!", "I cannot believe but now I feel awesome.",
                    "Try it yourself, I am very satisfied.", "I feel great!" };
            }
        }

        public string[] Author
        {
            get
            {
                return new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            }
        }

        public string[] Cities
        {
            get
            {
                return new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            }
        }
    }
}
