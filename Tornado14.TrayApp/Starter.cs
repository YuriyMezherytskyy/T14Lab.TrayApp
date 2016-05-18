using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Windows.Forms;
using Hotkeys;
using Tornado14.TrayApp.Properties;
using Tornado14Lab.Utils.NativeTheme;
using Tornado14Lab.Utils.DataGridViewHelper;
using Tornado14.Task;
using Tornado14.TrayApp.Controls;
using Tornado14.TrayApp.Controls.Task;

namespace Tornado14.TrayApp
{
  public partial class Starter : Form
  {

    private Hotkeys.GlobalHotkey ghk;
    private ProcessIcon pi;
    private List<ProfileConfigItem> configTextList;
    private ImageList iconList = new ImageList();
    private List<string> groups;
    private NewTask newTask = new NewTask();

    private DirectoryInfo iconsFolder = new DirectoryInfo(Path.Combine(Application.StartupPath, "icons"));

    public Starter()
    {
      InitializeComponent();

      // Design 
      this.BackColor = Color.FromArgb(63,63, 63);
      panel1.BackColor = Settings.Default.backColor;
      panelStarter.BackColor = Settings.Default.backColor;

      //pictureBox1.Image = Image.FromFile(Path.Combine(iconsFolder.FullName, "logo.png"));
      iconList.ColorDepth = ColorDepth.Depth32Bit;
      iconList.ImageSize = new System.Drawing.Size(32, 32);
      listView1.LargeImageList = iconList;


      ghk = new Hotkeys.GlobalHotkey(Constants.WIN, Keys.Y, this);
      //projectExplorer = new GlobalHotkey(Constants.WIN, Keys.N, this);
      this.Hide();

      configTextList = new List<ProfileConfigItem>();
      int groupCount = 0;
      groups = new List<string>();
      int menuGroupCount = 0;
      string menuGroupLetter = string.Empty;

      DAL configDAL = new DAL(Application.StartupPath, Settings.Default.DataFolder);

      foreach (ConfigFile configurationFile in configDAL.allConfigFiles)
      {
        groupCount += 100000;
        List<ProfileConfigItem> configList = configurationFile.GetItems();

        foreach (ProfileConfigItem configItem in configList)
        {
          // Find Groups
          if (!groups.Contains(configItem.group))
          {
            menuGroupCount++;
            groups.Add(configItem.group);
            menuGroupLetter = "ALT + ";
            listBox1.Items.Add(string.Format("{0}. {1}", string.Format("{0}{1}", menuGroupLetter, menuGroupCount), configItem.group));
          }
          // Find Apps
          if (configItem.app != null && configItem.app != string.Empty)
          {
            configTextList.Add(configItem);
          }
          // Find Sub Apps
          foreach (ProfileConfigItem subItem in configItem.subItems)
          {
            subItem.group = configItem.group;
            if (subItem.app != null && subItem.app != string.Empty)
            {
              configTextList.Add(subItem);
            }
          }
        }
      }


      DirectoryInfo dataFolder;
      dataFolder = new DirectoryInfo(Path.Combine(Settings.Default.DataFolder, @"ProjectExplorer\"));
      string sprintXmlFile = Path.Combine(dataFolder.FullName, "sprints.xml");
      string todoXmlFile = Path.Combine(dataFolder.FullName, "todos.xml");
      string projectXmlFile = Path.Combine(dataFolder.FullName, "projects.xml");

      SortableBindingList<Sprint> sprints = SortableBindingListHelper.GetBindingListFromXmlFile<Sprint>(sprintXmlFile);
      SortableBindingList<Todo> todos = SortableBindingListHelper.GetBindingListFromXmlFile<Todo>(todoXmlFile);
      SortableBindingList<Project> projects = SortableBindingListHelper.GetBindingListFromXmlFile<Project>(projectXmlFile);

      foreach (Project project in projects)
      {
        if (project.FilesFolder != null && project.FilesFolder.Length > 0)
        {
          ProfileConfigItem item = new ProfileConfigItem();
          item.app = "explorer";
          item.group = project.Id;
          item.parameter = project.FilesFolder;
          item.displayName = string.Format("1 {0} [Open Files Folderin Explorer]", project.ShortDescription);
          configTextList.Add(item);
        }

        if (project.SVNRepository != null && project.SVNRepository.Length > 0)
        {
          ProfileConfigItem item = new ProfileConfigItem();
          item.app = @"C:\Program Files\TortoiseSVN\bin\TortoiseProc.exe";
          item.group = project.Id;
          item.parameter = string.Format("/command:repobrowser /path:{0}", project.SVNRepository);
          item.displayName = string.Format("1 {0} [SVN Open in Repo browser]", project.ShortDescription);

          configTextList.Add(item);
        }

        if (project.VisualStudioSolution != null && project.VisualStudioSolution.Length > 0)
        {
          ProfileConfigItem item = new ProfileConfigItem();
          item.app = @"C:\Program Files (x86)\Common7\IDE\devenv.exe";
          item.group = project.Id;
          item.parameter = project.VisualStudioSolution;
          item.displayName = string.Format("1 {0} [Open in Visual Studio]", project.ShortDescription);

          configTextList.Add(item);

          FileInfo solutionFile = new FileInfo(project.VisualStudioSolution);
          ProfileConfigItem item2 = new ProfileConfigItem();
          item2.app = @"explorer";
          item2.group = project.Id;
          item2.parameter = solutionFile.DirectoryName;
          item2.displayName = string.Format("1 {0} Visual Studio Solution Folder", project.ShortDescription);

          configTextList.Add(item2);

          if (solutionFile.Exists)
          {
            foreach (DirectoryInfo projectDirectory in solutionFile.Directory.GetDirectories())
            {
              DirectoryInfo debug = new DirectoryInfo(projectDirectory.FullName + @"\bin\debug");
              if (debug.Exists)
              {
                ProfileConfigItem item3 = new ProfileConfigItem();
                item3.app = @"explorer";
                item3.group = project.Id;
                item3.parameter = debug.FullName;
                item3.displayName = string.Format("2 Project '{1}' Debug Folder", project.ShortDescription, projectDirectory.Name);

                configTextList.Add(item3);
              }
            }
          }


        }
      }
      foreach (Sprint sprint in sprints)
      {
      }
      foreach (Todo todo in todos)
      {
        if (todo.FilesFolder != null && todo.FilesFolder.Length > 0)
        {
          ProfileConfigItem item = new ProfileConfigItem();
          item.app = "explorer";
          item.group = todo.Id;
          item.parameter = todo.FilesFolder;
          item.displayName = string.Format("1 {0} [Task Files]", todo.ShortDescription);
          item.icon = @"_defaulticons\folder.png";

          configTextList.Add(item);
        }
      }


      wpfStarterComboBox1.Init(configTextList);
      wpfStarterComboBox1.SelectionChanged += WpfStarterComboBox1_SelectionChanged;


      //this.BackColor = BlackTheme.ColorDarkGray;
      this.ForeColor = BlackTheme.ColorText;
      // Apply Black Theme
      //BlackTheme.ApplyTheme(this);
    }

    private void WpfStarterComboBox1_SelectionChanged(object selectedObject)
    {
      ProfileConfigItem selectedApp = (ProfileConfigItem)selectedObject;

      if (selectedApp != null && selectedApp.app != null && selectedApp.app != string.Empty)
      {
        Utils.StartApp(selectedApp);

        ListViewItem item = new ListViewItem();
        Utils.GetIconForListView(iconsFolder, selectedApp, item, iconList);

        item.Text = selectedApp.displayName;
        item.Tag = selectedApp;

        ListViewItem oldItem = listView1.FindItemWithText(item.Text);
        if (oldItem != null)
        {
          listView1.Items.Remove(oldItem);
        }
        listView1.Items.Add(item);

        wpfStarterComboBox1.SetText(" - Starting...");
      }
    }

    public void InitStarter(ProcessIcon pi)
    {
      this.pi = pi;
    }

    private void HandleHotkey(Message m)
    {
      if (m.LParam == (IntPtr)5832712)
      {

        if (this.WindowState == FormWindowState.Minimized)
        {
          this.WindowState = FormWindowState.Normal;
        }

        this.Activate();

        this.Show();
        this.Focus();
        wpfStarterComboBox1.SetText(string.Empty);
        wpfStarterComboBox1.SetFocus();

      }
      else if (m.LParam == (IntPtr)5439496)
      {

        if (newTask.IsDisposed)
        {
          newTask = new NewTask();
        }
        else
        {
          newTask.Dispose();
          newTask = new NewTask();
        }
        newTask.StartPosition = FormStartPosition.Manual;
        newTask.Show();
        newTask.Activate();
        newTask.WindowState = FormWindowState.Maximized;
        newTask.Focus();
        wpfStarterComboBox1.SetFocus();
      }
    }

    protected override void WndProc(ref Message m)
    {
      if (m.Msg == Hotkeys.Constants.WM_HOTKEY_MSG_ID)
        HandleHotkey(m);
      base.WndProc(ref m);
    }

    private void Starter_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (!ghk.Unregiser())
        MessageBox.Show("Hotkey failed to unregister!");
    }

    private void WriteLine(string text)
    {
      //textBox1.Text += text + Environment.NewLine;
    }

    private void Starter_Load(object sender, EventArgs e)
    {
      if (ghk != null && ghk.Register())
        WriteLine("Hotkey registered.");
      else
        WriteLine("Hotkey failed to register");

    }


    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
      try
      {
        switch (keyData)
        {
          case (Keys.Alt | Keys.D1):
            setComboboxText(listBox1.Items[0].ToString());
            break;
          case (Keys.Alt | Keys.D2):
            setComboboxText(listBox1.Items[1].ToString());
            break;
          case (Keys.Alt | Keys.D3):
            setComboboxText(listBox1.Items[2].ToString());
            break;
          case (Keys.Alt | Keys.D4):
            setComboboxText(listBox1.Items[3].ToString());
            break;
          case (Keys.Alt | Keys.D5):
            setComboboxText(listBox1.Items[4].ToString());
            break;
          case (Keys.Alt | Keys.D6):
            setComboboxText(listBox1.Items[5].ToString());
            break;
          case (Keys.Alt | Keys.D7):
            setComboboxText(listBox1.Items[6].ToString());
            break;
          case (Keys.Alt | Keys.D8):
            setComboboxText(listBox1.Items[7].ToString());
            break;
          case (Keys.Alt | Keys.D9):
            setComboboxText(listBox1.Items[8].ToString());
            break;
          case (Keys.Alt | Keys.Q):
            setComboboxText(listBox1.Items[9].ToString());
            break;
          case (Keys.Alt | Keys.W):
            setComboboxText(listBox1.Items[10].ToString());
            break;
          case (Keys.Alt | Keys.E):
            setComboboxText(listBox1.Items[11].ToString());
            break;
          case (Keys.Alt | Keys.R):
            setComboboxText(listBox1.Items[12].ToString());
            break;
          case (Keys.Alt | Keys.A):
            setComboboxText(listBox1.Items[13].ToString());
            break;
          case (Keys.Alt | Keys.S):
            setComboboxText(listBox1.Items[14].ToString());
            break;
          case (Keys.Alt | Keys.D):
            setComboboxText(listBox1.Items[15].ToString());
            break;
          case (Keys.Alt | Keys.F):
            setComboboxText(listBox1.Items[16].ToString());
            break;
          case (Keys.Alt | Keys.Y):
            setComboboxText(listBox1.Items[17].ToString());
            break;

          case Keys.Escape:
            wpfStarterComboBox1.SetText(string.Empty);
            break;
          default:
            return base.ProcessCmdKey(ref msg, keyData);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
      return true;
    }

    private void setComboboxText(string text)
    {
      wpfStarterComboBox1.SetText(text.Split('.')[1].Trim());
      wpfStarterComboBox1.SetFocus();
    }








    private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      StartSelectedItems();
    }

    private void StartSelectedItems()
    {
      foreach (ListViewItem item in listView1.SelectedItems)
      {
        ProfileConfigItem selectedApp = (ProfileConfigItem)item.Tag;

        if (selectedApp != null && selectedApp.app != null && selectedApp.app != string.Empty)
        {
          Utils.StartApp(selectedApp);
        }
      }
    }

    private void listView1_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == 13)
      {
        StartSelectedItems();
      }
    }
  }
}
