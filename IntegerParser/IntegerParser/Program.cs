using System;

namespace IntegerParser
{
  /// <summary>
  /// Entry point of program.
  /// </summary>
  class Program
  {
    /// <summary>
    /// Method calls method ConvertString of class StringToIntConverter
    /// for getting integer value from inputed from console string.
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
      string line = Console.ReadLine();
      try
      {
        StringToIntConverter converter = new StringToIntConverter(line);
        Console.Write(converter.ConvertString());
        Console.ReadKey();
      }
      catch (Exception ex)
      {
        Console.Write(ex.Message);
      }
    }
  }
}
