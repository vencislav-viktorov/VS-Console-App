using System;
using System.Collections.Generic;
using System.Text;

class Article
{
    public Article(string title, string content, string author)
    {
        this.Tittle = title;
        this.Content = content;
        this.Author = author;
    }

    public string Tittle { get; set; }

    public string Content { get; set; }

    public string Author { get; set; }

    public override string ToString()
    {
        return $"{Tittle} - {Content}: {Author}";
    }
}
