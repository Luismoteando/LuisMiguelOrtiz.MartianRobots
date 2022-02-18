using System;
using System.Collections.Generic;

namespace LuisMiguelOrtiz.MartianRobots
{
    public class Robot
    {
        public Position Position { get; set; }
        public List<Command> Commands { get; set; }

        public Robot()
        {
        }

        internal void Execute(World world)
        {
            throw new NotImplementedException();
        }
    }
}