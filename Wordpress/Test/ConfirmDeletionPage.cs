using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Wordpress
{
  public class ConfirmDeletionPage
  {
    IWebDriver driver;

    public ConfirmDeletionPage(IWebDriver driver)
    {
      this.driver = driver;
    }

    public AllUsers ConfirmDeleteUser()
    {
      new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists(By.XPath(@"//input[@id='delete_option0']")));
      driver.FindElement(By.XPath(@"//input[@id='delete_option0']")).Click();
      driver.FindElement(By.XPath(@"//input[@value='Confirm Deletion']")).Click();
      return new AllUsers(driver);
    }
  }
}
