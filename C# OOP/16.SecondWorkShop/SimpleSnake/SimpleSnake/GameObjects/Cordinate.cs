namespace SimpleSnake.GameObjects
{
    public class Cordinate
    {
        public Cordinate(int cordinateX, int cordinateY)
        {
            this.CordinateX = cordinateX;
            this.CordinateY = cordinateY;
        }

        public int CordinateX { get; set; }

        public int CordinateY { get; set; }
    }
}