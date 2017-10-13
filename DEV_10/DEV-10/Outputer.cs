using System;

namespace DEV_10
{
  /// <summary>
  /// Сlass for output arrays and calling methods.
  /// </summary>
  class Outputer
  {
    /// <summary>
    /// This method is used for output the one-dimensional array 
    /// with the number of decimal places after the decimal point.
    /// </summary>
    /// <param name="array"> one-dimensional array </param>
    public void Output(double[] array)
    {
      for (int i = 0; i < array.Length; i++)
      {
        Console.Write(String.Format("{0:f4}", array[i]) + " ");
      }
      Console.Write("\n");
    }

    /// <summary>
    /// Method of assigning variables to the results of the work of methods.
    /// </summary>
    /// <param name="multiArray"> multidimensional array of one-dimensional arrays </param>
    public void CallOfMethods(double[][] multiArray)
    {
      CreatingArrays create = new CreatingArrays();
      ActionsOnArrays action = new ActionsOnArrays();
      for (int i = 0; i < multiArray.Length; i++)
      {
        multiArray[i] = create.CreateAndFill();
        multiArray[i] = action.MergeSort(multiArray[i]);
        multiArray[i] = action.FindUniqueInOnedimensionalArray(multiArray[i]);
      }
      double[] array = action.MergeArrays(multiArray);
      array = action.MergeSort(array);
      array = action.SeekRepetitionOfElements(array);
      Output(array);
    }
  }
}
