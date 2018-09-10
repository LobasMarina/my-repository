using System;
using System.Collections.Generic;
using System.IO;

namespace FileWatcher
{
  class ChangeWatcher
  {
    private FileSystemWatcher fileSystemWatcher;
    private const string EnglishPath = "C:/ForMovingFiles/English/";
    private const string RussianPath = "C:/ForMovingFiles/Russian/";
    private const string DefaultPath = "C:/ForMovingFiles/Mixed/";

    private Dictionary<FileChecker.CheckResult, string> rules = new Dictionary<FileChecker.CheckResult, string>()
    {
      { FileChecker.CheckResult.English, EnglishPath },
      { FileChecker.CheckResult.Russian, RussianPath },
      { FileChecker.CheckResult.Mixed, DefaultPath }
    };

    public void WatchChanges(string path)
    {
      fileSystemWatcher = new FileSystemWatcher(path);
      fileSystemWatcher.EnableRaisingEvents = true;
      fileSystemWatcher.IncludeSubdirectories = true;
      Console.CancelKeyPress += Console_CancelKeyPress;
      fileSystemWatcher.Created += new FileSystemEventHandler(OnCreate);
      while (true)
      {
      }
    }

    public void OnCreate(object sender, FileSystemEventArgs args)
    {
      FileChecker fileChecker = new FileChecker();
      string path = args.FullPath;
      string nameWithExtension = GetFileNameWithExtension(path);
      FileInfo fileInfo = new FileInfo(path);
      DateTime creationTime = fileInfo.CreationTimeUtc;
      Console.WriteLine("File " + nameWithExtension + " " + creationTime + " was created.");
      string name = GetFileName(path);
      FileChecker.CheckResult checkResult = fileChecker.CheckName(name);
      if (checkResult == FileChecker.CheckResult.English)
      {
        Console.WriteLine("Rule of only english letters in file name was detected.");
        File.Move(path, EnglishPath + nameWithExtension);
        Console.WriteLine("Moving of " + nameWithExtension + " into " + EnglishPath + " was finished.\n");
      }
      else if (checkResult == FileChecker.CheckResult.Russian)
      {
        Console.WriteLine("Rule of only russian letters in file name was detected.");
        File.Move(path, RussianPath + nameWithExtension);
        Console.WriteLine("Moving of " + nameWithExtension + " into " + RussianPath + " was finished.\n");
      }
      else
      {
       Console.WriteLine("Rule wasn't found. Moving into default folder");
       File.Move(path, DefaultPath + nameWithExtension);
       Console.WriteLine("Moving of " + nameWithExtension + " into " + DefaultPath + " was finished.\n");
      }
    }

    private static void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs args)
    {
      args.Cancel = false;
    }

    public string GetFileName(string fullPath)
    {
      string name = GetFileNameWithExtension(fullPath);
      int indexOfLastPoint = name.LastIndexOf('.');
      return name.Substring(0, name.Length -(name.Length - indexOfLastPoint));
    }

    public string GetFileNameWithExtension(string fullPath)
    {
      int indexOfLastSlash = fullPath.LastIndexOf('\\');
      return fullPath.Substring(indexOfLastSlash + 1);
    }
  }
}
