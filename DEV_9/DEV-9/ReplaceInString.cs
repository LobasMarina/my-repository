using System;

namespace DEV_9
{
  /// <summary>
  /// This class consists of methods that randomly specify the position in the string and the length
  /// of the part of the string and are replaced at the random position of the second string.
  /// </summary>
  class ReplaceInString
  {
    public string firstString { get; set; }
    public string secondString { get; set; }
    Random rand = new Random();

    /// <summary>
    /// Exception if any of the strings is empty, field inicialization.
    /// </summary>
    /// <param name="firstString"> the string from which part is taken replacement </param>
    /// <param name="secondString"> the string in which the replacement is placed </param>
    public ReplaceInString(string firstString, string secondString)
    {
      if (firstString.Length == 0 || secondString.Length == 0)
      {
        throw new ArgumentNullException();
      }

      this.firstString = firstString;
      this.secondString = secondString;
    }

    /// <summary>
    /// This method is used for randomly there is a choice of indixes in two strings
    /// from the position of which we take the symbols for replacement.
    /// </summary>
    /// <param name="firstString"> the string from which part is taken replacement </param>
    /// <param name="secondString"> the string in which the replacement is placed </param>
    /// <returns> indexes from where the replacement takes place </returns>
    public int[] SearchIndexOfString(string firstString, string secondString)
    {
      int[] indexOfString = new int[2];
      indexOfString[0] = rand.Next(0, firstString.Length);
      indexOfString[1] = rand.Next(0, secondString.Length);
      return indexOfString;
    }

    /// <summary>
    /// This method is used for randomly obtaining the lengths of substrings
    /// in the first line and the string that is replaced.
    /// </summary>
    /// <param name="firstString"> the string from which part is taken replacement </param>
    /// <param name="secondString"> the string in which the replacement is placed </param>
    /// <param name="indexOfString"> indexes from where the replacement takes place </param>
    /// <returns> the length of the parts of the strings that we replace </returns>
    public int[] SearchLengthOfString(string firstString, string secondString, int[] indexOfString)
    {
      int[] LengthOfString = new int[2];
      LengthOfString[0] = rand.Next(1, firstString.Length - indexOfString[0]);
      LengthOfString[1] = rand.Next(1, secondString.Length - indexOfString[1]);
      return LengthOfString;
    }

    /// <summary>
    /// This method allows to replace a random sequence of characters
    /// in one string with a random sequence of characters in another string.
    /// </summary>
    /// <returns> replacement string </returns>
    public string ReplaceString()
    {
      int[] index = SearchIndexOfString(firstString, secondString);
      int[] length = SearchLengthOfString(firstString, secondString, index);
      string substring = firstString.Substring(index[0], length[0]);
      string resultString = secondString.Remove(index[1], length[1]);
      resultString = resultString.Insert(index[1], substring);
      return resultString;
    }
  }
}
