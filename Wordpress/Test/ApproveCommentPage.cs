using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Wordpress
{
  public class ApproveCommentPage
  {
    IWebDriver driver;

    public ApproveCommentPage(IWebDriver driver)
    {
      this.driver = driver;
    }

    public Dashboard ApproveComment(string author, string textComment)
    {
      Actions action = new Actions(driver);
      action.MoveToElement(driver.FindElement(By.XPath($@"//td[@class='author column-author']/strong[contains(text(),'{author}')]/../following::td[@class='comment column-comment']/p['{textComment}']"))).Perform();
      driver.FindElement(By.XPath($@"//td[@class='author column-author']/strong[contains(text(),'{author}')]/../following::td[@class='comment column-comment']/p['{textComment}']/../descendant::a[text()='Approve']")).Click();
      return new Dashboard(driver);
    }
  }
}
