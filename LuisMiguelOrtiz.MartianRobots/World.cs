using System;
using System.Collections.Generic;

namespace LuisMiguelOrtiz.MartianRobots
{
    public class World
    {
        private readonly int Width;
        private readonly int Height;
        private readonly IList<Robot> Robots;

        public World(int width, int height, IList<Robot> robots)
        {
            Width = width;
            Height = height;
            Robots = robots;
        }

        public void ProcessRobots()
        {
            throw new NotImplementedException();
        }
    }
}