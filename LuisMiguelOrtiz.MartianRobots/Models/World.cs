using System;
using System.Collections.Generic;

namespace LuisMiguelOrtiz.MartianRobots.Models
{
    public class World
    {
        private int Width { get; }
        private int Height { get; }
        private readonly IList<Robot> Robots;
        public readonly IList<Robot> Scents;

        public World(int width, int height, IList<Robot> robots)
        {
            Width = width;
            Height = height;
            Robots = robots;
            Scents = new List<Robot>();
        }

        public void ProcessRobots()
        {
            foreach (var robot in Robots)
                robot.Move(this);
        }

        public bool IsWithin(Coordinate robotCoordinate)
        {
            int x = robotCoordinate.X,
                y = robotCoordinate.Y;

            return x <= Width && x >= 0 && y <= Height && y >= 0;
        }

        public void PrintRobots()
        {
            foreach (var robot in Robots)
                Console.WriteLine(robot.ToString());
        }
    }
}