using System;
using System.Collections.Generic;

namespace NumberRepeatsElements
{
  /// <summary>
  /// This class is used for detect the repeats in List<int> collection
  /// and output the number of repeats.
  /// </summary>
  public class CheckerRepeatsElements
  {
    List<int> collection;

    public CheckerRepeatsElements(List<int> collection)
    {
      this.collection = collection;
    }

    /// <summary>
    /// This method detects the repeats and write them down in variable count.
    /// </summary>
    /// <returns> the number of repeats in the collection </returns>
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
