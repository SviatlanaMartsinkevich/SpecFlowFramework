using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SpecFlowAutomation.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpecFlowAutomation.Pages
{
    public class HomePage : BasePage
    {
        private string URL => "https://specflow.org";
        private string mainMenuItemXpath => "//ul[@id='menu-main-navigation']/li/a";
        private string subMenuItemXpath => "//ul[@class='sub-menu']/li/a/span[@class='sub']/..";

        private static HomePage homePage;
        public static HomePage Instance => homePage ?? (homePage = new HomePage());

        public void OpenSpecFlowHomePage()
        {
            DriverManager.Instance().Navigate().GoToUrl(URL);
        }

        public void HoverMainMenuItem(string item)
        {
            var actions = new Actions(DriverManager.Instance());
            var menuItem = FindElements(By.XPath(mainMenuItemXpath)).First(x => x.Text.Equals(item));
            actions.MoveToElement(menuItem).Perform();
        }

        public void ClickSubMenuItem(string item)
        {
            var subMenuItem = FindElements(By.XPath(subMenuItemXpath)).First(x => x.Text.Equals(item));
            subMenuItem.Click();
        }
    }
}