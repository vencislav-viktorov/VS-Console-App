using System;

namespace _02._Articles
{
    class Program
    {
        static void Main()
        {
            string[] articleProps = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            string title = articleProps[0];

            string content = articleProps[1];

            string author = articleProps[2];
            
            Article article = new Article(title, content, author);

            int comandCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < comandCount; i++)
            {
                string[] splitedInput = Console.ReadLine()
                    .Split(new string[] { ": "}, StringSplitOptions.RemoveEmptyEntries);

                string comand = splitedInput[0];

                if (comand == "Edit")
                {
                    string newContent = splitedInput[1];

                    article.Edit(newContent);
                }

                else if (comand == "ChangeAuthor")
                {
                    string newAuthor = splitedInput[1];

                    article.ChangeAuthor(newAuthor);
                }

                else if (comand == "Rename")
                {
                    string newTitle = splitedInput[1];

                    article.Rename(newTitle);
                }
            }
                Console.WriteLine(article);
        }
    }
}
