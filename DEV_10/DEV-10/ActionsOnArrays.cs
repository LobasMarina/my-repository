using System;
using System.Linq;

namespace DEV_10
{
  /// <summary>
  /// This class is used for manipulation of array.
  /// </summary>
  class ActionsOnArrays
  {
    /// <summary>
    /// This merge sort. Sorts an array in ascending order.
    /// </summary>
    /// <param name="array"> one-dimensional array will be sorted</param>
    /// <returns> sorted array in ascending order </returns>
    public double[] MergeSort(double[] array)
    {
      if (array.Length < 1)
        throw new ArgumentException();
      if (array.Length == 1)
        return array;
      int middle = array.Length / 2;
      double[] left = MergeSort(array.Take(middle).ToArray());
      double[] right = MergeSort(array.Skip(middle).ToArray());
      int length = left.Length + right.Length;
      int l = 0, r = 0;
      double[] arrayAfterSort = new double[length];
      for (int i = 0; i < length; i++)
      {
        if (r >= right.Length || l < left.Length && left[l] < right[r])
        {
          arrayAfterSort[i] = left[l];
          l++;
        }
        else
        {
          arrayAfterSort[i] = right[r];
          r++;
        }
      }
      return arrayAfterSort;
    }

    /// <summary>
    /// Method of comparing double numbers.
    /// </summary>
    /// <param name="x"> first number </param>
    /// <param name="y"> second number </param>
    /// <returns> true if x equals to y; false otherwise </returns>
    public bool CompareDouble(double x, double y)
    {
      double EPSILON = Math.Min(x, y) / 10e4;
      if (Math.Abs(x - y) < EPSILON)
      {
        return true;
      }
      return false;
    }

    /// <summary>
    /// This is a method of writing numbers to an array in a single instance.
    /// If the resulting array contains an element, then the addition doesn't occur.
    /// </summary>
    /// <param name="array"> comes already sorted array </param>
    /// <returns> array with elements in a single instance </returns>
    public double[] FindUniqueInOnedimensionalArray(double[] array)
    {
      int amountOfElements = 0;
      bool flag = true;
      double[] arrayOfUnique = new double[array.Length];
      for (int i = 0; i < array.Length; i++)
      {
        flag = true;
        for (int j = 0; j < amountOfElements; j++)
        {
          if (CompareDouble(array[i], arrayOfUnique[j]))
          {
            flag = false;
            break;
          }
        }
        if (flag)
        {
          arrayOfUnique[amountOfElements] += array[i];
          amountOfElements++;
        }
      }
      Array.Resize(ref arrayOfUnique, amountOfElements);
      return arrayOfUnique;
    }

    /// <summary>
    /// In this method, the aggregate of all one-dimensional
    /// arrays(multidimensional array) is merged into one array.
    /// </summary>
    /// <param name="multiArray"> a set of one-dimensional arrays(multidimensional array) </param>
    /// <returns> array consisting of arrays of a multidimensional array </returns>
    public double[] MergeArrays(double[][] multiArray)
    {
      int indexOfInsert = 0;
      int amount = 0;
      for (int i = 0; i < multiArray.Length; i++)
      {
        amount += multiArray[i].Length;
      }
      double[] arrayAfterMerge = new double[amount];
      for (int i = 0; i < multiArray.Length; i++)
      {
        for (int j = 0; j < multiArray[i].Length; j++)
        {
          arrayAfterMerge[indexOfInsert] = multiArray[i][j];
          indexOfInsert++;
        }
      }
      return arrayAfterMerge;
    }

    /// <summary>
    /// In this method elements are added to the resulting array, entering
    /// at least two one-dimensional arrays.
    /// </summary>
    /// <param name="array"> array consisting of arrays of a multidimensional array </param>
    /// <returns> array consisting only of elements entering into two one-dimensional arrays of a multidimensional array </returns>
    public double[] SeekRepetitionOfElements(double[] array)
    {
      bool flag = true;
      int indexOfInsert = 0;
      double[] resultArray = new double[array.Length / 2];
      for (int i = 0; i < array.Length - 1; i++)
      {
        flag = true;
        if (CompareDouble(array[i], array[i + 1]))
        {
          for (int j = 0; j < indexOfInsert; j++)
          {
            if (CompareDouble(array[i], resultArray[j]))
            {
              flag = false;
              break;
            }
          }
          if (flag)
          {
            resultArray[indexOfInsert] = array[i];
            indexOfInsert++;
          }
        }
      }
      Array.Resize(ref resultArray, indexOfInsert);
      return resultArray;
    }
  }
}
