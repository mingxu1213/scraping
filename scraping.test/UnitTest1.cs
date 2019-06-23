using System;
using Xunit;
using Core;
using System.Diagnostics;
using System.Linq;

namespace scraping.test
{
    public class UnitTest1
    {
        [Fact(DisplayName = "Test") ]
        public async void Test1()
        {
            PropertyScraper scraper = new PropertyScraper();
            var result = await scraper.RealE();
            //var storeInQLD = result.result.stores.Where(store => store.state.ToLower() == "qld");

            //var key = $"({result.success})";

            Debugger.Break();
        }
    }
}
