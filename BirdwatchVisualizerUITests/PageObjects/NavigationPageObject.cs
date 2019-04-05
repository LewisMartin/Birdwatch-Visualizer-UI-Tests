using OpenQA.Selenium;

namespace BirdwatchVisualizerUITests.PageObjects
{
    public class NavigationPageObject
    {
        public static string URL = "http://localhost:4200";

        public static By Hamburger = By.Id("hamburger");

        public static By BreakdownLink = By.ClassName("breakdown-link");

        public static By TrackerLink = By.ClassName("tracker-link");

        public static By OverviewLink = By.ClassName("app-title");
    }
}
