namespace LuisMiguelOrtiz.MartianRobots.Models
{
    internal class CommandRight : Command
    {
        public override void Execute(Robot robot, World world)
        {
            robot.Position.Orientation.Rotate(-90);
        }
    }
}