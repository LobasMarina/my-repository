using OpenQA.Selenium;

namespace Wordpress
{
  public class PostPage
  {
    IWebDriver driver;
    public IWebElement CommentForm { get; set; }
    IWebElement postComment;

    public PostPage(IWebDriver driver)
    {
      this.driver = driver;
      CommentForm = driver.FindElement(By.XPath(@"//p[@class='comment-form-comment']/textarea"));
      postComment = driver.FindElement(By.XPath(@"//*[@class='form-submit']/*[@value='Post Comment']"));
    }

    public PostPage WriteComment(string text)
    {
      CommentForm.SendKeys(text);
      postComment.Click();
      return this;
    }

    public EditCommentPage MoveToEditComment()
    {
      IWebElement editButton = driver.FindElement(By.XPath(@"//a[@title='Edit comment']"));
      editButton.Click();
      return new EditCommentPage(driver);
    }
  }
}
