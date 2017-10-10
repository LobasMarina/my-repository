using System;
using System.Diagnostics;

namespace SubstringInString
{
  /// <summary>
  /// Entrypoint to program.
  /// </summary>
  class EntryPoint
  {
    /// <summary>
   /// This method starts execution of the method several times 
   /// and outputs the result of the execution time to the screen.
   /// </summary>
   /// <param name="args"> contains pathes to the files </param>
    static void Main(string[] args)
    {
      int numberRepetition = 1000;
      SearchSubstring search = new SearchSubstring();
      string line = search.CreateString();
      string subline = search.CreateSubstring(line);
      bool bruteForce = search.LookForSubstring(subline, line);
      Stopwatch watch = new Stopwatch();
      watch.Start();
      for (int i = 0; i < numberRepetition; i++)
      {
        bruteForce = search.LookForSubstring(subline, line);
      }
      watch.Stop();
      Console.WriteLine("Brute force");
      Console.Write("Result: " + bruteForce + "\n");
      search.Output(watch);

      bool prefix = search.FindSubstring(line, subline);
      watch.Restart();
      for (int i = 0; i < numberRepetition; i++)
      {
        prefix = search.FindSubstring(subline, line);
      }
      watch.Stop();
      Console.WriteLine("Prefix");
      Console.Write("Result: " + prefix + "\n");
      search.Output(watch);
      Console.ReadKey();
    }
  }
}
