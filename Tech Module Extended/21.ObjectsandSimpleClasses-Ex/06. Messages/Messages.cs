using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Messages
{
    public class User
    {
        public string Usser { get; set; }

        public List<Message> ReceivedMessages { get; set; }
    }

    public class Message
    {
        public string Content { get; set; }

        public string Sender { get; set; }
    }

    public class Messages
    {
        public static void Main()
        {
            var register = Console.ReadLine().Split(' ').ToList();

            var registered = new List<User>();

            var conversation = new List<Message>();

            while (register[0] != "exit")
            {
                var name = string.Empty;

                var sender = string.Empty;

                var receiver = string.Empty;

                var content = string.Empty;

                if (register[0] == "register")
                {
                    name = register[1];

                    var newUser = new User();
                    {
                        newUser.Usser = name;

                        newUser.ReceivedMessages = new List<Message>();
                    }

                    registered.Add(newUser);
                }

                else
                {
                    sender = register[0];

                    receiver = register[2];

                    content = string.Join(" ", register.Skip(3));

                    if (registered.ToDictionary(x => x.Usser, x => x.ReceivedMessages).ContainsKey(sender) &&
                        registered.ToDictionary(x => x.Usser, x => x.ReceivedMessages).ContainsKey(receiver))
                    {
                        var mesages = new Message();
                        {
                            mesages.Content = content;

                            mesages.Sender = sender;

                        }

                        conversation.Add(mesages);

                        registered.Where(u => u.Usser == receiver).First().ReceivedMessages.Add(mesages);
                    }
                }

                register = Console.ReadLine().Split(' ').ToList();
            }

            var conversationBetwin = Console.ReadLine().Split(' ').ToList();

            var first = conversationBetwin[0];

            var second = conversationBetwin[1];

            var mesageBoxFirst = new List<string>();

            var mesageBoxSecond = new List<string>();

            foreach (var name in registered)
            {
                foreach (var kvp in name.ReceivedMessages)
                {
                    if (kvp.Sender == first && name.Usser == second)
                    {
                        mesageBoxFirst.Add(kvp.Content);
                    }
                }
            }

            foreach (var name in registered)
            {
                foreach (var kvp in name.ReceivedMessages)
                {
                    if (kvp.Sender == second && name.Usser == first)
                    {
                        mesageBoxSecond.Add(kvp.Content);
                    }
                }
            }

            var isEmpty = true;

            var n = Math.Max(mesageBoxFirst.Count, mesageBoxSecond.Count);

            for (int i = 0; i < n; i++)
            {
                if (i < mesageBoxFirst.Count)
                {
                    Console.WriteLine($"{first}: {mesageBoxFirst[i]}");

                    isEmpty = false;
                }

                if (i < mesageBoxSecond.Count)
                {
                    Console.WriteLine($"{mesageBoxSecond[i]} :{second}");

                    isEmpty = false;
                }
            }

            if (isEmpty)
            {
                Console.WriteLine("No messages");
            }
        }
    }
}
