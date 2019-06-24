using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Linq;


namespace Core
{
    public class SearchGoogleForAvatar
    {
        public void SearchAvartar()
        {
            ChromeDriver chromeDriver = new ChromeDriver(@"C:\Users\mingx\source\Repos\scraping\Core\bin\Debug\netcoreapp2.1\");
            chromeDriver.Url = "https://www.google.com/";
            chromeDriver.Navigate();
            var input = chromeDriver.FindElementByName("q");
            input.SendKeys("hello");

            //var searchBtn = chromeDriver.FindElementByCssSelector("input[name=btnK]");
            var searchBtn = chromeDriver.FindElement(By.CssSelector("input[name=btnK]"));
            searchBtn.Click();

            var navBar = chromeDriver.FindElement(By.Id("hdtb-msb-vis"));
            var pickLink = navBar.FindElement(By.CssSelector("a"));
            pickLink.Click();

            var picContainer = chromeDriver.FindElement(By.Id("rg"));
            var imageElements = picContainer.FindElements(By.CssSelector("img"));
            List<string> urls = new List<string>();
            foreach (var el in imageElements)
            {
                urls.Add(el.GetAttribute("src"));
            }

            WebClient client = new WebClient();
            

            int i = 0;
            string baseFolder = AppContext.BaseDirectory;

            foreach (var url in urls)
            {
                i++;
                if (url.StartsWith("data:"))
                {

                }
                else
                {
                    //client.DownloadFileTaskAsync(url, $@"{baseFolder}\{i}.jpg");
                    var bytes = client.DownloadData(url);
                    System.IO.File.WriteAllBytes($@"{baseFolder}\{i}.jpg", bytes);

                }
            }
            

        }
    }
}
