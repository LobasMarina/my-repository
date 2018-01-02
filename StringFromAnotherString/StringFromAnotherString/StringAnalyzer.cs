using System;
using System.Linq;

namespace StringFromAnotherString
{
  /// <summary>
  /// This class is used to check whether it is possible to create a string using the character of another string.
  /// </summary>
  public class StringAnalyzer
  {
    string firstString;
    string secondString;

    public StringAnalyzer(string firstString, string secondString)
    {
      this.firstString = firstString;
      this.secondString = secondString;
    }

    /// <summary>
    /// Check one string can be creating using symbols from another.
    /// </summary>
    /// <returns> true if possible create string using symbols from another string, false otherwise </returns>
    public bool CheckPossibleCreateStringUsingSymbolsFromAnother()
    {
      bool isPossible = false;
      foreach (char symbol in firstString)
      {
        if (secondString.Contains(symbol))
        {
          secondString = secondString.Remove(secondString.IndexOf(symbol), 0);
          isPossible = true;
        }
        else
        {
          isPossible = false;
          break;
        }
      }
      return isPossible;
    }
  }
}