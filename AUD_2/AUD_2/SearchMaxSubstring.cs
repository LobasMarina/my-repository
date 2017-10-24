using System.Collections.Generic;

namespace AUD_2
{
  /// <summary>
  /// This class is used to find the common substring of the maximum length in two string.
  /// </summary>
  class SearchMaxSubstring
  {
    /// <summary>
    /// Method is used to find the common substring of the maximum length in two string. 
    /// If there is a match, then the symbol is written into the result.
    /// </summary>
    /// <param name="firstLine"> first string which we introduce </param>
    /// <param name="secondLine"> second string which we introduce </param>
    /// <returns></returns>
    public List<string> SearchMaxCommonSubstring(string firstLine, string secondLine)
    {
      List<string> buffer = new List<string>();
      List<string> result = new List<string>();
      for (int i = 0; i < firstLine.Length; i++)
      {
        for (int j = 0; j < secondLine.Length; j++)
        {
          if (firstLine[i] == secondLine[j])
          {
            buffer.Add(firstLine[i].ToString());
            for (int step = 1; i + step < firstLine.Length && j + step < secondLine.Length; step++)
            {
              if (firstLine[i + step] != secondLine[j + step])
              {
                break;
              }
              buffer.Add(firstLine[i + step].ToString());
            }
            if (buffer.Count > result.Count)
            {
              result.RemoveRange(0, result.Count);
              result = new List<string>(buffer);
            }
            buffer.RemoveRange(0, buffer.Count);
          }
        }
      }
      return result;
    }
  }
}
