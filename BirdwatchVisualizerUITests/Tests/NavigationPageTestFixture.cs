using BirdwatchVisualizerUITests.Attributes;
using BirdwatchVisualizerUITests.PageObjects;
using NUnit.Framework;

namespace BirdwatchVisualizerUITests.Tests
{
    [TestFixture]
    public class NavigationPageTestFixture : SeleniumTestFixtureBase
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
        public void WhenNavigationLoads_ItContainsLinkToOverviewPage([BrowserList] BrowserTypes browser)
        {
            Initialize(browser);

            WebDriver.Navigate().GoToUrl(NavigationPageObject.URL);
            WebDriver.FindElement(NavigationPageObject.Hamburger).Click();
            var link = WebDriver.FindElement(NavigationPageObject.OverviewLink);

            Assert.IsTrue(link.GetAttribute("routerLink") == "/");
        }

        [Test]
        public void WhenNavigationLoads_ItContainsLinkToBreakdownPage([BrowserList] BrowserTypes browser)
        {
            Initialize(browser);

            WebDriver.Navigate().GoToUrl(NavigationPageObject.URL);
            WebDriver.FindElement(NavigationPageObject.Hamburger).Click();
            var link = WebDriver.FindElement(NavigationPageObject.BreakdownLink);

            Assert.IsTrue(link.GetAttribute("routerLink") == "/breakdown");
        }

        [Test]
        public void WhenNavigationLoads_ItContainsLinkToTrackerPage([BrowserList] BrowserTypes browser)
        {
            Initialize(browser);

            WebDriver.Navigate().GoToUrl(NavigationPageObject.URL);
            WebDriver.FindElement(NavigationPageObject.Hamburger).Click();
            var link = WebDriver.FindElement(NavigationPageObject.TrackerLink);

            Assert.IsTrue(link.GetAttribute("routerLink") == "/tracker");
        }
    }
}
