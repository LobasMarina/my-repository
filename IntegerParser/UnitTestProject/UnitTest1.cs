using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntegerParser;

namespace UnitTestProject
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestPositiveValue()
    {
      Assert.AreEqual(12345, new StringToIntConverter("12345").ConvertString());
    }

    [TestMethod]
    public void TestNegativeValue()
    {
      Assert.AreEqual(-12345, new StringToIntConverter("-12345").ConvertString());
    }
  }
}
