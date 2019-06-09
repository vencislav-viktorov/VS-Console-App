namespace SimpleSnake.GameObjects.Foods
{
    public abstract class Food
    {
        protected Food(string symbol, int points, Cordinate cordinate)
        {
            this.Symbol = symbol;
            this.Points = points;
            this.Cordinate = cordinate;
        }

        public string Symbol { get; set; }

        public int Points { get; set; }

        public Cordinate Cordinate { get; set; }
    }
}