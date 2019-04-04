using BirdwatchVisualizerUITests.Attributes;
using BirdwatchVisualizerUITests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BirdwatchVisualizerUITests.Tests
{
    [TestFixture]
    class OverviewPageTestFixture : SeleniumTestFixtureBase
    {
        public override void SetUp()
        {
            base.SetUp();
        }

        public override void TearDown()
        {
            base.TearDown();
        }

        [Test]
        public void WhenOverviewPageLoads_PageTitleIsCorrect([BrowserList] BrowserTypes browser)
        {
            Initialize(browser);

            WebDriver.Navigate().GoToUrl(OverviewPageObject.URL);

            Assert.AreEqual(WebDriver.Title, "Birdwatch-Visualizer");
        }

        [Test]
        public void WhenOverviewPageLoads_AllStatTilesAreRendered([BrowserList] BrowserTypes browser)
        {
            Initialize(browser);

            WebDriver.Navigate().GoToUrl(OverviewPageObject.URL);
            var statCardElements = WebDriver.FindElements(OverviewPageObject.StatisticsCards);

            Assert.AreEqual(statCardElements.Count, 6);
        }

        [Test]
        public void WhenOverviewPageLoads_YearCountStatExists([BrowserList] BrowserTypes browser)
        {
            Initialize(browser);

            WebDriver.Navigate().GoToUrl(OverviewPageObject.URL);
            var statCardContainer = WebDriver.FindElement(OverviewPageObject.StatisticsCardContainer);

            Assert.IsTrue(statCardContainer.Text.ToLower().Contains("years worth of data"));
        }

        [Test]
        public void WhenOverviewPageLoads_TotalSpeciesStatExists([BrowserList] BrowserTypes browser)
        {
            Initialize(browser);

            WebDriver.Navigate().GoToUrl(OverviewPageObject.URL);
            var statCardContainer = WebDriver.FindElement(OverviewPageObject.StatisticsCardContainer);
            
            Assert.IsTrue(statCardContainer.Text.ToLower().Contains("total species"));
        }

        [Test]
        public void WhenOverviewPageLoads_TopBirdsRecordedStatExists([BrowserList] BrowserTypes browser)
        {
            Initialize(browser);

            WebDriver.Navigate().GoToUrl(OverviewPageObject.URL);
            var statCardContainer = WebDriver.FindElement(OverviewPageObject.StatisticsCardContainer);

            Assert.IsTrue(statCardContainer.Text.ToLower().Contains("most birds recorded"));
        }

        [Test]
        public void WhenOverviewPageLoads_TopSpeciesStatExists([BrowserList] BrowserTypes browser)
        {
            Initialize(browser);

            WebDriver.Navigate().GoToUrl(OverviewPageObject.URL);
            var statCardContainer = WebDriver.FindElement(OverviewPageObject.StatisticsCardContainer);

            Assert.IsTrue(statCardContainer.Text.ToLower().Contains("most species recorded"));
        }

        [Test]
        public void WhenOverviewPageLoads_MostCommonBirdStatExists([BrowserList] BrowserTypes browser)
        {
            Initialize(browser);

            WebDriver.Navigate().GoToUrl(OverviewPageObject.URL);
            var statCardContainer = WebDriver.FindElement(OverviewPageObject.StatisticsCardContainer);

            Assert.IsTrue(statCardContainer.Text.ToLower().Contains("most common bird"));
        }

        [Test]
        public void WhenOverviewPageLoads_BirdCountDifferenceStatExists([BrowserList] BrowserTypes browser)
        {
            Initialize(browser);

            WebDriver.Navigate().GoToUrl(OverviewPageObject.URL);
            var statCardContainer = WebDriver.FindElement(OverviewPageObject.StatisticsCardContainer);

            Assert.IsTrue(statCardContainer.Text.ToLower().Contains("decrease since 1st")
                        || statCardContainer.Text.ToLower().Contains("increase since 1st"));
        }
    }
}
