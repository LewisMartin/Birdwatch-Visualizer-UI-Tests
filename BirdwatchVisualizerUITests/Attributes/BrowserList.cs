using NUnit.Framework;
using System.Collections.Generic;

namespace BirdwatchVisualizerUITests.Attributes
{
    public enum BrowserTypes
    {
        Firefox,
        Chrome,
        Edge,
        IE
    }

    // https://github.com/nunit/docs/wiki/Parameterized-Tests
    // https://github.com/nunit/docs/wiki/ValueSource-Attribute
    public class BrowserList : ValueSourceAttribute
    {
        private static IEnumerable<BrowserTypes> Browsers;

        public BrowserList() : base(typeof(BrowserList), "Browsers")
        {
            Browsers = new List<BrowserTypes>
            {
                BrowserTypes.Chrome,
                BrowserTypes.Firefox,
                BrowserTypes.Edge
            };
        }
    }
}
