using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Wordpress
{
  /// <summary>
  /// This class designed to remove users.
  /// </summary>
  public class AllUsers
  {
    IWebDriver driver;
    IWebElement usersButton;

    public AllUsers(IWebDriver driver)
    {
      this.driver = driver;
      usersButton = driver.FindElement(By.XPath(@"//div[text()='Users']"));
    }

    /// <summary>
    /// This method is used for to delete users.
    /// </summary>
    /// <param name="username"> username whose user you want to delete </param>
    /// <returns> new confirmation page </returns>
    public ConfirmDeletionPage DeleteUser(string username)
    {
      usersButton.Click();
      IWebElement deleteButton = driver.FindElement(By.XPath($@"//tr[contains(@id,'user')]/descendant::a[text()='{username}']/following::a[@class='submitdelete']"));
      new Actions(driver).MoveToElement(deleteButton).Click().Perform();
      return new ConfirmDeletionPage(driver);
    }
  }
}
