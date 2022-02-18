namespace LuisMiguelOrtiz.MartianRobots.CLI
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            DataCollector.Collect(string.Join(" ", args));
            var world = new World(DataCollector.Width,
                DataCollector.Height,
                DataCollector.Robots);
            world.ProcessRobots();
        }
    }
}
