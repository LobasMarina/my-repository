using System;

namespace Test2._1
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      string line = Console.ReadLine();
      try
      {
        StringToIntConverter converter = new StringToIntConverter(line);
        Console.Write(converter.ConvertString());
      }
      catch (Exception ex)
      {
        Console.Write(ex.Message);
      }
    }
  }
}
