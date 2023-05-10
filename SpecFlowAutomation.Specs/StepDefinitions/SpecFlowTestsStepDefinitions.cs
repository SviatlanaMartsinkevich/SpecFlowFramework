using NUnit.Framework;
using SpecFlowAutomation.Base;
using SpecFlowAutomation.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowAutomation.Specs.StepDefinitions
{
    [Binding]
    public class SpecFlowTestsStepDefinitions
    {
        private readonly ScenarioContext scenarioContext;

        public SpecFlowTestsStepDefinitions(ScenarioContext injectedContext)
        {
            scenarioContext = injectedContext;
        }

        [Given(@"Open official SpecFlow web site")]
        public void OpenOfficialSpecFlowWebSite()
        {
            HomePage.Instance.OpenSpecFlowHomePage();
        }

        [When(@"Hover the '([^']*)' menu item from the main menu")]
        public void HoverTheMenuItemFromTheMainMenu(string menuItem)
        {
            Thread.Sleep(2000);
            HomePage.Instance.HoverMainMenuItem(menuItem);
        }

        [When(@"Click '([^']*)' option from the main menu")]
        public void ClickOptionFromTheMainMenu(string subMenuItem)
        {
            HomePage.Instance.ClickSubMenuItem(subMenuItem);
        }

        [When(@"Click on the ‘search docs’ field")]
        public void ClickOnTheSearchDocsField()
        {
            DocsSpecFlowPage.Instanse.ClickSearhDocksField();
        }

        [When(@"Enter the text '([^']*)' in the popup window")]
        public void EnterTheTextInThePopupWindow(string inputText)
        {
            DocsSpecFlowPage.Instanse.EnterDataInSearchInputPopupField(inputText);
        }

        [When(@"Select the '([^']*)' in result window")]
        public void SelectTheInResultWindow(string result)
        {
            Thread.Sleep(5000);
            DocsSpecFlowPage.Instanse.CLickResult(result);
        }

        [Then(@"Page with '([^']*)' title should be opened")]
        public void ThenPageWithTitleShouldBeOpened(string title)
        {
            InstallationPage.Instance.IsPageTitleDisplayed(title);
        }



        [AfterScenario]
        public static void AfterTestRun()
        {
            DriverManager.QuitDriver();
        }
    }
}
