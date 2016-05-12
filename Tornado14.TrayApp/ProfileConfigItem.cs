
using System.Collections.Generic;
namespace Tornado14.TrayApp
{
  public class ProfileConfigItem
  {
    public int key;
    public string group;
    public string displayName;
    public string app;
    public string parameter;
    public string workingDirectory;
    public string icon;
    public bool asAdministrator;
    public List<ProfileConfigItem> subItems;

    public override string ToString()
    {
      return string.Format("{0} ({1})", this.displayName, this.group);
    }

  }
}
