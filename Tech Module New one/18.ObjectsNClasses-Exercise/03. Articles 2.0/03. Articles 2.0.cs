using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int articleCount = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < articleCount; i++)
            {
                string[] splitedInput = Console.ReadLine()
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                string title = splitedInput[0];

                string content = splitedInput[1];
                string author = splitedInput[2];

                Article article = new Article(title, content, author);

                articles.Add(article);
            }

            string orderBy = Console.ReadLine();

            if (orderBy == "title")
            {
                articles = articles.OrderBy(k => k.Tittle).ToList();
            }

            else if (orderBy == "content")
            {
                articles = articles.OrderBy(k => k.Content).ToList();
            }

            else if (orderBy == "author")
            {
                articles = articles.OrderBy(k => k.Author).ToList();
            }

            Console.WriteLine(string.Join(Environment.NewLine, articles));
        }
    }
}
