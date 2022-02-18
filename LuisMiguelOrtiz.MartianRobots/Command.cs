namespace LuisMiguelOrtiz.MartianRobots
{
    public abstract class Command
    {
        public static Command Parse(char command)
        {
            switch (command)
            {
                case 'L':
                    return new CommandLeft();
                case 'R':
                    return new CommandRight();
                case 'F':
                    return new CommandForward();
                default:
                    throw new UnrecognizedCommandException("An unrecognized command has been entered as input.");
            }
        }
    }
}