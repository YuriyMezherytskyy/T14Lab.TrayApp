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
        public BindingSource BindingSource
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
            this.ToolStripButtonSave = toolStripButtonSaveProjects;

            projectDeployApplicationPanel1.Dock = DockStyle.Fill;
            projectDeployApplicationPanel1.BackColor = BlackTheme.ColorDarkGray;
            reportPanel1.Dock = DockStyle.Fill;
            reportPanel1.BackColor = BlackTheme.ColorDarkGray;
            projectFeaturesPanel1.Dock = DockStyle.Fill;
            projectFeaturesPanel1.BackColor = BlackTheme.ColorDarkGray;
            projectDevelopPanel1.Dock = DockStyle.Fill;
            projectDevelopPanel1.BackColor = BlackTheme.ColorDarkGray;
            projectDetailsPanel1.Dock = DockStyle.Fill;
            projectDetailsPanel1.BackColor = BlackTheme.ColorDarkGray;
            projectDetailsPanel1.BringToFront();
            toolStripButtonDetails.Checked = true;

            // Fix Grid Columns
            DataGridViewComboBoxColumn col = (DataGridViewComboBoxColumn)dataGridViewProjects.Columns[typeDataGridViewTextBoxColumn.Name];
            col.DataSource = Enum.GetValues(typeof(ProjectType));
            col.ValueType = typeof(ProjectType);
        }


        #region Events

        private void toolStripButtonSaveProjects_Click(object sender, EventArgs e)
        {
            SaveToXMLFile();
        }

        private void toolStripButtonRestoreProjects_Click(object sender, EventArgs e)
        {
            projectBindingSource.DataSource = SortableBindingListHelper.GetBindingListFromXmlFile<Project>(DataFilePath);
            HasChanges = false;
        }


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

        #endregion

        #region Methods

        public void SaveToXMLFile()
        {
            BindingSource source = (BindingSource)dataGridViewProjects.DataSource;
            string data = XmlSerializationHelper.Serialize(source.List);
            StreamWriter file = new StreamWriter(DataFilePath);
            file.WriteLine(data);
            file.Close();
            HasChanges = false;
        }

        #endregion

        internal void SetDataSource(SortableBindingList<Project> sortableBindingList)
        {
            this.BindingSource.DataSource = sortableBindingList;

            projectDeployApplicationPanel1.ProjectBindingSource.DataSource = this.BindingSource.DataSource;
            projectDeployApplicationPanel1.TodoBindingSource.DataSource = this.todoBindingSource.DataSource;
            projectDeployApplicationPanel1.SprintBindingSourceDataSource = this.sprintBindingSource.DataSource;
            reportPanel1.ProjectBindingSource.DataSource = this.BindingSource.DataSource;
            reportPanel1.TodoBindingSource.DataSource = this.todoBindingSource.DataSource;
            reportPanel1.SprintBindingSourceDataSource = this.sprintBindingSource.DataSource;

            projectDetailsPanel1.ProjectBindingSource.DataSource = this.BindingSource.DataSource;
            projectDevelopPanel1.ProjectBindingSource.DataSource = this.BindingSource.DataSource;
            this.BindingSource.PositionChanged += new EventHandler(BindingSource_PositionChanged);

            projectDetailsPanel1.ProjectBindingSource.ResumeBinding();
            this.BindingSource.BindingComplete += new BindingCompleteEventHandler(BindingSource_BindingComplete);
        }

        void BindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            // Check if the data source has been updated, and that no error has occured.
            if (e.BindingCompleteContext ==
                BindingCompleteContext.DataSourceUpdate && e.Exception == null)

                // If not, end the current edit.
                e.Binding.BindingManagerBase.EndCurrentEdit();
        }

        void BindingSource_PositionChanged(object sender, EventArgs e)
        {
            projectDetailsPanel1.ProjectBindingSource.Position = this.BindingSource.Position;
            projectDevelopPanel1.ProjectBindingSource.Position = this.BindingSource.Position;
            projectDeployApplicationPanel1.ProjectBindingSource.Position = this.BindingSource.Position;
            reportPanel1.ProjectBindingSource.Position = this.BindingSource.Position;
            projectFeaturesPanel1.ProjectFeaturesBindingSource.DataSource = ((Project)this.BindingSource.Current).FeatureList;
        }



        private void projectBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
        }

        private void toolStripDetails_Click(object sender, EventArgs e)
        {
            projectDetailsPanel1.Dock = DockStyle.Fill;
            projectDetailsPanel1.BringToFront();
            SetActiveButton((ToolStripButton)sender);
        }

        private void toolStripButtonDevelop_Click(object sender, EventArgs e)
        {
            projectDevelopPanel1.Dock = DockStyle.Fill;
            projectDevelopPanel1.BringToFront();
            SetActiveButton((ToolStripButton)sender);
        }

        private void toolStripButtonFeatures_Click(object sender, EventArgs e)
        {
            projectFeaturesPanel1.Dock = DockStyle.Fill;
            projectFeaturesPanel1.BringToFront();
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
            reportPanel1.Dock = DockStyle.Fill;
            reportPanel1.BringToFront();
            SetActiveButton((ToolStripButton)sender);
        }

        private void toolStripButtonDeploy_Click(object sender, EventArgs e)
        {
            projectDeployApplicationPanel1.Dock = DockStyle.Fill;
            projectDeployApplicationPanel1.BringToFront();
            SetActiveButton((ToolStripButton)sender);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}
