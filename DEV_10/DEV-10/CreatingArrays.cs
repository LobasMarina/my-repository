using System;

namespace DEV_10
{
  /// <summary>
  /// This class creates an array in a random way.
  /// </summary>
  class CreatingArrays
  {
    /// <summary>
    /// Method creates a random number of elements if a one-dimensional array and random fills an array.
    /// </summary>
    /// <returns> randomly created array </returns>
    public double[] CreateAndFill()
    {
      Random random = new Random();
      double[] createdArray = new double[random.Next(1, 15)];
      for (int i = 0; i < createdArray.Length; i++)
      {
        createdArray[i] = random.NextDouble();
      }
      return createdArray;
    }
  }
}
