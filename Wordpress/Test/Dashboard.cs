using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace Wordpress
{
  public class Dashboard
  {
    IWebDriver driver;
    IWebElement profileElement;
    IWebElement titleForm;
    IWebElement textForm;
    IWebElement publishButton;
    IWebElement commentsButton;
    IWebElement postButton;

    public Dashboard(IWebDriver driver)
    {
      this.driver = driver;
      profileElement = driver.FindElement(By.XPath(@"//a[@title='My Account']"));
      titleForm = driver.FindElement(By.XPath(@"//div[@id='title-wrap' and @class='input-text-wrap']"));
      textForm = driver.FindElement(By.XPath(@"//div[@class='textarea-wrap']/textarea"));
      publishButton = driver.FindElement(By.XPath(@"//input[@id='publish']"));
      commentsButton = driver.FindElement(By.XPath(@"//div[@class='wp-menu-name'][contains(text(),'Comments')]"));
      postButton = driver.FindElement(By.XPath(@"//div[text()='Posts']"));
    }

    private Dashboard MoveToElement(IWebElement element)
    {
      Actions action = new Actions(driver);
      action.MoveToElement(element).Perform();
      return this;
    }

    public LogInPage LogOut()
    {
      MoveToElement(profileElement);
      new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(By.XPath(@"//a[text()='Log Out']")));
      driver.FindElement(By.XPath(@"//a[text()='Log Out']")).Click();
      return new LogInPage(driver);
    }

    public HomePage ReturnToHomePage()
    {
      IWebElement testButton = driver.FindElement(By.XPath(@"//div[@id='wp-toolbar']/ul/li/a[text()='Test']"));
      MoveToElement(testButton);
      new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(By.XPath(@"//div[@class = 'ab-sub-wrapper']/ul/li/a[text()='Visit Site']")));
      driver.FindElement(By.XPath(@"//div[@class = 'ab-sub-wrapper']/ul/li/a[text()='Visit Site']")).Click();
      return new HomePage(driver);
    }

    public Dashboard CreatePost(string title, string text)
    {
      Actions action = new Actions(driver);
      action.SendKeys(titleForm, title);
      action.SendKeys(textForm, text);
      action.Perform();
      publishButton.Click();
      return this;
    }

    public ApprovePostPage MoveToApprovePost()
    {
      postButton.Click();
      return new ApprovePostPage(driver);
    }

    public ApproveCommentPage MoveToApproveComment(string author, string textComment)
    {
      commentsButton.Click();
      return new ApproveCommentPage(driver);
    }

    public AddNewUser MoveToCreateUserPage()
    {
      Actions action = new Actions(driver);
      IWebElement usersButton = driver.FindElement(By.XPath(@"//div[text()='Users']"));
      action.MoveToElement(usersButton).Perform();
      IWebElement addNewButton = driver.FindElement(By.XPath(@"//a[text()='Add New'][@href='user-new.php']"));
      new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists(By.XPath(@"//input[@id='user_login']")));
      action.MoveToElement(addNewButton).Click().Perform();
      return new AddNewUser(driver);
    }
  }
}