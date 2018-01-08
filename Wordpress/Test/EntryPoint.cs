using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Wordpress
{
  class EntryPoint
  {
    public static void Main()
    {
      IWebDriver driver = new FirefoxDriver();
      driver.Navigate().GoToUrl("http://localhost:8080");
      HomePage homePage = new HomePage(driver);
      var login = driver.FindElements(By.XPath(@"//a[contains(@href, 'http://localhost:8080/wp-login.php')]"));
      LogInPage loginPage = homePage.LogInSite();
      loginPage.InputAccountData("admin", "123456789");
      Dashboard dashboard = loginPage.LogIn();
    }
  }
}