using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirdwatchVisualizerUITests.PageObjects
{
    public class BreakdownPageObject
    {
        public static string URL = "http://localhost:4200/breakdown";

        public static By ControlBar = By.ClassName("control-bar");

        public static By BreakdownStatsContainer = By.ClassName("breakdown-stats");

        public static By ChartContainer = By.ClassName("canvas-container");
    }
}
