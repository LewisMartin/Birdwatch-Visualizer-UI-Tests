using BirdwatchVisualizerUITests.Attributes;
using NUnit.Framework;

namespace BirdwatchVisualizerUITests.Tests
{
    [TestFixture]
    class OverviewPageTestFixture : SeleniumTestFixtureBase
    {
        public override void SetUp() { }

        public override void TearDown()
        {
            base.TearDown();
        }

        [Test]
        public void NavigateToHomePage([BrowserList] BrowserTypes browser)
        {
            Initialize(browser);

            WebDriver.Navigate().GoToUrl("http://localhost:4200");

            Assert.AreEqual(WebDriver.Title, "Birdwatch-Visualizer");
        }
    }
}
