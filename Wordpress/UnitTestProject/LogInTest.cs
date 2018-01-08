using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Wordpress;

namespace UnitTestProject
{
  [TestFixture]
  public class LogInTest
  {
    IWebDriver driver;
    HomePage homePage;
    LogInPage logInPage;

    [SetUp]
    public void Setup()
    {
      driver = new FirefoxDriver();
      driver.Navigate().GoToUrl("http://localhost:8080");
      homePage = new HomePage(driver);
      logInPage = homePage.LogInSite();
    }

    [TearDown]
    public void Teardown()
    {
      driver.Quit();
    }

    [Test]
    public void TestLogIn()
    {
      logInPage.InputAccountData("admin", "123456789").LogIn();
      Assert.AreEqual(driver.Url, "http://localhost:8080/wp-admin/");
    }

    [Test]
    public void TestLogInWithWrongData()
    {
      logInPage.InputAccountData("adm", "12345").LogInWithWrongData();
      Assert.AreEqual(driver.Url, "http://localhost:8080/wp-login.php");
      Assert.AreEqual(driver.FindElements(By.XPath(@"//div[@id='login_error']/strong[text()='ERROR']")).Count, 1);
    }
  }
}
