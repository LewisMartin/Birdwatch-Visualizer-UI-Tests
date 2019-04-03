﻿using BirdwatchVisualizerUITests.Attributes;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;

namespace BirdwatchVisualizerUITests.Tests
{
    public abstract class SeleniumTestFixtureBase
    {
        protected IWebDriver WebDriver;

        public void Initialize(BrowserTypes browser)
        {
            switch (browser)
            {
                case BrowserTypes.Firefox:
                    WebDriver = new ChromeDriver(@"D:\Tools\Selenium\ChromeDriver\chromedriver_win32\");
                    break;
                case BrowserTypes.Chrome:
                    WebDriver = new FirefoxDriver(@"D:\Tools\Selenium\FirefoxDriver\geckodriver-v0.24.0-win64");
                    break;
                case BrowserTypes.IE:
                    var options = new InternetExplorerOptions
                    {
                        IgnoreZoomLevel = true
                    };
                    WebDriver = new InternetExplorerDriver(@"D:\Tools\Selenium\IEDriver\IEDriverServer_x64_3.14.0", options);
                    break;
                default:
                    throw new NotSupportedException("Browser not supported.");
            }
        }

        [SetUp]
        public virtual void SetUp() { }

        [TearDown]
        public virtual void TearDown()
        {
            WebDriver.Close();
        }
    }
}
