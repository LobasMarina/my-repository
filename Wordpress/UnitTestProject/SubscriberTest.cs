using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Wordpress;

namespace UnitTestProject
{
  [TestFixture]
  public class SubscriberTest
  {
    IWebDriver driver;
    HomePage homePage;
    LogInPage logInPage;
    ProfilePage profilePage;

    [SetUp]
    public void Setup()
    {
      driver = new FirefoxDriver();
      driver.Navigate().GoToUrl("http://localhost:8080");
      homePage = new HomePage(driver);
      logInPage = homePage.LogInSite();
      logInPage.InputAccountData("Subscriber", "123456789");
      profilePage = logInPage.LogInAsSubscriber();
      homePage = profilePage.ReturnToHomePage();
    }

    [TearDown]
    public void Teardown()
    {
      driver.Quit();
    }

    [Test]
    public void TestPostComment()
    {
      PostPage postPage = homePage.MoveToPost("Contributor");
      postPage.WriteComment("TestPostComment");
      var result = driver.FindElements(By.XPath(@"//section[@class='comment-content comment'][last()]/p"));
      Assert.AreEqual("TestPostComment", result[result.Count-1].Text);
    }
  }
}
