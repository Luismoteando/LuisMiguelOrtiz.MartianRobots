namespace LuisMiguelOrtiz.MartianRobots.Models
{
    public class Position
    {
        public Coordinate Coordinate { get; set; }
        public Orientation Orientation { get; set; }

        public Position()
        {
        }

        public override string ToString()
        {
            return Coordinate.ToString() + " " + Orientation.ToString();
        }
    }
}