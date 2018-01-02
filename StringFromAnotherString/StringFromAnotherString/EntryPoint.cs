using System;

namespace StringFromAnotherString
{
  /// <summary>
  /// Entry point of program.
  /// </summary>
  class EntryPoint
  {
    static void Main(string[] args)
    {
      string firstString = "string";
      string secondString = "substring";
      StringAnalyzer analyzer = new StringAnalyzer(firstString, secondString);
      Console.Write(analyzer.CheckPossibleCreateStringUsingSymbolsFromAnother());
    }
  }
}