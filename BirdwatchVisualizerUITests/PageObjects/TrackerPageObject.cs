using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirdwatchVisualizerUITests.PageObjects
{
   public class TrackerPageObject
    {
        public static string URL = "http://localhost:4200/tracker";

        public static By ChartContainer = By.ClassName("canvas-container");
    }
}
