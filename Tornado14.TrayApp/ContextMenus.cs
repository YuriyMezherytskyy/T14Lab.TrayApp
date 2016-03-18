using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using Tornado14.TrayApp.Properties;

namespace Tornado14.TrayApp
{

  public class SubMenuColorTable : ProfessionalColorTable
  {
    public override Color MenuItemBorder
    {
      get
      { return Settings.Default.subItemSelectedBackColor; }
    }
    public override Color MenuItemSelected
    {
      get { return Settings.Default.subItemSelectedBackColor; }
    }


    public override Color ToolStripDropDownBackground
    {
      get { return Settings.Default.subItemBackColor; }
    }
    public override Color ImageMarginGradientBegin
    {
      get { return Settings.Default.subItemBackColor; }
    }
    public override Color ImageMarginGradientMiddle
    {
      get { return Settings.Default.subItemBackColor; }
    }
    public override Color ImageMarginGradientEnd
    {
      get { return Settings.Default.subItemBackColor; }
    }

    public override Color SeparatorDark
    {
      get
      {
        return Settings.Default.SubItemBorderColor;
      }
    }
    public override Color SeparatorLight
    {
      get
      {
        return Settings.Default.SubItemBorderColor;
      }
    }

    public override Color MenuBorder
    {
      get
      {
        return Settings.Default.SubItemBorderColor;
      }
    }
  }
  public class MainColorTable : ProfessionalColorTable
  {
    public override Color MenuItemBorder
    {
      get
      { return Settings.Default.selectedBackColor; }
    }
    public override Color MenuItemSelected
    {
      get { return Settings.Default.selectedBackColor; }
    }


    public override Color ToolStripDropDownBackground
    {
      get { return Settings.Default.backColor; }
    }
    public override Color ImageMarginGradientBegin
    {
      get { return Settings.Default.backColor; }
    }
    public override Color ImageMarginGradientMiddle
    {
      get { return Settings.Default.backColor; }
    }
    public override Color ImageMarginGradientEnd
    {
      get { return Settings.Default.backColor; }
    }

    public override Color SeparatorDark
    {
      get
      {
        return Settings.Default.borderColor;
      }
    }
    public override Color SeparatorLight
    {
      get
      {
        return Settings.Default.borderColor;
      }
    }

    public override Color MenuBorder
    {
      get
      {
        return Settings.Default.borderColor;
      }
    }
  }
  public class MyRenderer : ToolStripProfessionalRenderer
  {
    public MyRenderer(ProfessionalColorTable colorTable)
        : base(colorTable)
    {
    }
    protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
    {
      e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
      Rectangle r = new Rectangle();
      Pen p = new Pen(Brushes.Red);
      //p.Color = Color.FromArgb(104, 104, 104);
      p.Color = Color.White;
      if (e.ArrowRectangle.Size.Height > 20)
      {
        r = new Rectangle(new Point(e.ArrowRectangle.Location.X - 2, e.ArrowRectangle.Size.Height / 2 - 6), new Size(6, 12));
        //r.Inflate(-2, -6);
      }
      else
      {
        r = new Rectangle(new Point(e.ArrowRectangle.Location.X, e.ArrowRectangle.Size.Height / 2 - 4), new Size(4, 8));
      }
      e.Graphics.DrawLines(p, new Point[]{
                new Point(r.Left, r.Top),
                new Point(r.Right, r.Top + r.Height /2),
                new Point(r.Left, r.Top+ r.Height)}
      );
    }

    protected override void OnRenderItemCheck(ToolStripItemImageRenderEventArgs e)
    {
      e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
      var r = new Rectangle(e.ImageRectangle.Location, e.ImageRectangle.Size);
      r.Inflate(-4, -6);
      e.Graphics.DrawLines(Pens.Black, new Point[]{
        new Point(r.Left, r.Bottom - r.Height /2),
        new Point(r.Left + r.Width /3,  r.Bottom),
        new Point(r.Right, r.Top)});
    }
  }

  /// <summary>
  /// Tray context menu
  /// 
  /// </summary>
  class ContextMenus
  {

