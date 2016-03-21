﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tornado14Lab.Utils.DataGridViewHelper;
using Tornado14.Task;
using Tornado14Lab.Utils;
using System.IO;
using Tornado14Lab.Utils.DateHelper;
using Tornado14Lab.Utils.NativeTheme;
using System.Runtime.InteropServices;
using Tornado14.TrayApp.Properties;
using Tornado14Lab.Utils.Text;
using Tornado14.TrayApp.Controls;

namespace Tornado14.TrayApp
{
    public partial class ProjectExplorer : Form
    {
        public static DirectoryInfo dataFolder = null;
        public static DirectoryInfo devFolder = null;
        public static DirectoryInfo devFolderLibs = null;
        public static DirectoryInfo devFolderSvn = null;
        public static DirectoryInfo devFolderSamples = null;

        private List<IStandardPanel> panels = new List<IStandardPanel>();
        private DirectoryInfo iconsFolder = new DirectoryInfo(Path.Combine(Application.StartupPath, "icons"));
        private string sprintXMLFilePath;
        private string todoXMLFilePath;
        private string projectXMLFilePath;

        public ProjectExplorer()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(Path.Combine(iconsFolder.FullName, "logo.png"));
            SetPaths();

            ReadXMLFiles();

            panels.Add(projectGridPanel1);
            panels.Add(sprintGridPanel1);
            panels.Add(tasksGridPanel1);
            panels.Add(sprintKanbanPanel1);
            panels.Add(taskPlanningPanel1);

            projectGridPanel1.parentPanel = this;
            sprintGridPanel1.parentPanel = this;
            tasksGridPanel1.parentPanel = this;
            sprintKanbanPanel1.parentPanel = this;
            taskPlanningPanel1.parentPanel = this;





            sprintKanbanPanel1.HasChanges = false;
            sprintGridPanel1.HasChanges = false;
            tasksGridPanel1.HasChanges = false;
            projectGridPanel1.HasChanges = false;

            SetBlackTheme();
        }

        private void ReadXMLFiles()
        {
            SortableBindingList<Sprint> allSprints = SortableBindingListHelper.GetBindingListFromXmlFile<Sprint>(sprintXMLFilePath);
            SortableBindingList<Todo> allTodos = SortableBindingListHelper.GetBindingListFromXmlFile<Todo>(todoXMLFilePath);
            SortableBindingList<Project> allProjects = SortableBindingListHelper.GetBindingListFromXmlFile<Project>(projectXMLFilePath);

            projectBindingSource.DataSource = allProjects;
            sprintBindingSource.DataSource = allSprints;
            todoBindingSource.DataSource = allTodos;

            sprintGridPanel1.SprintBindingSource.DataSource = allSprints;
            tasksGridPanel1.TodoBindingSource.DataSource = allTodos;

            // Read data from XML Files
            //projectBindingSource.DataSource = 
            projectGridPanel1.SprintBindingSource.DataSource = sprintGridPanel1.SprintBindingSource.DataSource;
            projectGridPanel1.TodoBindingSource.DataSource = tasksGridPanel1.TodoBindingSource.DataSource;
            projectGridPanel1.SetProjectDataSource(allProjects);

            tasksGridPanel1.ProjectBindingSource.DataSource = projectGridPanel1.ProjectBindingSource.DataSource;

            sprintKanbanPanel1.ProjectBindingSource.DataSource = projectGridPanel1.ProjectBindingSource.DataSource;
            sprintKanbanPanel1.TodoBindingSource.DataSource = tasksGridPanel1.TodoBindingSource.DataSource;
            sprintKanbanPanel1.SprintBindingSourceDataSource(sprintGridPanel1.SprintBindingSource.DataSource);

            taskPlanningPanel1.ProjectBindingSourceDataSource(projectGridPanel1.ProjectBindingSource.DataSource);
            taskPlanningPanel1.SprintBindingSourceDataSource(sprintGridPanel1.SprintBindingSource.DataSource);
            taskPlanningPanel1.TodoBindingSourceDataSource(tasksGridPanel1.TodoBindingSource.DataSource);
        }

