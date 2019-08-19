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
      string[] dir = Directory.GetDirectories(path);
      foreach (string element in dir)
      {
        Console.Write(element + "\n");
      }
      foreach (FileInfo element in information)
      {
        Console.Write("Name of file: " + element.Name + "\nSize of file: " + element.Length + " bytes" + "\nDate of creation: " + element.CreationTime + "\n" + "\n");
      }
      return information;
    }

    /// <summary>
    /// This method is used for find the folders in the folder.
    /// </summary>
    /// <param name="path"> path to the folder </param>
    /// <returns> folders in the folder </returns>
    public string[] searchDirectories(string path)
    {
      string[] subdirectoryEntries = Directory.GetDirectories(path);
      return subdirectoryEntries;
    }

    /// <summary>
    /// Method is used for information about files up to the root directory, 
    /// if an access denied folder is encountered, the folder is ignored.
    /// </summary>
    /// <param name="path"> path to the folder </param>
    public void showInformation(string path)
    {
      GetInformation(path);
      string[] directory = searchDirectories(path);
      foreach (string subdirectory in directory)
      {
        try
        {
          GetInformation(subdirectory);
          searchDirectories(subdirectory);
        }
        catch (UnauthorizedAccessException)
        {
          continue;
        }
      }
    }
  }
}