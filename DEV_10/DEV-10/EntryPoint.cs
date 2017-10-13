using System;

namespace DEV_10
{
  /// <summary>
  /// Entry point of program.
  /// </summary>
  class EntryPoint
  {
    /// <summary>
    /// For randomly creating the number of lines in a multidimensional array and calling of method.
    /// </summary>
    /// <param name="args"> argument of method Main contains the path to the file </param>
    static void Main(string[] args)
    {
      Random random = new Random();
      Outputer output = new Outputer();
      int numberOfLines = random.Next(1, 5);
      double[][] multiArray = new double[numberOfLines][];
      output.CallOfMethods(multiArray);
      Console.ReadKey();
    }
  }
}