        private void SetPaths()
        {
            // Check Data Folder
            dataFolder = new DirectoryInfo(Path.Combine(Settings.Default.DataFolder, @"ProjectExplorer\"));

            sprintXMLFilePath = Path.Combine(dataFolder.FullName, "sprints.xml");
            todoXMLFilePath = Path.Combine(dataFolder.FullName, "todos.xml");
            projectXMLFilePath = Path.Combine(dataFolder.FullName, "projects.xml");

            if (!dataFolder.Exists)
            {
                dataFolder.Create();
            }
            DirectoryInfo tasksFolder = new DirectoryInfo(Path.Combine(Settings.Default.DataFolder, @"ProjectExplorer\Files\Tasks\"));
            if (!tasksFolder.Exists)
            {
                tasksFolder.Create();
            }

            devFolder = new DirectoryInfo(@"c:\dev\");
            if (!devFolder.Exists)
            {
                devFolder.Create();
            }
            devFolderLibs = new DirectoryInfo(Path.Combine(devFolder.ToString(), @"libs\"));
            if (!devFolderLibs.Exists)
            {
                devFolderLibs.Create();
            }
            devFolderSvn = new DirectoryInfo(Path.Combine(devFolder.ToString(), @"svn\"));
            if (!devFolderSvn.Exists)
            {
                devFolderSvn.Create();
            }
            devFolderSamples = new DirectoryInfo(Path.Combine(devFolder.ToString(), @"samples\"));
            if (!devFolderSamples.Exists)
            {
                devFolderSamples.Create();
            }
        }

        public void Save()
        {
            StreamWriter projectsXMLFile = new StreamWriter(projectXMLFilePath);
            projectsXMLFile.WriteLine(XmlSerializationHelper.Serialize(projectBindingSource.List));
            projectsXMLFile.Close();

            StreamWriter todosXMLFile = new StreamWriter(todoXMLFilePath);
            todosXMLFile.WriteLine(XmlSerializationHelper.Serialize(todoBindingSource.List));
            todosXMLFile.Close();

            StreamWriter sprintsXMLFile = new StreamWriter(sprintXMLFilePath);
            sprintsXMLFile.WriteLine(XmlSerializationHelper.Serialize(sprintBindingSource.List));
            sprintsXMLFile.Close();

            taskPlanningPanel1.SaveCalendars();
        }

        private void SetBlackTheme()
        {
            this.BackColor = BlackTheme.ColorDarkGray;
            this.ForeColor = BlackTheme.ColorText;
            // Apply Black Theme
            BlackTheme.ApplyTheme(this);

            foreach (var control in toolStripMain.Items)
            {
                if (control.GetType() == typeof(ToolStripButton))
                {
                    ToolStripButton button = (ToolStripButton)control;
                    button.ForeColor = Settings.Default.foreColor;
                }
            }

            // Manualy fixes
            statusStrip1.BackColor = BlackTheme.ColorDarkGray;


            // TODO 2
            taskPlanningPanel1.Dock = DockStyle.Fill;
            sprintGridPanel1.Dock = DockStyle.Fill;
            tasksGridPanel1.Dock = DockStyle.Fill;
            //toolStripButtonTask.Checked = true;
            projectGridPanel1.Dock = DockStyle.Fill;
            //projectsGridPanel1.BringToFront();
            //toolStripButtonProject.Checked = true;
            sprintKanbanPanel1.Dock = DockStyle.Fill;
            sprintKanbanPanel1.BringToFront();
            toolStripButtonKanban.Checked = true;

            toolStripMain.Height = 95;
            toolStripMain.Padding = new Padding(5, 5, 15, 0);
            //toolStripMain.BackColor = BlackTheme.ColorDarkGray;
        }

        #region Methods

        private void SetActiveButton(ToolStripButton button)
        {
            toolStripButtonKanban.Checked = false;
            toolStripButtonProject.Checked = false;
            toolStripButtonSprint.Checked = false;
            toolStripButtonTask.Checked = false;
            toolStripButtonGantt.Checked = false;
            button.Checked = true;
        }

        #endregion

        #region Events

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void toolStripButtonKanban_Click(object sender, EventArgs e)
        {
            sprintKanbanPanel1.Refresh();
            sprintKanbanPanel1.BringToFront();
            SetActiveButton((ToolStripButton)sender);
        }

        private void toolStripButtonGant_Click(object sender, EventArgs e)
        {
            SetActiveButton((ToolStripButton)sender);
        }

        private void toolStripButtonTask_Click(object sender, EventArgs e)
        {
            tasksGridPanel1.Refresh();
            tasksGridPanel1.Dock = DockStyle.Fill;
            tasksGridPanel1.BringToFront();
            SetActiveButton((ToolStripButton)sender);
        }

        private void toolStripButtonSprint_Click(object sender, EventArgs e)
        {
            sprintGridPanel1.Dock = DockStyle.Fill;
            sprintGridPanel1.BringToFront();
            SetActiveButton((ToolStripButton)sender);
        }

        private void toolStripButtonProject_Click(object sender, EventArgs e)
        {
            projectGridPanel1.Dock = DockStyle.Fill;
            projectGridPanel1.BringToFront();
            SetActiveButton((ToolStripButton)sender);
        }

        private void toolStripButtonTimePlanning_Click(object sender, EventArgs e)
        {
            taskPlanningPanel1.Refresh();
            taskPlanningPanel1.BringToFront();
            SetActiveButton((ToolStripButton)sender);
        }

        private void toolStripRevert_Click(object sender, EventArgs e)
        {
            ReadXMLFiles();
        }



        #endregion

    }
}
