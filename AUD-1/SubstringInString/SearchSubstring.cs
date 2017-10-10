using System;
using System.Diagnostics;

namespace SubstringInString
{
  /// <summary>
  /// This class is used to create a string and substring, and also to find the substring in the string.
  /// </summary>
  class SearchSubstring
  {
    /// <summary>
    /// Creating a string randomly in which the substring will be searched.
    /// </summary>
    /// <returns> created string in which then search a substring </returns>
    public string CreateString()
    {
      string alphabet = "abcdefghijklmnopqrstuvwxyz";
      Random random = new Random();
      char[] letter = new char[1000];
      for (int i = 0; i < letter.Length; i++)
      {
        int randIndex = random.Next(alphabet.Length);
        letter[i] = alphabet[randIndex];
      }
      string text = new string(letter);
      return text;
    }

    /// <summary>
    ///  Сreating a substring from a string is randomly.
    /// </summary>
    /// <param name="text"> accepts the string from which will the substring is obtained </param>
    /// <returns> created substring which will search in the string</returns>
    public string CreateSubstring(string text)
    {
      char[] substringArray = new char[100];
      for (int i = 0; i < substringArray.Length; i++)
      {
        substringArray[i] = text[i];
      }
      string resultSubstring = new string(substringArray);
      return resultSubstring;
    }

    /// <summary>
    /// The method implements the prefix method of finding the substring.
    /// </summary>
    /// <param name="subline"> created substring that is checked for presence in a string </param>
    /// <param name="line"> created string in which the substring is searched for </param>
    /// <returns> true if the substring is contained in the string, false otherwise </returns>
    public bool FindSubstring(string subline, string line)
    {
      int[] result = new int[line.Length];
      result[0] = 0;
      int index = 0;

      for (int i = 1; i < line.Length; i++)
      {
        while (index >= 0 && line[index] != line[i])
        {
          index--;
        }
        index++;
        result[i] = index;
      }

      for (int i = 0; i < line.Length; i++)
      {
        while (index > 0 && subline[index] != line[i])
        {
          index = result[index - 1];
        }
        if (subline[index] == line[i])
          index++;
        if (index == subline.Length)
        {
          return true;
        }
      }
      return false;
    }

    /// <summary>
    /// This method is brute force, determines if there is a substring in the string.
    /// </summary>
    /// <param name="line"> created string in which the substring is searched for </param>
    /// <param name="subline"> created substring that is checked for presence in a string</param>
    /// <returns> true if the substring is contained in the string, false otherwise </returns>
    public bool LookForSubstring(string subline, string line)
    {
      int count = 0;
      for (int i = 0; i < line.Length; i++)
      {
        count = 0;
        if (line[i] == subline[0])
        {
          for (int j = 0; j < subline.Length; j++)
          {
            if (line[i + j] == subline[j])
            {
              count++;
            }
            if (count == subline.Length)
            {
              return true;
            }
          }
        }
      }
      return false;
    }

    /// <summary>
    /// Method output the information about working time and average time of execution of the sorting methods.
    /// </summary>
    /// <param name="watch"> variable to measure elapsed time </param>
    public void Output(Stopwatch watch)
    {
      int numberRepetition = 1000;
      Console.WriteLine("Working time: " + watch.Elapsed.TotalSeconds);
      Console.WriteLine("Average time: " + (watch.Elapsed.TotalSeconds / numberRepetition + "\n"));
    }
  }
}

