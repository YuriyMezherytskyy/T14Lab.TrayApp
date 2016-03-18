using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tornado14.TrayApp.Controls
{
    public partial class TaskPlanningPanel : StandardGridPanel, IStandardPanel
    {

        public BindingSource TodoBindingSource
        {
            get
            {
                return todoBindingSource;
            }
            set
            {
                todoBindingSource = value;
            }
        }

        internal void TodoBindingSourceDataSource(object dataSource)
        {
            this.TodoBindingSource.DataSource = dataSource;
            taskSearchPanel1.TodoBindingSource.DataSource = dataSource;
        }

        public BindingSource SprintBindingSource
        {
            get
            {
                return sprintBindingSource;
            }
            set
            {
                sprintBindingSource = value;

            }
        }

        internal void SprintBindingSourceDataSource(object dataSource)
        {
            this.SprintBindingSource.DataSource = dataSource;
            taskSearchPanel1.SprintBindingSource.DataSource = dataSource;
        }

        public BindingSource ProjectBindingSource
        {
            get
            {
                return projectBindingSource;
            }
            set
            {
                projectBindingSource = value;
            }
        }

        internal void ProjectBindingSourceDataSource(object dataSource)
        {
            this.ProjectBindingSource.DataSource = dataSource;
            taskSearchPanel1.ProjectBindingSource.DataSource = dataSource;
        }

        public TaskPlanningPanel()
        {
            InitializeComponent();
        }

        private void monthView1_SelectionChanged(object sender, EventArgs e)
        {
            calendar1.SetViewRange(monthView1.SelectionStart, monthView1.SelectionEnd);
        }

        private void toolStripButtonSaveKanban_Click(object sender, EventArgs e)
        {
            parentPanel.SaveSprints();
            parentPanel.SaveTasks();
        }

        public void SaveToXMLFile()
        {
            parentPanel.SaveSprints();
            parentPanel.SaveTasks();
        }
    }
}
