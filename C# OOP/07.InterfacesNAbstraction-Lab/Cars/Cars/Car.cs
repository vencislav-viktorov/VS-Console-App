namespace Cars
{
    using System.Text;

    public abstract class Car : ICar
    {
        private string model;
        private string color;

        public Car(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }

        public string Model
        {
            get => this.model;

            protected set
            {
                this.model = value;
            }
        }

        public string Color
        {
            get => this.color;

            protected set
            {
                this.color = value;
            }
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        protected virtual string GetCarInfo()
        {
            return $"{this.Color} {this.GetType().Name} {this.model}";
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder
                .AppendLine(this.GetCarInfo())
                .AppendLine(this.Start())
                .Append(this.Stop());

            return stringBuilder.ToString();
        }
    }
}