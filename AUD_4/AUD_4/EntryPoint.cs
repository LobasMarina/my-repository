using System;

namespace AUD_4
{
  /// <summary>
  /// Entry point of program.
  /// </summary>
  class EntryPoint
  {
    static void Main(string[] args)
    {
      string path = "C:\\C#\\Lections";
      InformationAboutFiles file = new InformationAboutFiles();
      file.showInformation(path);
      Console.ReadKey();
    }
  }
}
