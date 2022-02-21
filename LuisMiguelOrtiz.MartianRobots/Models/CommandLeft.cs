namespace LuisMiguelOrtiz.MartianRobots.Models
{
    internal class CommandLeft : Command
    {
        public override void Execute(Robot robot, World world)
        {
            robot.Position.Orientation.Rotate(90);
        }
    }
}