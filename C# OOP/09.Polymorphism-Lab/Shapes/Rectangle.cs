namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Height
        {
            get => this.height;

            protected set => this.height = value;
        }

        public double Width
        {
            get => this.width;

            protected set => this.width = value;
        }

        public override double CalculateArea()
        {
            return this.Height * this.Width;
        }

        public override double CalculatePerimeter()
        {
            return this.Height * 2 + this.Width * 2;
        }

        public sealed override string Draw()
        {
            return base.Draw() + "Rectangle";
        }
    }
}