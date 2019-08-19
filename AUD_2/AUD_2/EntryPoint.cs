using System;
using System.Collections.Generic;

namespace AUD_2
{
  /// <summary>
  /// Entry point of program.
  /// </summary>
  class EntryPoint
  {
    /// <summary>
    /// For creating the strings and calling of method.
    /// </summary>
    /// <param name="args"> argument of method Main contains the path to the file </param>
    static void Main(string[] args)
    {
      string firstLine = "mur";
      string secondLine = "murmurik";
      SearchMaxSubstring search = new SearchMaxSubstring();
      List<string> result = search.SearchMaxCommonSubstring(firstLine, secondLine);
      foreach (string element in result)
        Console.Write(element);
      Console.ReadKey();
    }
  }
}
