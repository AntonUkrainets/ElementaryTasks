using System;
using System.Collections.Generic;
using System.Linq;
using FiguresSorting.Business.Models;
using FiguresSorting.ConsoleManagers;
using FiguresSorting.Core;
using Liba.Logger;
using Liba.Logger.Interfaces;

namespace FiguresSorting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var logPath = "application.log";

            ILogger logger = new AggregatedLogger(
                new FileLogger(logPath),
                new ConsoleLogger()
            );

            IConsoleManager consoleManager = new ConsoleManager();
            var environment = new AppEnvironment(logger, consoleManager);

            var figures = new List<Figure>();

            try
            {
                var figure = environment.Parse(args);
                figures.Add(figure);

                var extraFigures = environment.RequestExtraFigures();
                figures.AddRange(extraFigures);

                var sortedAreas = figures
                    .OrderByDescending(f => f.Area)
                    .ToList();

                sortedAreas.ForEach(f => consoleManager.WriteLine($"[{f.Name}]: {f.Area} cm"));
            }
            catch (Exception ex)
            {
                logger.LogInformation(ex.Message);
            }
        }
    }
}