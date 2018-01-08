using OpenQA.Selenium;

namespace Wordpress
{
  public class LogInPage
  {
    IWebDriver driver;
    IWebElement loginField;
    IWebElement passwordField;
    IWebElement buttonLogIn;

    public LogInPage(IWebDriver driver)
    {
      this.driver = driver;
      loginField = driver.FindElement(By.XPath(@"//input[1]"));
      passwordField = driver.FindElement(By.XPath(@"//input[contains(@id,'user_pass')]"));
      buttonLogIn = driver.FindElement(By.XPath(@"//input[@value='Log In']"));
    }

    public LogInPage InputAccountData(string login, string password)
    {
      loginField.SendKeys(login);
      passwordField.SendKeys(password);
      return this;
    }

    public Dashboard LogIn()
    {
      buttonLogIn.Click();
      return new Dashboard(driver);
    }

    public LogInPage LogInWithWrongData()
    {
      buttonLogIn.Click();
      return this;
    }

    public ProfilePage LogInAsSubscriber()
    {
      buttonLogIn.Click();
      return new ProfilePage(driver);
    }
  }
}
