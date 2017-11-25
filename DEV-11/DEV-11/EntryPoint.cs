using System;

namespace DEV_11
{
  /// <summary>
  /// Entry point of program.
  /// </summary>
  class EntryPoint
  {
    /// <summary>
    /// For create strings and calling methods. 
    /// </summary>
    /// <param name="args"> argument of method Main contains the path to the file </param>
    static void Main(string[] args)
    {
      string initialString = "ёжик";
      Transliteration kirLat = new Transliteration("C:\\C#\\my-repository\\DEV-11\\Kir-Lat.txt");
      Transliteration special = new Transliteration("C:\\C#\\my-repository\\DEV-11\\Special cases.txt");
      initialString = special.TransliterateSpecialCases(initialString);
      initialString = kirLat.Transliterate(initialString);
      Console.Write(initialString + "\n");
      initialString = "ezhik";
      Transliteration latKir = new Transliteration("C:\\C#\\my-repository\\DEV-11\\Lat-Kir.txt");
      initialString = latKir.Transliterate(initialString);
      Console.Write(initialString);
      Console.ReadKey();
    }
  }
}
