using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BirdwatchVisualizerUITests.Tests
{
    [TestFixture]
    class OverviewPageTests
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            StartBrowser();
        }

        [Test]
        public void NavigateToHomePage()
        {
            driver.Navigate().GoToUrl("http://localhost:4200");

            Assert.AreEqual(driver.Title, "Birdwatch-Visualizer");
        }

        [TearDown]
        public void TearDown()
        {
            CloseBrowser();
        }

        private void StartBrowser()
        {
            driver = new ChromeDriver(@"D:\Tools\Selenium\ChromeDriver\chromedriver_win32\");
        }

        private void CloseBrowser()
        {
            driver.Close();
        }
    }
}