    private DirectoryInfo dataFolderProfiles = new DirectoryInfo(Path.Combine(Settings.Default.DataFolder, "TrayStarterProfile"));
    private DirectoryInfo profilesFolder = new DirectoryInfo(Path.Combine(Application.StartupPath, "profiles"));
    private DirectoryInfo iconsFolder = new DirectoryInfo(Path.Combine(Application.StartupPath, "icons"));

    // All apps from xml config 
    private Dictionary<int, ProfileConfigItem> configAppList;
    // the same but grouped see XML <group> attribute
    private Dictionary<string, List<ProfileConfigItem>> configAppGroupedList;

    private ContextMenuStrip mainMenu = new ContextMenuStrip();
    private NotifyIcon ni;

    internal void create(string profileFileName, NotifyIcon ni)
    {
      this.ni = ni;
      this.ni.ContextMenuStrip = this.create(profileFileName);
    }

    internal ContextMenuStrip create(string profileFileName)
    {
      // Design
      List<string> errors = new List<string>();
      ToolStripMenuItem item;
      mainMenu.ImageScalingSize = new Size(32, 32);
      //mainMenu.BackColor = Color.Black;
      mainMenu.ForeColor = Settings.Default.foreColor;
      mainMenu.Renderer = new MyRenderer(new MainColorTable());

      // Logo
      item = new ToolStripMenuItem();
      item.BackgroundImage = Image.FromFile(Path.Combine(iconsFolder.FullName, "logo.png"));
      item.BackgroundImageLayout = ImageLayout.None;
      item.Dock = DockStyle.Right;
      item.AutoSize = false;
      item.Height = 67;
      item.Width = 200;
      item.BackColor = Settings.Default.backColor;
      item.Padding = new Padding(0, 0, 0, 7);
      item.Click += new EventHandler(itemLogo_Click);
      mainMenu.Items.Add(item);


      // Profile Selector Dropdown
      ToolStripMenuItem profileSelector = new ToolStripMenuItem();
      profileSelector.ShowShortcutKeys = false;
      profileSelector.Text = "Profile";
      ToolStripDropDown profileSelectorDropDownItem = new ToolStripDropDown();
      profileSelectorDropDownItem.ImageScalingSize = new Size(32, 32);
      profileSelectorDropDownItem.Renderer = new MyRenderer(new SubMenuColorTable());
      profileSelector.DropDown = profileSelectorDropDownItem;
      profileSelector.DropDown.Padding = new Padding(10, 5, 10, 5);
      profileSelector.DropDown.BackColor = Settings.Default.subItemBackColor;
      //profileSelector.DropDown.Renderer = new MyRenderer();

      // Menus Items
      DAL configDAL = new DAL(Application.StartupPath, Settings.Default.DataFolder);
      foreach (ConfigFile configurationFile in configDAL.allConfigFiles)
      {
        profileSelector.DropDown.Items.Add(createToolStrimMenuItem(iconsFolder, configurationFile.File.Name, "source_code_filled1.png", configurationFile.File.Name, subItemMenuItem_Click));
      }

      // Custom Menu Items
      profileSelector.DropDown.Items.Add(createToolStrimMenuItem(iconsFolder, "Open local config folder", "LocalFolder.png", profilesFolder.FullName, openFolderEventHandler));
      profileSelector.DropDown.Items.Add(createToolStrimMenuItem(iconsFolder, "Open network config folder", "NetworkFolder.png", dataFolderProfiles.FullName, openFolderEventHandler));
      profileSelector.DropDown.Items.Add(createToolStrimMenuItem(iconsFolder, "Open icons folder", "NetworkFolder.png", iconsFolder.FullName, openFolderEventHandler));
      profileSelector.DropDown.Items.Add(createToolStrimMenuItem(iconsFolder, "App config folder", "support.png", Environment.CurrentDirectory, openFolderEventHandler));
      mainMenu.Items.Add(profileSelector);

      //profileSelector.DropDown.ItemClicked += new ToolStripItemClickedEventHandler(profileSelectionDropDown_ItemClicked);
      //profileSelector.DropDown.ForeColor = Color.White;
      //mainMenu.Items.Add(new ToolStripSeparator());



      List<ProfileConfigItem> configList;
      FileInfo profile = new FileInfo(profilesFolder.FullName + @"\" + profileFileName);
      if (profile.Exists)
      {
        configList = Utils.DeserializeParameter(profile.FullName);
      }
      else
      {
        configList = Utils.DeserializeParameter(dataFolderProfiles.FullName + @"\" + profileFileName);
      }
      if (configAppGroupedList == null)
        configAppGroupedList = new Dictionary<string, List<ProfileConfigItem>>();

      if (configAppList == null)
        configAppList = new Dictionary<int, ProfileConfigItem>();
      int keyCount = 1;
      foreach (var configItem in configList)
      {

        List<ProfileConfigItem> currentGroup;
        bool result = configAppGroupedList.TryGetValue(configItem.group, out currentGroup);
        if (!result)
        {
          currentGroup = new List<ProfileConfigItem>();
          configAppGroupedList.Add(configItem.group, currentGroup);
        }

        try
        {
          currentGroup.Add(configItem);
          configItem.key = keyCount;
          configAppList.Add(configItem.key, configItem);
          keyCount++;
        }
        catch (Exception ex)
        {
          errors.Add(string.Format("Wrong item: Key: '{0}', Group: '{1}', DisplayName: '{2}' - '{3}'", configItem.key, configItem.group, configItem.displayName, ex.Message));
        }
      }
      int count = 0;
      Dictionary<char, int> shortcutLetterCounter = new Dictionary<char, int>();

      foreach (var configGroup in configAppGroupedList)
      {

        int firstItem = 0;
        foreach (var configItem in configGroup.Value)
        {
          if (firstItem == 0)
          {
            ToolStripLabel groupLabel = new ToolStripLabel();
            groupLabel.ForeColor = Settings.Default.groupColor;
            groupLabel.Text = configItem.group;
            mainMenu.Items.Add(groupLabel);
            //mainMenu.Items.Add(new ToolStripSeparator());
            firstItem++;
          }
          count++;

          item = new ToolStripMenuItem();
          item.ShowShortcutKeys = false;
          item.Text = configItem.displayName;

          FileInfo i1 = new FileInfo(Path.Combine(iconsFolder.FullName, configItem.icon));
          Image icon1;
          if (configItem.icon != null && i1.Exists)
          {
            icon1 = Image.FromFile(Path.Combine(iconsFolder.FullName, configItem.icon));
          }
          else
          {
            icon1 = Image.FromFile(Path.Combine(iconsFolder.FullName, "_defaulticons\\stern.png"));
          }
          item.Image = icon1;
          item.Tag = configItem.key;

          if (configItem.subItems.Count > 0)
          {
            ToolStripDropDown dropDownItem = new ToolStripDropDown();
            dropDownItem.ImageScalingSize = new Size(32, 32);
            dropDownItem.Padding = new Padding(10, 5, 10, 5);
            dropDownItem.Renderer = new MyRenderer(new SubMenuColorTable());
            dropDownItem.BackColor = Settings.Default.subItemBackColor;
            foreach (var subItem in configItem.subItems)
            {
              try
              {
                subItem.key = keyCount;
                configAppList.Add(keyCount, subItem);
                keyCount++;
              }
              catch (Exception ex)
              {
                errors.Add(string.Format("Wrong item. \r\nKey: '{0}', \r\nGroup: '{1}', \r\nDisplayName: '{2}'\r\n'Error: {3}'\r\n\r\n", subItem.key, subItem.group, subItem.displayName, ex.Message));
              }
              ToolStripMenuItem subItemMenuItem = new ToolStripMenuItem();
              subItemMenuItem.ShowShortcutKeys = false;

              subItemMenuItem.Text = " " + subItem.displayName;
              FileInfo i2 = new FileInfo(Path.Combine(iconsFolder.FullName, subItem.icon));
              Image subImage;
              if (subItem.icon != null && i2.Exists)
              {
                //object resource = Resources.ResourceManager.GetObject(subItem.icon);
                subImage = Image.FromFile(Path.Combine(iconsFolder.FullName, subItem.icon));

              }
              else
              {
                subImage = Image.FromFile(Path.Combine(iconsFolder.FullName, "_defaulticons\\stern.png"));
              }
              subItemMenuItem.Image = subImage;
              subItemMenuItem.Tag = subItem.key;
              subItemMenuItem.Click += new EventHandler(item_Click);
              subItemMenuItem.BackColor = Settings.Default.subItemBackColor;
              subItemMenuItem.ForeColor = Settings.Default.subItemForeColor;
              dropDownItem.Items.Add(subItemMenuItem);
            }
            item.DropDown = dropDownItem;
          }
          else
          {
            item.Click += new EventHandler(item_Click);
          }

          mainMenu.Items.Add(item);

        }


      }

      // Add exit button
      item = new ToolStripMenuItem();
      item.Text = "Exit";
      item.Click += new EventHandler(itemExit_Click);
      item.Image = Resources.Delete_32;
      mainMenu.Items.Add(item);

      string errorsFormatted = "";
      foreach (string error in errors)
      {
        errorsFormatted = string.Format("{0}{1}\r\n", errorsFormatted, error);
      }
      if (errors.Count > 0)
      {
        MessageBox.Show(errorsFormatted, string.Format("Profile '{0}' validation.", profileFileName), MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
      return mainMenu;
    }

    private static ToolStripMenuItem createToolStrimMenuItem(DirectoryInfo iconsFolder, string text, string iconName, string tag, EventHandler clickEvent)
    {
      ToolStripMenuItem subItemMenuItemLocalConfig = new ToolStripMenuItem();
      subItemMenuItemLocalConfig.Click += clickEvent;
      subItemMenuItemLocalConfig.Text = " " + text;
      subItemMenuItemLocalConfig.Tag = tag;
      Image subImage2 = Image.FromFile(Path.Combine(iconsFolder.FullName, "_defaulticons\\" + iconName));
      subItemMenuItemLocalConfig.Image = subImage2;
      subItemMenuItemLocalConfig.ShowShortcutKeys = false;
      subItemMenuItemLocalConfig.BackColor = Settings.Default.subItemBackColor;
      subItemMenuItemLocalConfig.ForeColor = Settings.Default.subItemForeColor;
      return subItemMenuItemLocalConfig;
    }


    void openFolderEventHandler(object sender, EventArgs e)
    {
      string folder = (string)((ToolStripItem)sender).Tag;
      Process.Start("explorer.exe", folder);
    }
    void subItemMenuItem_Click3(object sender, EventArgs e)
    {
      string folder = (string)((ToolStripItem)sender).Tag;
      Process.Start("explorer.exe", folder);
    }
    void subItemMenuItem_Click4(object sender, EventArgs e)
    {
      string folder = (string)((ToolStripItem)sender).Tag;
      Process.Start("explorer.exe", folder);
    }

    void subItemMenuItem_Click(object sender, EventArgs e)
    {
      string selectedProfile = (string)((ToolStripItem)sender).Tag;
      this.configAppList = new Dictionary<int, ProfileConfigItem>();
      this.configAppGroupedList = new Dictionary<string, List<ProfileConfigItem>>();
      ni.ContextMenuStrip.Items.Clear();

      this.ni.ContextMenuStrip = this.create(selectedProfile);
      this.ni.ContextMenuStrip.Refresh();
    }



    #region Events

    void profileSelectionDropDown_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
      string selectedProfile = e.ClickedItem.Text;
      this.configAppList = new Dictionary<int, ProfileConfigItem>();
      this.configAppGroupedList = new Dictionary<string, List<ProfileConfigItem>>();
      ni.ContextMenuStrip.Items.Clear();

      this.ni.ContextMenuStrip = this.create(selectedProfile);
      this.ni.ContextMenuStrip.Refresh();
    }

    void item_Click(object sender, EventArgs e)
    {
      int appKey = (int)((ToolStripItem)sender).Tag;
      ProfileConfigItem appConfig = configAppList[appKey];
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
      // TODO: asfg

    }


    void itemExit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    void itemLogo_Click(object sender, EventArgs e)
    {
    }

    #endregion



  }
}
