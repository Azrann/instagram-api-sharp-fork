using System;
using System.Collections.Generic;
using OpenQA.Selenium.PhantomJS;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using PuppeteerSharp;
using PuppeteerSharp.Contrib;
using PuppeteerSharp.Contrib.Extensions;
using PuppeteerSharp.Contrib.PageObjects;
using PuppeteerSharp.Input;

namespace PhantomJs
{
    class Program
    {
        private static string cookies = "REPLACE_WITH_YOUR_VALUE";

        static async Task Main(string[] args)
        {
            // Still looking if this is doing anything or CPU is 100%
            await new BrowserFetcher().DownloadAsync(BrowserFetcher.DefaultRevision);
            var browser = await Puppeteer.LaunchAsync(new LaunchOptions
            {
                Headless = false
            });
            Page page = await browser.NewPageAsync();
            await page.AddCookies(cookies);
            var startPage = await page.GoToAsync<InstagramMainPage>("https://www.instagram.com/");
            Console.ReadKey();
        }
    }

    public class GoogleStartPage : PageObject
    {
        [Selector("input.gLFyf.gsfi")]
        public virtual Task<ElementHandle> SearchInput { get; }

        public async Task<GooGleSearchPage> Search(string text)
        {
            var input = await SearchInput;
            if (await input.IsHiddenAsync()) await Page.ClickAsync("input.gLFyf.gsfi");
            await input.TypeAsync(text);
            await input.PressAsync(Key.Enter);

            return await Page.WaitForNavigationAsync<GooGleSearchPage>();
        }
    }

    public class InstagramMainPage : PageObject
    {
        [Selector("input.gLFyf.gsfi")]
        public virtual Task<ElementHandle> SearchInput { get; }

        public async Task<GooGleSearchPage> Search(string text)
        {
            var input = await SearchInput;
            if (await input.IsHiddenAsync()) await Page.ClickAsync("input.gLFyf.gsfi");
            await input.TypeAsync(text);
            await input.PressAsync(Key.Enter);

            return await Page.WaitForNavigationAsync<GooGleSearchPage>();
        }
    }

    public class GooGleSearchPage : PageObject
    {
        [Selector("#search")]
        public virtual Task<ElementHandle> SearchResults { get; }
    }
}
