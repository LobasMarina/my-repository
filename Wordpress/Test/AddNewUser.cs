using OpenQA.Selenium;

namespace Wordpress
{
  /// <summary>
  /// This class is used for create new user through the administrator.
  /// </summary>
  public class AddNewUser
  {
    IWebDriver driver;
    IWebElement usernameForm;
    IWebElement emailForm;
    IWebElement passwordForm;
    IWebElement passwordFormConfirm;
    IWebElement choseRole;
    IWebElement addNewUserButton;

    public AddNewUser(IWebDriver driver)
    {
      this.driver = driver;
      usernameForm = driver.FindElement(By.XPath(@"//input[@id='user_login']"));
      emailForm = driver.FindElement(By.XPath(@"//input[@id='email']"));
      passwordForm = driver.FindElement(By.XPath(@"//input[@id='pass1']"));
      passwordFormConfirm = driver.FindElement(By.XPath(@"//input[@id='pass2']"));
      choseRole = driver.FindElement(By.XPath(@"//select[@id='role']"));
      addNewUserButton = driver.FindElement(By.XPath(@"//input[@id='createusersub']"));
    }

    /// <summary>
    /// This method is used for create user.
    /// </summary>
    /// <param name="username"> username new user </param>
    /// <param name="email"> email new user </param>
    /// <param name="password"> password new user </param>
    /// <param name="role"> choosing a role from a form </param>
    /// <returns> new page with all users </returns>
    public AllUsers CreateUser(string username, string email, string password, string role)
    {
      usernameForm.SendKeys(username);
      emailForm.SendKeys(email);
      passwordForm.SendKeys(password);
      passwordFormConfirm.SendKeys(password);
      choseRole.Click();
      IWebElement roleForChose = driver.FindElement(By.XPath($@"//option[@value='{role.ToLower()}']"));
      roleForChose.Click();
      addNewUserButton.Click();
      return new AllUsers(driver);
    }
  }
}
