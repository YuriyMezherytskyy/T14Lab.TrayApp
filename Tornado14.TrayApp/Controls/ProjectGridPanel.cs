using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tornado14Lab.Utils;
using System.IO;
using Tornado14Lab.Utils.NativeTheme;
using Tornado14Lab.Utils.DataGridViewHelper;
using Tornado14.Task;
using Tornado14Lab.Utils.Text;

namespace Tornado14.TrayApp.Controls
{
    public partial class ProjectGridPanel : StandardGridPanel, IStandardPanel
    {
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

        public ProjectGridPanel()
        {
            InitializeComponent();
            // Init Base panel

            projectDeployApplicationPanel.Dock = DockStyle.Fill;
            projectDeployApplicationPanel.BackColor = BlackTheme.ColorDarkGray;
            reportPanel.Dock = DockStyle.Fill;
            reportPanel.BackColor = BlackTheme.ColorDarkGray;
            projectFeaturesPanel.Dock = DockStyle.Fill;
            projectFeaturesPanel.BackColor = BlackTheme.ColorDarkGray;
            projectDevelopPanel.Dock = DockStyle.Fill;
            projectDevelopPanel.BackColor = BlackTheme.ColorDarkGray;
            projectDetailsPanel.Dock = DockStyle.Fill;
            projectDetailsPanel.BackColor = BlackTheme.ColorDarkGray;
            projectDetailsPanel.BringToFront();
            toolStripButtonDetails.Checked = true;

            // Fix Grid Columns
            DataGridViewComboBoxColumn col = (DataGridViewComboBoxColumn)dataGridViewProjects.Columns[typeDataGridViewTextBoxColumn.Name];
            col.DataSource = Enum.GetValues(typeof(ProjectType));
            col.ValueType = typeof(ProjectType);
        }

        #region Events


        private void dataGridViewProjects_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            HasChanges = true;
        }

        private void dataGridViewProjects_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            DataGridViewRow lastRow = null;
            if (e.Row.DataGridView.Rows.Count > 1)
            {
                lastRow = e.Row.DataGridView.Rows[e.Row.Index - 1];
            }
            e.Row.Cells[pIdDataGridViewTextBoxColumn.Name].Value = Guid.NewGuid();

            if (lastRow != null)
            {
                e.Row.Cells[idDataGridViewTextBoxColumn.Name].Value = IdGeneration.NextAutoincrementValue(lastRow.Cells[idDataGridViewTextBoxColumn.Name].Value.ToString());
            }
        }

        private void BindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            // Check if the data source has been updated, and that no error has occured.
            if (e.BindingCompleteContext ==
                BindingCompleteContext.DataSourceUpdate && e.Exception == null)

                // If not, end the current edit.
                e.Binding.BindingManagerBase.EndCurrentEdit();
        }

        private void BindingSource_PositionChanged(object sender, EventArgs e)
        {
            projectDetailsPanel.ProjectBindingSource.Position = this.ProjectBindingSource.Position;
            projectDevelopPanel.ProjectBindingSource.Position = this.ProjectBindingSource.Position;
            projectDeployApplicationPanel.ProjectBindingSource.Position = this.ProjectBindingSource.Position;
            reportPanel.ProjectBindingSource.Position = this.ProjectBindingSource.Position;
            projectFeaturesPanel.ProjectFeaturesBindingSource.DataSource = ((Project)this.ProjectBindingSource.Current).FeatureList;
        }

        private void toolStripDetails_Click(object sender, EventArgs e)
        {
            projectDetailsPanel.Dock = DockStyle.Fill;
            projectDetailsPanel.BringToFront();
            SetActiveButton((ToolStripButton)sender);
        }

        private void toolStripButtonDevelop_Click(object sender, EventArgs e)
        {
            projectDevelopPanel.Dock = DockStyle.Fill;
            projectDevelopPanel.BringToFront();
            SetActiveButton((ToolStripButton)sender);
        }

        private void toolStripButtonFeatures_Click(object sender, EventArgs e)
        {
            projectFeaturesPanel.Dock = DockStyle.Fill;
            projectFeaturesPanel.BringToFront();
            SetActiveButton((ToolStripButton)sender);
        }

        private void SetActiveButton(ToolStripButton button)
        {
            toolStripButtonDetails.Checked = false;
            toolStripButtonDevelop.Checked = false;
            toolStripButtonReport.Checked = false;
            button.Checked = true;
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            //((WebBrowser)sender).Document.GetElementsByTagName("body")[0].InnerHtml = ((WebBrowser)sender).Document.GetElementById("spellareawrap").InnerHtml;
            //((WebBrowser)sender).Document.GetElementById("spellareawrap").InnerHtml = "";
        }

        private void toolStripButtonReport_Click(object sender, EventArgs e)
        {
            reportPanel.Dock = DockStyle.Fill;
            reportPanel.BringToFront();
            SetActiveButton((ToolStripButton)sender);
        }

        private void toolStripButtonDeploy_Click(object sender, EventArgs e)
        {
            projectDeployApplicationPanel.Dock = DockStyle.Fill;
            projectDeployApplicationPanel.BringToFront();
            SetActiveButton((ToolStripButton)sender);
        }

        #endregion

        #region Methods

        internal void SetProjectDataSource(SortableBindingList<Project> sortableBindingList)
        {
            this.ProjectBindingSource.DataSource = sortableBindingList;

            projectDeployApplicationPanel.ProjectBindingSource.DataSource = this.ProjectBindingSource.DataSource;
            projectDeployApplicationPanel.TodoBindingSource.DataSource = this.todoBindingSource.DataSource;
            projectDeployApplicationPanel.SprintBindingSourceDataSource = this.sprintBindingSource.DataSource;
            reportPanel.ProjectBindingSource.DataSource = this.ProjectBindingSource.DataSource;
            reportPanel.TodoBindingSource.DataSource = this.todoBindingSource.DataSource;
            reportPanel.SprintBindingSourceDataSource = this.sprintBindingSource.DataSource;

            projectDetailsPanel.ProjectBindingSource.DataSource = this.ProjectBindingSource.DataSource;
            projectDevelopPanel.ProjectBindingSource.DataSource = this.ProjectBindingSource.DataSource;
            this.ProjectBindingSource.PositionChanged += new EventHandler(BindingSource_PositionChanged);

            projectDetailsPanel.ProjectBindingSource.ResumeBinding();
            this.ProjectBindingSource.BindingComplete += new BindingCompleteEventHandler(BindingSource_BindingComplete);
        }

        #endregion

    }
}
