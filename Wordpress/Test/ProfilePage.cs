using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace Wordpress
{
  public class ProfilePage
  {
    IWebDriver driver;

    public ProfilePage(IWebDriver driver)
    {
      this.driver = driver;
    }

    public HomePage ReturnToHomePage()
    {
      IWebElement testButton = driver.FindElement(By.XPath(@"//div[@id='wp-toolbar']/ul/li/a[text()='Test']"));
      MoveToElement(testButton);
      new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(By.XPath(@"//div[@class = 'ab-sub-wrapper']/ul/li/a[text()='Visit Site']")));
      driver.FindElement(By.XPath(@"//div[@class = 'ab-sub-wrapper']/ul/li/a[text()='Visit Site']")).Click();
      return new HomePage(driver);
    }

    private ProfilePage MoveToElement(IWebElement element)
    {
      Actions action = new Actions(driver);
      action.MoveToElement(element).Perform();
      return this;
    }
  }
}
