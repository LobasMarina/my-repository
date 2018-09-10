using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatcher
{
  class FileChecker
  { 
    public enum CheckResult { English, Russian, Mixed };
    public CheckResult CheckName(string fileName)
    {
      char firstSymbol = char.ToLower(fileName[0]);
      if (firstSymbol >= 'a' && firstSymbol <= 'z')
      {
        return CheckForEnglish(fileName.Substring(1));
      }
      if (firstSymbol >= 'а' && firstSymbol <= 'я')
      {
        return CheckForRussian(fileName.Substring(1));
      }
      return CheckResult.Mixed;
    }

    public CheckResult CheckForEnglish(string fileName)
    {
      foreach(char symbol in fileName)
      {
        if (symbol == ' ')
        {
          continue;
        }
        if (symbol >= 'а' && symbol <= 'я')
        {
          return CheckResult.Mixed;
        }
      }
      return CheckResult.English;
    }

    public CheckResult CheckForRussian(string fileName)
    {
      foreach (char symbol in fileName)
      {
        if (symbol == ' ')
        {
          continue;
        }
        if (symbol >= 'a' && symbol <= 'z')
        {
          return CheckResult.Mixed;
        }
      }
      return CheckResult.Russian;
    }
  }
}
