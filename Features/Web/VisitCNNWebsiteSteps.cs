using NUnit.Framework;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowDemo.Features.Web
{
    [Binding]
    public class VisitCNNWebsiteSteps
    {
        private BrowserOps browser = new BrowserOps();
       

        [Given(@"I open the '(.*)' in browser")]
        public void GivenIOpenTheInBrowser(string url)
        {
            browser.Init();
            browser.Goto(url);
        }
        
        [When(@"the browser redirects me to the webpage")]
        public void WhenTheBrowserRedirectsMeToTheWebpage()
        {
            StringAssert.Contains("cnn.com", browser.WebDriver.Url);
        }
        
        [Then(@"The webpage title contains '(.*)'")]
        public void ThenTheWebpageTitleContains(string expectedTitle)
        {
            StringAssert.Contains(expectedTitle, browser.WebDriver.Title.ToLower());
            Thread.Sleep(3000);
            browser.Close();
        }
    }
}
