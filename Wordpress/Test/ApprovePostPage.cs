using OpenQA.Selenium;

namespace Wordpress
{
  /// <summary>
  /// This class for approve to confirm a written post.
  /// </summary>
  public class ApprovePostPage
  {
    IWebDriver driver;
    IWebElement publishButton;

    public ApprovePostPage(IWebDriver driver)
    {
      this.driver = driver;
      publishButton = driver.FindElement(By.XPath(@"//div[@id='publishing-action']/input[@name='publish']"));
    }

    public ApprovePostPage ApprovePost(string titleOfPost)
    {
      driver.FindElement(By.XPath($@"//span[text()='Pending']/preceding-sibling::a[text()='{titleOfPost}']")).Click();
      publishButton.Click();
      return this;
    }
  }
}
