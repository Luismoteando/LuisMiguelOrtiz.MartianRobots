using LuisMiguelOrtiz.MartianRobots.Models.Enums;
using System;

namespace LuisMiguelOrtiz.MartianRobots.Models
{
    public class Orientation
    {
        public CardinalPoint CardinalPoint { get; set; }

        public Orientation(string cardinalPoint)
        {
            CardinalPoint = (CardinalPoint)Enum.Parse(typeof(CardinalPoint), cardinalPoint);
        }

        public override string ToString()
        {
            return CardinalPoint.ToString();
        }

        public void Rotate(int degrees)
        {
            var result = (int)CardinalPoint + degrees;
            result = Normalize(result);

            CardinalPoint = (CardinalPoint)result;
        }

        private static int Normalize(int degrees)
        {
            while (degrees < 0) degrees += 360;
            while (degrees > 359) degrees -= 360;
            return degrees;
        }
    }
}