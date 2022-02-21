using System.Collections.Generic;

namespace LuisMiguelOrtiz.MartianRobots.Models
{
    public class Robot
    {
        private const string LostLiteral = " LOST";

        public Position Position { get; set; }
        public List<Command> Commands { get; set; }
        public bool Lost { get; set; }

        public Robot()
        {
        }

        public override string ToString()
        {
            return Position.ToString() + (Lost ? LostLiteral : string.Empty);
        }

        internal void Move(World world)
        {
            foreach (var command in Commands)
            {
                command.Execute(this, world);

                if (Lost)
                    break;
            }
        }
    }
}