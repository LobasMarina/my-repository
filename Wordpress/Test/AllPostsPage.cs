using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace Wordpress
{
  public class AllPostsPage
  {
    IWebDriver driver;

    public AllPostsPage(IWebDriver driver)
    {
      this.driver = driver;
    }
  }
}
