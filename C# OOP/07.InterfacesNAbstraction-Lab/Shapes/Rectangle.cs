namespace Shapes
{
    using System.Text;

    public class Rectangle : IDrawable
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width
        {
            get => this.width;

            private set
            {
                this.width = value;
            }
        }

        public int Height
        {
            get => this.height;

            private set
            {
                this.height = value;
            }
        }

        public string Draw()
        {
            var stringBuilder = new StringBuilder();

            DrawLine(this.Width, '*', '*', stringBuilder);

            for (int i = 1; i < this.Height - 1; ++i)
            {
                DrawLine(this.Width, '*', ' ', stringBuilder);
            }

            DrawLine(this.Width, '*', '*', stringBuilder);

            return stringBuilder.ToString();
        }

        private void DrawLine(
            int width, 
            char end, 
            char mid, 
            StringBuilder sb)
        {
            sb.Append(end);

            for (int i = 1; i < this.Width - 1; ++i)
            {
                sb.Append(mid);
            }

            sb.AppendLine(end.ToString());
        }
    }
}