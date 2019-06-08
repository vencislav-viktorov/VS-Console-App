namespace ShoppingSpree
{
    using System;

    public class Product
    {
        private string name;
        private decimal money;

        public Product(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
        }

        public string Name
        {
            get => this.name;

            set
            {
                if (string.IsNullOrWhiteSpace(value) || value == string.Empty)
                {
                    throw new ArgumentException($"{nameof(this.Name)} cannot be empty");
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get => this.money;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"{nameof(this.Money)} cannot be negative");
                }

                this.money = value;
            }
        }
    }
}