using System;

namespace DEV_9
{
  /// <summary>
  ///  Entrypoint to program.
  /// </summary>
  class EntryPoint
  {
    /// <summary>
    ///  This method is used for inicialize strings, create an object if the strings aren't empty 
    ///  and call the method to replace strings.
    /// </summary>
    /// <param name="args"> argument of method Main contains the path to the file </param>
    static void Main(string[] args)
    {
      string firstString = "hello";
      string secondString = "friend";
      {
        try
        {
          ReplaceInString replace = new ReplaceInString(firstString, secondString);
          string resultOfReplace = replace.ReplaceString();
          Console.Write(firstString + "\n" + secondString + "\n" + resultOfReplace);
        }
        catch (ArgumentException)
        {
          Console.Write("Empty string");
        }
        Console.ReadKey();
      }
    }
  }
}
