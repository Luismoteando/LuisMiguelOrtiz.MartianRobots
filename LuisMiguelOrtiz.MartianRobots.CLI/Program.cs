using LuisMiguelOrtiz.MartianRobots.Models;
using System;

namespace LuisMiguelOrtiz.MartianRobots.CLI
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                DataCollector.Collect(string.Join(" ", args));
            }
            catch (AggregateException exception)
            {
                foreach (var innerException in exception.InnerExceptions)
                    Console.WriteLine(innerException.Message);
            }

            var world = new World(DataCollector.Width,
                DataCollector.Height,
                DataCollector.Robots);

            world.ProcessRobots();
            world.PrintRobots();

            Console.ReadLine();
        }
    }
}
