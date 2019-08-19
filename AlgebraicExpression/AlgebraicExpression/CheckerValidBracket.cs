using System;
using System.Collections.Generic;
using System.Text;

namespace AlgebraicExpression
{
  /// <summary>
  /// This class is used to create a stack and to verify that are correctly location of brackets.
  /// </summary>
  public class CheckerValidBracket
  {
    public string expression;
    Stack<char> elementStack = new Stack<char>();
    StringBuilder bracketsString = new StringBuilder();

    /// <summary>
    /// Throw exception if the string is empty.
    /// </summary>
    /// <param name="expression"> initial expression </param>
    public CheckerValidBracket(string expression)
    {
      if (string.IsNullOrEmpty(expression))
      {
        throw new Exception();
      }
      this.expression = expression;
    }

    /// <summary>
    /// This method is used for getting only brackets with an algebraic expression.
    /// </summary>
    public string GetBrackets()
    {
      string brackets = "[({})]";
      for (int i = 0; i < expression.Length; i++)
      {
        for (int j = 0; j < brackets.Length; j++)
        {
          if (expression[i] == brackets[j])
          {
            bracketsString.Append(brackets[j]);
            break;
          }
        }
      }
      return bracketsString.ToString();
    }

    /// <summary>
    /// This method is used to check the correctness location of the brackets.
    /// </summary>
    /// <returns> return true if brackets placed rigth, false otherwise </returns>
    public bool CheckLocationOfBrackets()
    {
      GetBrackets();
      for (int i = 0; i < bracketsString.Length; i++)
      {
        if ((bracketsString[i] == '[') || (bracketsString[i] == '(') || (bracketsString[i] == '{'))
        {
          elementStack.Push(bracketsString[i]);
          continue;
        }
        if (elementStack.Count != 0)
        {
          if (((bracketsString[i] == ']') && (elementStack.Peek() == '[')) || ((bracketsString[i] == ')') && (elementStack.Peek() == '(')) || ((bracketsString[i] == '}') && (elementStack.Peek() == '{')))
          {
            elementStack.Pop();
            continue;
          }
          else
          {
            return false;
          }
        }
        return false;
      }
      if (elementStack.Count != 0)
      {
        return false;
      }
      return true;
    }
  }
}
