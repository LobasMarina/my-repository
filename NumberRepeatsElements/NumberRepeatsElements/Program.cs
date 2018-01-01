using System;
using System.Collections.Generic;

namespace NumberRepeatsElements
{
  class Program
  {
    static void Main(string[] args)
    {
      List<int> collection = new List<int>() { 1, 2, 2, 3, 3, 3, 4, 5, 5, 5, 5, 6, 6 };
      CheckerRepeatsElements repeat = new CheckerRepeatsElements(collection);
      Console.Write(repeat.SearchRepeatingElements());
    }
  }
}
