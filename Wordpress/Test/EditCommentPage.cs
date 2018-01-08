using OpenQA.Selenium;

namespace Wordpress
{
  public class EditCommentPage
  {
    IWebDriver driver;
    IWebElement textForm;
    IWebElement updateButton;
    IWebElement moveToTrashButton;

    public EditCommentPage(IWebDriver driver)
    {
      this.driver = driver;
      textForm = driver.FindElement(By.XPath(@"//textarea"));
      updateButton = driver.FindElement(By.XPath(@"//input[@value='Update']"));
      moveToTrashButton = driver.FindElement(By.XPath(@"//a[@class='submitdelete deletion'][text()='Move to Trash']"));
    }

    public PostPage EditComment(string newTextOfComment)
    {
      textForm.Clear();
      textForm.SendKeys(newTextOfComment);
      updateButton.Click();
      return new PostPage(driver);
    }

    public PostPage DeleteComment()
    {
      moveToTrashButton.Click();
      return new PostPage(driver);
    }
  }
}
