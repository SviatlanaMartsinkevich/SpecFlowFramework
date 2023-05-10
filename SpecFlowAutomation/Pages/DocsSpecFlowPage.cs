using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowAutomation.Pages
{
    public class DocsSpecFlowPage : BasePage
    {
        private string searchDocField = "rtd-search-form";
        private string searchInputPopupField = "search__outer__input";
        private string resultsField = "//div[@class = 'search__result__single']/div/a/div/span[@class='search__result__subheading']";
       
        private static DocsSpecFlowPage docsPage;
        public static DocsSpecFlowPage Instanse => docsPage ?? (docsPage = new DocsSpecFlowPage());

        public void ClickSearhDocksField()
        {
            var searchField = FindElement(By.Id(searchDocField));
            searchField.Click();    
        }

        public void EnterDataInSearchInputPopupField(string inputData)
        {
            var enterDataField = FindElement(By.ClassName(searchInputPopupField));
            enterDataField.SendKeys(inputData);
        }

        public void CLickResult(string inputData)
        {
            var result = FindElements(By.XPath(resultsField)).First(x => x.Text.Equals(inputData));
            result.Click();
        }
    }
}
