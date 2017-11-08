using System;
using System.IO;

namespace AUD_4
{
  /// <summary>
  /// This class is used for getting information about files in a folder.
  /// </summary>
  class InformationAboutFiles
  {
    /// <summary>
    /// In this method we find the path to the folder, the size of the files, the date the files were created.
    /// </summary>
    /// <param name="path"> path to the folder </param>
    /// <returns> information about each file in the folder </returns>
    public FileInfo[] GetInformation(string path)
    {
      FileInfo file = new FileInfo(path);
      Console.Write("The path to the folder: " + file.FullName + "\n");
      DirectoryInfo info = new DirectoryInfo(path);
      FileInfo[] information = info.GetFiles();
      foreach (FileInfo element in information)
      {
        Console.Write("Name of file: " + element.Name + "\nSize of file: " + element.Length + " bytes" + "\nDate of creation: " + element.CreationTime + "\n" + "\n");
      }
      return information;
    }
  }
}
