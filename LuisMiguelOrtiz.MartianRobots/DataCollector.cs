﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LuisMiguelOrtiz.MartianRobots.CLI
{
    public static class DataCollector
    {
        public const int MaxCoordinateValue = 50;
        public const int MaxCharsPerInstruction = 100;

        public static int Width { get; set; }
        public static int Height { get; set; }
        public static IList<Robot> Robots;

        internal static World Collect(string input)
        {
            input = input.Replace("\r\n", "\n");

            var inputs = input.Split('\n');
            ReadWorldSize(inputs);
            ReadRobots(inputs);

            return new World(Width, Height, Robots);
        }

        private static void ReadWorldSize(string[] inputs)
        {
            var worldSize = inputs[0].Split(' ');

            ValidateCoordinates(worldSize);

            Width = int.Parse(worldSize[0]);
            Height = int.Parse(worldSize[1]);
        }

        private static void ValidateCoordinates(string[] coordinates)
        {
            foreach (var coordinate in coordinates)
                if (IsCoordinate(coordinate) && int.Parse(coordinate) > MaxCoordinateValue)
                    throw new ExceededCoordinateException($"Coordinate {coordinate} is greater than {MaxCoordinateValue}.");
        }

        private static bool IsCoordinate(string coordinate)
        {
            if (int.TryParse(coordinate, out int value))
                return true;
            return false;
        }
        private static void ReadRobots(string[] inputs)
        {
            Robots = new List<Robot>();

            for (int i = 1; i < inputs.Length; i += 2)
            {
                var position = inputs[i].Split(' ');
                var commands = inputs[i + 1];

                ValidateCoordinates(position);
                Robots.Add(BuildNewRobot(position, commands));
            }
        }

        private static Robot BuildNewRobot(string[] position, string commands)
        {
            return new Robot()
            {
                Position = new Position()
                {
                    Coordinate = new Coordinate()
                    {
                        X = int.Parse(position[0]),
                        Y = int.Parse(position[1]),
                    },
                    Orientation = (Orientation)Enum.Parse(typeof(Orientation), position[2])
                },
                Commands = commands.ToString()
                    .Select(command => Command.Parse(command))
                    .ToList()
            };
        }
    }
}