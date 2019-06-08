namespace Shapes
{
    using System.Text;

    public class Circle : IDrawable
    {
        private int radius;

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public int Radius
        {
            get => this.radius;

            private set
            {
                this.radius = value;
            }
        }

        public string Draw()
        {
            var stringBuilder = new StringBuilder();

            var rIn = this.Radius - 0.4;
            var rOut = this.Radius + 0.4;

            for (int y = this.Radius; y >= -this.Radius; y--)
            {
                for (double x = -this.Radius; x < rOut; x += 0.5)
                {
                    var value = x * x + y * y;

                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        stringBuilder.Append("*");
                    }

                    else
                    {
                        stringBuilder.Append(" ");
                    }
                }

                stringBuilder.AppendLine();
            }

            return stringBuilder.ToString();
        }
    }
}