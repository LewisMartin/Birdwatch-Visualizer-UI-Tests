using BirdwatchVisualizerUITests.Attributes;
using BirdwatchVisualizerUITests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirdwatchVisualizerUITests.Tests
{
    [TestFixture]
    public class TrackerPageTestFixture : SeleniumTestFixtureBase
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
        public void WhenTrackerPageLoads_ChartCanvasIsRendered([BrowserList] BrowserTypes browser)
        {
            Initialize(browser);

            WebDriver.Navigate().GoToUrl(TrackerPageObject.URL);
            var chartCanvas = WebDriver.FindElement(By.TagName("canvas"));

            Assert.IsNotNull(chartCanvas);
        }
    }
}
