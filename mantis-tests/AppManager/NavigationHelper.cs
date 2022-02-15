using OpenQA.Selenium;

namespace mantis_tests
{
    public class NavigationHelper : HelperBase
    {
        public NavigationHelper(ApplicationManager manager) : base(manager) { }

        public void OpenProjectMenu()
        {
            // Вариант, который работает, но он не правильный, так как использует прямой путь.
            //driver.Navigate().GoToUrl("http://localhost/mantisbt-2.25.2/manage_proj_page.php");

            //// Ручной вариант, как должен компьютер найти кнопку и нажать на нее.
            //driver.FindElement(By.XPath("//a[@href= '/mantisbt-2.25.2/manage_overview_page.php']")).Click();
            //driver.FindElement(By.XPath("//a[@href= '/mantisbt-2.25.2/manage_proj_page.php']")).Click();

            //// Запись путем рекордера. Аналогично не работает, как и 2 вариант.
            //driver.FindElement(By.XPath("//div[@id='sidebar']/ul/li[6]/a/span")).Click();
            //driver.FindElement(By.XPath("//div[@id='sidebar']/ul/li[6]/a/i")).Click();

            driver.FindElement(By.CssSelector(".nav-list > li:nth-child(7) > a:nth-child(1) > span:nth-child(2)")).Click();
            driver.FindElement(By.CssSelector(".nav-tabs > li:nth-child(3) > a:nth-child(1)")).Click();
        }
    }
}