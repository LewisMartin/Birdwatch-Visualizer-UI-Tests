using OpenQA.Selenium;

namespace BirdwatchVisualizerUITests.PageObjects
{
    public static class OverviewPageObject
    {
        public static string URL = "http://localhost:4200";

        public static By StatisticsCards = By.ClassName("stat-card");

        public static By StatisticsCardContainer = By.ClassName("stat-card-container");
    }
}
