using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Forum_Topics
{
    public class Forum_Topics
    {
        public static void Main()
        {
            var topicList = new Dictionary<string, HashSet<string>>();

            while (true)
            {
                var input = Console.ReadLine().
                    Split(", ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (input[0] == "filter")
                {
                    break;
                }

                var topic = input[0];

                if (!topicList.ContainsKey(topic))
                {
                    topicList[topic] = new HashSet<string>();
                }

                for (int i = 1; i < input.Length; i++)
                {
                    topicList[topic].Add(input[i]);
                }
            }

            var seqenceOfTags = Console.ReadLine().
                Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var item in topicList)
            {
                var hasContain = false;

                for (int i = 0; i < seqenceOfTags.Length; i++)
                {
                    if (item.Value.Contains(seqenceOfTags[i]))
                    {
                        hasContain = true;
                    }

                    else
                    {
                        hasContain = false;
                        break;
                    }
                }

                var topic = item.Key;

                var tags = item.Value;

                if (hasContain)
                {
                    Console.WriteLine($"{topic} | #{string.Join(", #", tags)}");
                }
            }
        }
    }
}
