using System;
using System.Linq;

namespace LuisMiguelOrtiz.MartianRobots.Models
{
    internal class CommandForward : Command
    {
        public override void Execute(Robot robot, World world)
        {
            var coordinate = CalculateNextPosition(robot);

            if (!world.IsWithin(coordinate))
            {
                if (IsScentPosition(world, coordinate))
                    return;

                world.Scents.Add(robot);
                robot.Lost = true;
                return;

            }

            robot.Position.Coordinate = coordinate;
        }

        private static Coordinate CalculateNextPosition(Robot robot)
        {
            var coordinate = new Coordinate(robot.Position.Coordinate);
            var orientation = (int)robot.Position.Orientation.CardinalPoint * Math.PI / 180;

            coordinate.X += (int)Math.Cos(orientation);
            coordinate.Y += (int)Math.Sin(orientation);

            return coordinate;
        }

        private static bool IsScentPosition(World world, Coordinate robotCoordinate)
        {
            return world.Scents.Any(scent =>
                    scent.Position.Coordinate.X == robotCoordinate.X &&
                    scent.Position.Coordinate.Y == robotCoordinate.Y);
        }
    }
}