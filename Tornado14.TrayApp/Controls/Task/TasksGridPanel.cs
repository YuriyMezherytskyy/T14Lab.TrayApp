using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tornado14Lab.Utils.Text;
using Tornado14Lab.Utils.NativeTheme;
using Tornado14.TrayApp.Properties;
using Tornado14Lab.Utils;
using System.IO;
using Tornado14.Task;
using Tornado14Lab.Utils.DataGridViewHelper;
using Tornado14Lab.Utils.File;
using System.Diagnostics;

namespace Tornado14.TrayApp.Controls.Task
{


    public partial class TasksGridPanel : StandardGridPanel, IStandardPanel
    {

        internal void SetBindingSources(object projectDataSource, object sprintDataSource, object taskDataSource)
        {
            this.projectBindingSource.DataSource = projectDataSource;
            this.sprintBindingSource.DataSource = sprintDataSource;
            this.todoBindingSource.DataSource = taskDataSource;

            taskSearchPanel1.SetProjectBindingSource(projectDataSource);
            taskSearchPanel1.SetSprintBindingSource(sprintDataSource);
            taskSearchPanel1.SetTodoBindingSource(taskDataSource);
            taskEditor1.SetBindingSources(projectBindingSource, sprintBindingSource, taskDataSource);
            taskSearchPanel1.TodoBindingSource.CurrentChanged += TodoBindingSource_CurrentItemChanged;
        }


        public TasksGridPanel()
        {
            InitializeComponent();

            // Init base panel
            panelTaskDetails.Dock = DockStyle.Fill;
            panelTaskDetails.BringToFront();

            taskSearchPanel1.Grid.CellClick += Grid_CellClick;
            taskSearchPanel1.TodoBindingSource.CurrentChanged += TodoBindingSource_CurrentItemChanged;
            
            todoBindingSource.CurrentItemChanged += TodoBindingSource_CurrentItemChanged1;
            BlackTheme.ApplyTheme(this);
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            taskSearchPanel1.Width = (this.Width / 2) + this.Width / 4;
            taskSearchPanel1.splitContainer1.SplitterDistance = 250;
        }

        private void TodoBindingSource_CurrentItemChanged1(object sender, EventArgs e)
        {
            taskSearchPanel1.TodoBindingSource.Position = todoBindingSource.Position;
        }


        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            todoBindingSource.Position = taskSearchPanel1.TodoBindingSource.Position;
        }

        private void TodoBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            todoBindingSource.Position = taskSearchPanel1.TodoBindingSource.Position;
        }

        #region Events

        private void todoBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            // Check if the data source has been updated, and that no error has occured.
            if (e.BindingCompleteContext ==
                BindingCompleteContext.DataSourceUpdate && e.Exception == null)

                // If not, end the current edit.
                e.Binding.BindingManagerBase.EndCurrentEdit();
        }

        private void toolStripButtonDocumentation_Click(object sender, EventArgs e)
        {
            panelTaskDetails.Dock = DockStyle.Fill;
            panelTaskDetails.BringToFront();
            SetActiveButton((ToolStripButton)sender);
        }

        private void SetActiveButton(ToolStripButton button)
        {
            button.Checked = true;
        }

        private void toolStripButtonFeatures_Click(object sender, EventArgs e)
        {
            SetActiveButton((ToolStripButton)sender);
        }

        private void todoBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Todo todo = (Todo)todoBindingSource.Current;
            if (todo != null)
            {
                taskEditor1.BindingSource.Position = todoBindingSource.Position;
            }
        }

        private void toolStripButtonFiles_Click(object sender, EventArgs e)
        {
            Todo currentTask = (Todo)todoBindingSource.Current;
            if (currentTask.OpenFilesFolder(Settings.Default.DataFolder))
            {
                HasChanges = true;
            }
        }

        #endregion

        #region Methods

        #endregion

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Todo currentTask = (Todo)todoBindingSource.Current;
            if (currentTask.OpenFilesFolder(Settings.Default.DataFolder))
            {
                HasChanges = true;
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Todo currentTask = (Todo)todoBindingSource.Current;
            if (currentTask.OpenFilesFolder(Settings.Default.DataFolder))
            {
                HasChanges = true;
            }
        }


        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Todo currentTask = (Todo)todoBindingSource.Current;
            if (currentTask.OpenFilesFolder(Settings.Default.DataFolder))
            {
                HasChanges = true;
            }
        }
    }
}
