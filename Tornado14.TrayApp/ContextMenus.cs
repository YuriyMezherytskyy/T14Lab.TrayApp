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

    /// <summary>
    /// Tray context menu
    /// 
    /// </summary>
    class ContextMenus
    {

        // All apps from xml config 
        private Dictionary<int, ProfileConfigItem> cacheAppList;
        // the same but grouped see XML <group> attribute
        private Dictionary<string, List<ProfileConfigItem>> cacheGroupAppList;

        private string selectedProfileName;
        private ContextMenuStrip settingsContextMenuInstance;
        private ContextMenuStrip lastSelectedContextMenuIntance;

        private NotifyIcon icon;
        private DirectoryInfo networkProfiles = new DirectoryInfo(Path.Combine(Settings.Default.DataFolder, "TrayStarterProfile"));
        private DirectoryInfo localProfiles = new DirectoryInfo(Path.Combine(Application.StartupPath, "profiles"));
        private DirectoryInfo iconsFolder = new DirectoryInfo(Path.Combine(Application.StartupPath, "icons"));

        #region Methods

        internal ContextMenus Create(string profileFileName, NotifyIcon ni)
        {
            this.icon = ni;
            selectedProfileName = profileFileName;
            lastSelectedContextMenuIntance = this.CreateContextMenu(profileFileName);
            this.icon.ContextMenuStrip = lastSelectedContextMenuIntance;
            return this;
        }

        internal void LoadSettingsContextMenu()
        {
            if (this.icon.ContextMenuStrip != settingsContextMenuInstance)
            {
                lastSelectedContextMenuIntance = this.icon.ContextMenuStrip;
            }

            if (settingsContextMenuInstance == null)
            {
                settingsContextMenuInstance = CreateSettingsContextMenu();
            }
            this.icon.ContextMenuStrip = settingsContextMenuInstance;
            this.icon.ContextMenuStrip.Refresh();
            Point currentMousePosition = Cursor.Position;
            currentMousePosition.X -= settingsContextMenuInstance.Width / 2; ;
            currentMousePosition.Y -= settingsContextMenuInstance.Height + 5;
            icon.ContextMenuStrip.Show(currentMousePosition);
        }

        internal void LoadLastSelectedProfile()
        {
            if (lastSelectedContextMenuIntance == null)
            {
                this.icon.ContextMenuStrip = this.CreateContextMenu(selectedProfileName);
                this.icon.ContextMenuStrip.Refresh();
            }
            else
            {
                this.icon.ContextMenuStrip = lastSelectedContextMenuIntance;
                this.icon.ContextMenuStrip.Refresh();
                Point currentMousePosition = Cursor.Position;
                currentMousePosition.X -= lastSelectedContextMenuIntance.Width / 2;
                currentMousePosition.Y -= lastSelectedContextMenuIntance.Height + 5;
                icon.ContextMenuStrip.Show(currentMousePosition);
            }
        }


        private ContextMenuStrip CreateSettingsContextMenu()
        {
            ContextMenuStrip settingsConextMenu = new ContextMenuStrip();

            // Design
            List<string> errors = new List<string>();
            ToolStripMenuItem item;
            settingsConextMenu.ImageScalingSize = new Size(32, 32);
            //mainMenu.BackColor = Color.Black;
            settingsConextMenu.ForeColor = Settings.Default.foreColor;
            settingsConextMenu.Renderer = new MyRenderer(new MainColorTable());

            settingsConextMenu.Items.Add(CreateLogo());

            ToolStripLabel groupLabel = new ToolStripLabel();
            groupLabel.ForeColor = Settings.Default.groupColor;
            groupLabel.Text = "Select Profile";
            settingsConextMenu.Items.Add(groupLabel);

            // Profile Selector Dropdown
            ToolStripMenuItem profileSelector = new ToolStripMenuItem();
            profileSelector.ShowShortcutKeys = false;
            profileSelector.Text = "Folders";
            profileSelector.Image = Image.FromFile(Path.Combine(iconsFolder.FullName, "_defaulticons\\" + "folder.png"));
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
                settingsConextMenu.Items.Add(CreateMenuItem(iconsFolder, configurationFile.File.Name, "source_code.png", configurationFile.File.Name, changeProfileEventHandler, Settings.Default.backColor, Settings.Default.foreColor));
            }

            // Custom Menu Items
            profileSelector.DropDown.Items.Add(CreateMenuItem(iconsFolder, "Open local config folder", "LocalFolder.png", localProfiles.FullName, openFolderEventHandler, Settings.Default.subItemBackColor, Settings.Default.subItemForeColor));
            profileSelector.DropDown.Items.Add(CreateMenuItem(iconsFolder, "Open network config folder", "NetworkFolder.png", networkProfiles.FullName, openFolderEventHandler, Settings.Default.subItemBackColor, Settings.Default.subItemForeColor));
            profileSelector.DropDown.Items.Add(CreateMenuItem(iconsFolder, "Open icons folder", "NetworkFolder.png", iconsFolder.FullName, openFolderEventHandler, Settings.Default.subItemBackColor, Settings.Default.subItemForeColor));
            profileSelector.DropDown.Items.Add(CreateMenuItem(iconsFolder, "App config folder", "support.png", Environment.CurrentDirectory, openFolderEventHandler, Settings.Default.subItemBackColor, Settings.Default.subItemForeColor));
            settingsConextMenu.Items.Add(profileSelector);

            // Add exit button
            item = new ToolStripMenuItem();
            item.Text = "Exit";
            item.Click += new EventHandler(itemExit_Click);
            item.Image = Resources.Delete_32;
            settingsConextMenu.Items.Add(item);

            string errorsFormatted = "";
            foreach (string error in errors)
            {
                errorsFormatted = string.Format("{0}{1}\r\n", errorsFormatted, error);
            }
            if (errors.Count > 0)
            {
                MessageBox.Show(errorsFormatted, "Profile '{0}' validation.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return settingsConextMenu;
        }

        private ContextMenuStrip CreateContextMenu(string profileFileName)
        {
            ContextMenuStrip mainMenu = new ContextMenuStrip();
            List<string> errors = new List<string>();
            ToolStripMenuItem item;
            mainMenu.ForeColor = Settings.Default.foreColor;
            mainMenu.ImageScalingSize = new Size(32, 32);
            mainMenu.Renderer = new MyRenderer(new MainColorTable());
            mainMenu.Items.Add(CreateLogo());

            List<ProfileConfigItem> appList = new List<ProfileConfigItem>();

            FileInfo globalProfile = new FileInfo(localProfiles.FullName + @"\" + "global.xml");
            if (globalProfile.Exists)
            {
                List<ProfileConfigItem> globalAppList = Utils.DeserializeParameter(globalProfile.FullName);
                appList.AddRange(globalAppList);
            }

            FileInfo profile = new FileInfo(localProfiles.FullName + @"\" + profileFileName);
            if (profile.Exists)
            {
                appList.AddRange(Utils.DeserializeParameter(profile.FullName));
            }
            else
            {
                appList.AddRange(Utils.DeserializeParameter(networkProfiles.FullName + @"\" + profileFileName));
            }
            int keyCount = CreateCache(errors, appList);
            int count = 0;
            Dictionary<char, int> shortcutLetterCounter = new Dictionary<char, int>();

            foreach (var configGroup in cacheGroupAppList)
            {

                int firstItem = 0;
                foreach (var configItem in configGroup.Value)
                {
                    if (firstItem == 0)
                    {
                        if (configItem.group != "global")
                        {
                            ToolStripLabel groupLabel = new ToolStripLabel();
                            groupLabel.ForeColor = Settings.Default.groupColor;
                            groupLabel.Text = configItem.group;
                            mainMenu.Items.Add(groupLabel);
                        }
                        firstItem++;
                    }
                    count++;

                    item = new ToolStripMenuItem();
                    item.ShowShortcutKeys = false;
                    item.Text = configItem.displayName;
                    item.Image = Utils.GetIconFromProfileConfigItem(configItem, iconsFolder);
                    item.Tag = configItem.key;

                    if (configItem.subItems.Count > 0)
                    {
                        ToolStripDropDown dropDownItem = CreateDropdown(errors, ref keyCount, configItem);
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
            lastSelectedContextMenuIntance = mainMenu;
            return mainMenu;
        }


        private ToolStripDropDown CreateDropdown(List<string> errors, ref int keyCount, ProfileConfigItem configItem)
        {
            ToolStripDropDown dropDownItem = new ToolStripDropDown();
            dropDownItem.ImageScalingSize = new Size(32, 32);
            dropDownItem.Padding = new Padding(10, 5, 10, 5);
            dropDownItem.Renderer = new MyRenderer(new SubMenuColorTable());
            dropDownItem.BackColor = Settings.Default.subItemBackColor;
            foreach (var subItem in configItem.subItems)
            {
                if (subItem.displayName.StartsWith("-----"))
                {
                    ToolStripMenuItem separator = new ToolStripMenuItem();
                    separator.Text = "_______________";
                    separator.ForeColor = Settings.Default.borderColor;
                    dropDownItem.Items.Add(separator);
                }
                else if (subItem.displayName == "startAll")
                {
                    dropDownItem.Items.Add(CreateMenuItem(iconsFolder, "Start All", "start.png", configItem.key.ToString(), startAllEventHandler, Settings.Default.subItemBackColor, Settings.Default.subItemForeColor));
                }
                else {
                    try
                    {
                        subItem.key = keyCount;
                        cacheAppList.Add(keyCount, subItem);
                        keyCount++;
                    }
                    catch (Exception ex)
                    {
                        errors.Add(string.Format("Wrong item. \r\nKey: '{0}', \r\nGroup: '{1}', \r\nDisplayName: '{2}'\r\n'Error: {3}'\r\n\r\n", subItem.key, subItem.group, subItem.displayName, ex.Message));
                    }
                    ToolStripMenuItem subItemMenuItem = new ToolStripMenuItem();
                    subItemMenuItem.ShowShortcutKeys = false;

                    subItemMenuItem.Text = " " + subItem.displayName;
                    subItemMenuItem.Image = Utils.GetIconFromProfileConfigItem(subItem, iconsFolder);

                    subItemMenuItem.Tag = subItem.key;
                    subItemMenuItem.Click += new EventHandler(item_Click);
                    subItemMenuItem.BackColor = Settings.Default.subItemBackColor;
                    subItemMenuItem.ForeColor = Settings.Default.subItemForeColor;
                    dropDownItem.Items.Add(subItemMenuItem);
                }
            }

            return dropDownItem;
        }

        private static ToolStripMenuItem CreateMenuItem(DirectoryInfo iconsFolder, string text, string iconName, string tag, EventHandler clickEvent, Color backColor, Color foreColor)
        {
            ToolStripMenuItem subItemMenuItemLocalConfig = new ToolStripMenuItem();
            subItemMenuItemLocalConfig.Click += clickEvent;
            subItemMenuItemLocalConfig.Text = " " + text;
            subItemMenuItemLocalConfig.Tag = tag;
            Image subImage2 = Image.FromFile(Path.Combine(iconsFolder.FullName, "_defaulticons\\" + iconName));
            subItemMenuItemLocalConfig.Image = subImage2;
            subItemMenuItemLocalConfig.ShowShortcutKeys = false;
            subItemMenuItemLocalConfig.BackColor = backColor;
            subItemMenuItemLocalConfig.ForeColor = foreColor;
            return subItemMenuItemLocalConfig;
        }

        private int CreateCache(List<string> errors, List<ProfileConfigItem> appList)
        {
            if (cacheGroupAppList == null)
                cacheGroupAppList = new Dictionary<string, List<ProfileConfigItem>>();

            if (cacheAppList == null)
                cacheAppList = new Dictionary<int, ProfileConfigItem>();
            int keyCount = 1;
            foreach (var configItem in appList)
            {
                if (configItem.displayName.StartsWith("-----") || configItem.displayName == "startAll")
                {

                }
                else {
                    List<ProfileConfigItem> currentGroup;
                    bool result = cacheGroupAppList.TryGetValue(configItem.group, out currentGroup);
                    if (!result)
                    {
                        currentGroup = new List<ProfileConfigItem>();
                        cacheGroupAppList.Add(configItem.group, currentGroup);
                    }

                    try
                    {
                        currentGroup.Add(configItem);
                        configItem.key = keyCount;
                        cacheAppList.Add(configItem.key, configItem);
                        keyCount++;
                    }
                    catch (Exception ex)
                    {
                        errors.Add(string.Format("Wrong item: Key: '{0}', Group: '{1}', DisplayName: '{2}' - '{3}'", configItem.key, configItem.group, configItem.displayName, ex.Message));
                    }
                }
            }

            return keyCount;
        }

        private ToolStripMenuItem CreateLogo()
        {
            ToolStripMenuItem item = new ToolStripMenuItem();
            item.BackgroundImage = Image.FromFile(Path.Combine(iconsFolder.FullName, "logo.png"));
            item.BackgroundImageLayout = ImageLayout.None;
            item.Dock = DockStyle.Right;
            item.AutoSize = false;
            item.Height = 67;
            item.Width = 200;
            item.BackColor = Settings.Default.backColor;
            item.Padding = new Padding(0, 0, 0, 7);
            item.Click += new EventHandler(itemLogo_Click);
            return item;
        }


        #endregion

        #region Events

        void openFolderEventHandler(object sender, EventArgs e)
        {
            string folder = (string)((ToolStripItem)sender).Tag;
            Process.Start("explorer.exe", folder);
        }

        void startAllEventHandler(object sender, EventArgs e)
        {
            int key = int.Parse((string)((ToolStripItem)sender).Tag);
            if (cacheAppList.ContainsKey(key))
            {
                foreach (ProfileConfigItem item in cacheAppList[key].subItems)
                {
                    Utils.StartApp(item);
                }
            }
            //Process.Start("explorer.exe", folder);
        }

        void changeProfileEventHandler(object sender, EventArgs e)
        {
            selectedProfileName = (string)((ToolStripItem)sender).Tag;
            this.cacheAppList = new Dictionary<int, ProfileConfigItem>();
            this.cacheGroupAppList = new Dictionary<string, List<ProfileConfigItem>>();

            this.icon.ContextMenuStrip = this.CreateContextMenu(selectedProfileName);
            this.icon.ContextMenuStrip.Refresh();
        }

        void item_Click(object sender, EventArgs e)
        {
            int appKey = (int)((ToolStripItem)sender).Tag;
            ProfileConfigItem appConfig = cacheAppList[appKey];
            Utils.StartApp(appConfig);
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

}
