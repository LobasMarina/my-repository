using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DEV_11
{
  /// <summary>
  /// This class is used for transliteration the string for cyrilic in latin and from latin into cyrilic.
  /// </summary>
  class Transliteration
  {
    public Dictionary<string, string> Dictionary { get; set; }
    public Transliteration(string path)
    {
      GetDictionary(path);
    }

    /// <summary>
    /// This method is used for read data from a file and create a dictionary with these data.
    /// </summary>
    /// <param name="path"> file path with data </param>
    /// <returns> ready dictionary, the key is a symbol that needs to be changed, the value is a symbol for which you need to change </returns>
    private Dictionary<string, string> GetDictionary(string path)
    {
      Dictionary = new Dictionary<string, string>();
      FileStream file = new FileStream(path, FileMode.Open);
      StreamReader reader = new StreamReader(file, Encoding.Default);
      while (!reader.EndOfStream)
      {
        string word = reader.ReadLine();
        string[] keyValue = word.Split('-');
        Dictionary.Add(keyValue[0], keyValue[1]);
      }
      return Dictionary;
    }

    /// <summary>
    /// Method for handling of special cases. First divide the string into words then
    /// compare each key in the dictionary with each word.
    /// </summary>
    /// <param name="line"> transmitted initial string which enter from the keyboard </param>
    /// <returns> translated string with special cases </returns>
    public string TransliterateSpecialCases(string line)
    {
      string[] words = line.Split(' ');
      foreach (KeyValuePair<string, string> pair in Dictionary)
      {
        for (int i = 0; i < words.Length; i++)
        {
          if (pair.Key == words[i][0].ToString() || pair.Key == words[i].Substring(words[i].Length - 2).ToString())
          {
            line = line.Replace(pair.Key, pair.Value);
          }
        }
      }
      return line;
    }

    /// <summary>
    /// Method is used to transliterate strings from one alphabet to another.
    /// </summary>
    /// <param name="line"> transmitted initial string which enter from the keyboard </param>
    /// <returns> translated string </returns>
    public string Transliterate(string line)
    {
      foreach (KeyValuePair<string, string> pair in Dictionary)
      {
        line = line.Replace(pair.Key, pair.Value);
        line = line.Replace(pair.Key.ToUpper(), pair.Value.ToUpper());
        line = line.Replace(pair.Key[0].ToString().ToUpper() + pair.Key.ToString().Substring(1),
                            pair.Value[0].ToString().ToUpper() + pair.Value.ToString().Substring(1));
      }
      return line;
    }
  }
}