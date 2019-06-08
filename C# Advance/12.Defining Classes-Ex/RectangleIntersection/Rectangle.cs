namespace DefiningClasses
{
    public class Rectangle
    {
        public Rectangle(string id, double width, double height, double horizontal, double vertical)
        {
            this.Id = id;
            this.Width = width;
            this.Height = height;
            this.Horizontal = horizontal;
            this.Vertical = vertical;
        }

        public double Vertical { get; set; }

        public double Horizontal { get; set; }

        public double Height { get; set; }

        public double Width { get; set; }

        public string Id { get; set; }

        public static string AreTwoRectanglesInteracting(Rectangle firstRectange, Rectangle secondRectangle)
        {
            if (firstRectange.Horizontal > secondRectangle.Horizontal + secondRectangle.Width
                || firstRectange.Vertical - firstRectange.Height > secondRectangle.Vertical
                || secondRectangle.Horizontal > firstRectange.Horizontal + firstRectange.Width
                || secondRectangle.Vertical - secondRectangle.Height > firstRectange.Vertical)
            {
                return "false";
            }

            return "true";
        }

    }
}