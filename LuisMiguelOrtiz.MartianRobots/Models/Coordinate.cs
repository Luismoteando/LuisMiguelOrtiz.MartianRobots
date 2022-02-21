namespace LuisMiguelOrtiz.MartianRobots.Models
{
    public class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Coordinate(Coordinate coordinate)
        {
            X = coordinate.X;
            Y = coordinate.Y;
        }

        public override string ToString()
        {
            return X + " " + Y;
        }
    }
}