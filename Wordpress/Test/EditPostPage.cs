using OpenQA.Selenium;

namespace Wordpress
{
  public class EditPostPage
  {
    IWebDriver driver;
    IWebElement titleForm;
    IWebElement textForm;
    IWebElement updateButton;
    IWebElement deleteButton;

    public EditPostPage(IWebDriver driver)
    {
      this.driver = driver;
      titleForm = driver.FindElement(By.XPath(@"//input[@name='post_title']"));
      textForm = driver.FindElement(By.XPath(@"//body[@id='tinymce']/p"));
      updateButton = driver.FindElement(By.XPath(@"//input[@class='button button-primary button-large']"));
      deleteButton = driver.FindElement(By.XPath(@"//div[@id='delete-action']/a[@class='submitdelete deletion']"));
    }

    public EditPostPage EditPost(string newTitle, string newTextOfPost)
    {
      titleForm.Clear();
      titleForm.SendKeys(newTitle);
      driver.SwitchTo().Frame(driver.FindElement(By.XPath(@"//iframe[@id='content_ifr']")));
      textForm.Clear();
      textForm.Click();
      textForm.SendKeys(newTextOfPost);
      driver.SwitchTo().ParentFrame();
      updateButton.Click();
      return this;
    }

    public AllPostsPage DeletePost()
    {
      deleteButton.Click();
      return new AllPostsPage(driver);
    }
  }
}
