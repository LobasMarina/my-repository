using System;
using System.Collections.Generic;

namespace NumberRepeatsElements
{
  class CheckerRepeatsElements
  {
    List<int> collection;

    public CheckerRepeatsElements(List<int> collection)
    {
      this.collection = collection;
    }
    
    public int SearchRepeatingElements()
    {
      int count = 0;
      int? buf = null;
      collection.Sort();
      for (int i = 0; i < collection.Count - 1; i++)
      {
        if (collection[i] == collection[i + 1])
        {
          if (collection[i] != buf)
          {
            count++;
            buf = collection[i];
          }
        }
      }
      return count;
    }
  }
}
