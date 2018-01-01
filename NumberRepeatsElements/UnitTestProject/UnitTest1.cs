using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using NumberRepeatsElements;

namespace UnitTestProject
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestList()
    {
      Assert.AreEqual(4, new CheckerRepeatsElements(new List<int>() { 1, 2, 2, 3, 3, 3, 4, 5, 5, 5, 5, 6, 6 }).SearchRepeatingElements());
    }
    [TestMethod]
    public void TestEmptyList()
    {
      Assert.AreEqual(0, new CheckerRepeatsElements(new List<int>()).SearchRepeatingElements());
    }

    [TestMethod]
    public void TestOneElementList()
    {
      Assert.AreEqual(0, new CheckerRepeatsElements(new List<int>() { 3 }).SearchRepeatingElements());
    }
  }
}
