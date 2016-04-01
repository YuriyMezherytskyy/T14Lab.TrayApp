using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using Tornado14.Task;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Tornado14.TrayApp
{
  public class Utils
  {
    public static List<ProfileConfigItem> DeserializeParameter(string file)
    {
      XmlSerializer deserializer = new XmlSerializer(typeof(List<ProfileConfigItem>));
      TextReader textReader = new StreamReader(file);
      List<ProfileConfigItem> data;
      data = (List<ProfileConfigItem>)deserializer.Deserialize(textReader);
      textReader.Close();
      return data;
      // TODO: asfg
    }

    public static List<ChecklistItem> DeserializeChecklist(string file)
    {
      XmlSerializer deserializer = new XmlSerializer(typeof(List<ChecklistItem>));
      TextReader textReader = new StreamReader(file);
      List<ChecklistItem> data;
      data = (List<ChecklistItem>)deserializer.Deserialize(textReader);
      textReader.Close();
      return data;
      // TODO: asfg
    }


    public static Image GetIconFromProfileConfigItem(ProfileConfigItem configItem, DirectoryInfo iconsFolder)
    {
      Image result = null;
      if (configItem != null && !String.IsNullOrEmpty(configItem.icon)
          && iconsFolder != null && iconsFolder.Exists)
      {
        FileInfo iconFile = new FileInfo(Path.Combine(iconsFolder.FullName, configItem.icon));
        if (iconFile != null && iconFile.Exists)
        {
          result = Image.FromFile(Path.Combine(iconsFolder.FullName, configItem.icon));
        }
      }
      else
      {
        result = GetIconFromExeFile(configItem, result);
      }

      if (result == null)
      {
        result = GetDefaultAppIcon(iconsFolder);
      }

      return result;
    }

    private static Image GetIconFromExeFile(ProfileConfigItem configItem, Image result)
    {
      try
      {
        result = Icon.ExtractAssociatedIcon(configItem.app).ToBitmap();
      }
      catch (Exception ex)
      {
        Debug.Print(ex.Message);
      }

      return result;
    }

    public static Image GetDefaultAppIcon(DirectoryInfo iconsFolder)
    {
      return Image.FromFile(Path.Combine(iconsFolder.FullName, "_defaulticons\\stern.png"));
    }

    public static void GetIconForListView(DirectoryInfo iconsFolder, ProfileConfigItem configItem, ListViewItem item, ImageList iconList)
    {
      if (!String.IsNullOrEmpty(configItem.icon))
      {
        if (!iconList.Images.ContainsKey(configItem.icon))
        {
          FileInfo i1 = new FileInfo(Path.Combine(iconsFolder.FullName, configItem.icon));
          if (i1.Exists)
          {
            Image icon2 = Image.FromFile(Path.Combine(iconsFolder.FullName, configItem.icon));
            iconList.Images.Add(configItem.icon, icon2);
          }
          else
          {
            iconList.Images.Add(configItem.icon, Utils.GetDefaultAppIcon(iconsFolder));
          }
        }
        item.ImageKey = configItem.icon;
      }
      else
      {
        Image result = Icon.ExtractAssociatedIcon(configItem.app).ToBitmap();
        if (result == null)
        {
          if (!iconList.Images.ContainsKey("TRAYAPP_DefaultAppIcon"))
          {
            iconList.Images.Add("TRAYAPP_DefaultAppIcon", Utils.GetDefaultAppIcon(iconsFolder));
          }
          item.ImageKey = "TRAYAPP_DefaultAppIcon";
        }
        else
        {
          if (!iconList.Images.ContainsKey("TRAYAPP_" + configItem.app))
          {
            iconList.Images.Add("TRAYAPP_" + configItem.app, result);
          }
          item.ImageKey = "TRAYAPP_" + configItem.app;
        }
      }
    }


    public static void StartApp(ProfileConfigItem appConfig)
    {
      if (appConfig.displayName.StartsWith("-----") || appConfig.displayName == "startAll")
      {

      }
      else {
        try
        {
          ProcessStartInfo pi = new ProcessStartInfo();
          FileInfo app = new FileInfo(appConfig.app);
          pi.FileName = appConfig.app;
          pi.WorkingDirectory = app.Directory.FullName;
          pi.Arguments = appConfig.parameter;
          if (appConfig.asAdministrator)
          {
            pi.Verb = "runas";
          }
          Process.Start(pi);
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message, "Can't start.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

  }

}
