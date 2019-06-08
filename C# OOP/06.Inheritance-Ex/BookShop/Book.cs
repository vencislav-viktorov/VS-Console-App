namespace BookShop
{
    using System;
    using System.Text;

    public class Book
    {
        private string author;
        private string title;
        private decimal price;

        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        public string Author
        {
            get => this.author;

            protected set
            {
                var indexOfSpace = value.IndexOf(' ');

                if (indexOfSpace > 0 &&
                    indexOfSpace < value.Length - 1 &&
                    char.IsDigit(value[indexOfSpace + 1]))
                {
                    throw new ArgumentException($"{nameof(this.Author)} not valid!");
                }

                this.author = value;
            }
        }

        public string Title
        {
            get => this.title;

            protected set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException($"{nameof(this.Title)} not valid!");
                }

                this.title = value;
            }
        }

        public virtual decimal Price
        {
            get => this.price;

            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Price)} not valid!");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
                .AppendLine($"{nameof(this.Title)}: {this.Title}")
                .AppendLine($"{nameof(this.Author)}: {this.Author}")
                .AppendLine($"{nameof(this.Price)}: {this.Price:f2}");

            var result = resultBuilder.ToString().TrimEnd();
            return result;
        }
    }
}