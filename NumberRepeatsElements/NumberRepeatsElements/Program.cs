using System;
using System.Collections.Generic;

namespace NumberRepeatsElements
{
  /// <summary>
  /// Entry point of program.
  /// </summary>
  class Program
  {
    static void Main(string[] args)
    {
      List<int> collection = new List<int>() { 1, 2, 2, 3, 3, 3, 4, 5, 5, 5, 5, 6, 6 };
      CheckerRepeatsElements checker = new CheckerRepeatsElements(collection);
      Console.Write(checker.SearchRepeatingElements());
    }
  }
}
