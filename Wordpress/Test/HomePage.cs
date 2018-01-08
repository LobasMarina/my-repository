using OpenQA.Selenium;

namespace Wordpress
{
  public class HomePage
  {
    IWebDriver driver;
    IWebElement logInButton;

    public HomePage(IWebDriver driver)
    {
      this.driver = driver;
      logInButton = driver.FindElement(By.XPath(@"//a[contains(@href, 'http://localhost:8080/wp-login.php')]"));
    }

    public LogInPage LogInSite()
    {
      logInButton.Click();
      return new LogInPage(driver);
    }

    public PostPage MoveToPost(string nameOfPost)
    {
      driver.FindElement(By.XPath($@"//article[contains(@id, 'post')]/header/h1/a[text()='{nameOfPost}']")).Click();
      return new PostPage(driver);
    }

    public EditPostPage MoveToEditPage(string titleOfPost)
    {
      IWebElement editButton = driver.FindElement(By.XPath($@"//h1[@class='entry-title']/a[text()='{titleOfPost}']/ancestor::header[@class='entry-header']/following::a[text()='Edit']"));
      editButton.Click();
      return new EditPostPage(driver);
    }
  }
}
