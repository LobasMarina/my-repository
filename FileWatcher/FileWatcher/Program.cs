using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileWatcher
{
  class Program
  {
    static void Main(string[] args)
    {
      string path = "C:/FileWatcher";
      ChangeWatcher watcher = new ChangeWatcher();
      watcher.WatchChanges(path);
    }
  }
}
