using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComplexNumbers;

namespace Tests
{
  [TestClass]
  public class Tests
  {
    [TestMethod]
    public void TestAddition()
    {
      Assert.AreEqual("6+12i", (new ComplexNumber(4, 8) + new ComplexNumber(2, 4)).ToString());
    }

    [TestMethod]
    public void TestSubtraction()
    {
      Assert.AreEqual("2+4i", (new ComplexNumber(4, 8) - new ComplexNumber(2, 4)).ToString());
    }

    [TestMethod]
    public void TestMultiplication()
    {
      Assert.AreEqual("-24+32i", (new ComplexNumber(4, 8) * new ComplexNumber(2, 4)).ToString());
    }

    [TestMethod]
    public void TestDivision()
    {
      Assert.AreEqual("2+0i", (new ComplexNumber(4, 8) / new ComplexNumber(2, 4)).ToString());
    }
  }
}
