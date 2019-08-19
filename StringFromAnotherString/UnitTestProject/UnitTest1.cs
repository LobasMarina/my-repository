using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringFromAnotherString;

namespace UnitTestProject
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestEmptyStrings()
    {
      Assert.AreEqual(false, new StringAnalyzer("", "").CheckPossibleCreateStringUsingSymbolsFromAnother());
    }

    [TestMethod]
    public void TestSpaceInStrings()
    {
      Assert.AreEqual(true, new StringAnalyzer(" ", " ").CheckPossibleCreateStringUsingSymbolsFromAnother());
    }

    [TestMethod]
    public void TestWorkTrue()
    {
      Assert.AreEqual(true, new StringAnalyzer("cat", "cat").CheckPossibleCreateStringUsingSymbolsFromAnother());
    }

    [TestMethod]
    public void TestWorkFalse()
    {
      Assert.AreEqual(false, new StringAnalyzer("horse", "morse").CheckPossibleCreateStringUsingSymbolsFromAnother());
    }
  }
}
