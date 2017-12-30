using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgebraicExpression;

namespace Tests
{
  [TestClass]
  public class UnitTest
  {
    [TestMethod]
    public void TestExpressionWithDifferentBrackets()
    {
      Assert.AreEqual(true, new CheckerValidBracket("{[()]}").CheckLocationOfBrackets());
    }

    [TestMethod]
    public void TestAlgebraicExpression()
    {
      Assert.AreEqual(true, new CheckerValidBracket("[2+(4-3)]").CheckLocationOfBrackets());
    }

    [TestMethod]
    public void TestCorrectGetBrackets()
    {
      Assert.AreEqual("([]{})", new CheckerValidBracket("(7+3[9-5]+2{14-3})").GetBrackets());
    }

    [TestMethod]
    public void TestExpressionWithOneBracket()
    {
      Assert.AreEqual(false, new CheckerValidBracket("[").CheckLocationOfBrackets());
    }

    [TestMethod]
    public void TestExpressionWithWrongLocationBrackets()
    {
      Assert.AreEqual(false, new CheckerValidBracket("{[)])").CheckLocationOfBrackets());
    }
  }
}