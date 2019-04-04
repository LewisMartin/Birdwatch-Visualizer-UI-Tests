using BirdwatchVisualizerUITests.Attributes;
using BirdwatchVisualizerUITests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BirdwatchVisualizerUITests.Tests
{
    [TestFixture]
    public class BreakdownPageTestFixture : SeleniumTestFixtureBase
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
        public void WhenBreakdownPageLoads_YearDropDownMenuIsRendered([BrowserList] BrowserTypes browser)
        {
            Initialize(browser);

            WebDriver.Navigate().GoToUrl(BreakdownPageObject.URL);
            var controlBar = WebDriver.FindElement(BreakdownPageObject.ControlBar);
            var dropDown = controlBar.FindElement(By.TagName("mat-select"));

            Assert.IsNotNull(dropDown.Text);
            Assert.IsNotEmpty(dropDown.Text);
        }

        [Test]
        public void WhenBreakdownPageLoads_BreakdownStatsAreRendered([BrowserList] BrowserTypes browser)
        {
            Initialize(browser);

            WebDriver.Navigate().GoToUrl(BreakdownPageObject.URL);
            var controlBar = WebDriver.FindElement(BreakdownPageObject.BreakdownStatsContainer);

            Assert.IsTrue(controlBar.Text.ToLower().Contains("total birds") &&
                        controlBar.Text.ToLower().Contains("different species"));
        }

        [Test]
        public void WhenBreakdownPageLoads_ChartCanvasIsRendered([BrowserList] BrowserTypes browser)
        {
            Initialize(browser);

            WebDriver.Navigate().GoToUrl(BreakdownPageObject.URL);
            var controlBar = WebDriver.FindElement(BreakdownPageObject.ChartContainer);
            var chartCanvas = WebDriver.FindElement(By.TagName("canvas"));

            Assert.IsNotNull(chartCanvas);
        }
    }
}
