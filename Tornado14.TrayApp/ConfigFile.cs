using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Tornado14.TrayApp
{
  public class ConfigFile
  {
    public FileInfo File { get; set; }
    public bool IsNetworkConfigFile { get; set; }

    internal List<ProfileConfigItem> GetItems()
    {
      List<ProfileConfigItem> result = new List<ProfileConfigItem>();
      try
      {
        result = Utils.DeserializeParameter(File.FullName);
      } catch (Exception ex)
      {
        throw ex;
      }
      return result;
    }
  }
}
