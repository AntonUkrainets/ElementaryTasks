using System;
using System.Collections.Generic;
using FiguresSorting.Business.Figures;
using FiguresSorting.Business.Models;
using FiguresSorting.ConsoleManagers;
using FiguresSorting.Parser;
using Liba.Logger.Interfaces;

namespace FiguresSorting.Core
{
    public class AppEnvironment
    {
        #region Private Members

        private readonly TriangleParser triangleParser;

        private readonly ILogger logger;
        private readonly IConsoleManager consoleManager;

        #endregion

        public AppEnvironment(ILogger logger, IConsoleManager consoleManager)
        {
            this.logger = logger;
            this.consoleManager = consoleManager;

            triangleParser = new TriangleParser();
        }

        public Figure Parse(string[] args)
        {
            if (!triangleParser.CanParse(args))
                throw new ArgumentException("Input data must be in format <Name> <sideA> <sideB> <sideC>");

            var triangle = triangleParser.Parse(args);

            return triangle;
        }

        public Figure[] RequestExtraFigures()
        {
            var figures = new List<Figure>();

            while (AddNewTriangleRequired())
            {
                var inputString = consoleManager.ReadLine();

                var figure = GetTriangle(inputString);

                figures.Add(figure);
            }

            return figures.ToArray();
        }

        private Triangle GetTriangle(string inputString)
        {
            var digits = inputString.Split(' ');

            var triangle = (Triangle)Parse(digits);

            return triangle;
        }

        private bool AddNewTriangleRequired()
        {
            consoleManager.WriteLine("Add a new triangle?");
            var response = consoleManager.ReadLine();

            return CheckAddNewTriangle(response);
        }

        private bool CheckAddNewTriangle(string response)
        {
            return string.Equals(response, "yes", StringComparison.InvariantCultureIgnoreCase)
                || string.Equals(response, "y", StringComparison.InvariantCultureIgnoreCase);
        }
    }
}