namespace Tornado14.TrayApp.Controls
{
    partial class ProjectGridPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectGridPanel));
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sprintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.todoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelProjects = new System.Windows.Forms.Panel();
            this.panelProjectsGray = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewProjects = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.filesFolderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.projectFeaturesPanel = new Tornado14.TrayApp.Controls.ProjectFeaturesPanel();
            this.reportPanel = new Tornado14.TrayApp.Controls.ReportPanel();
            this.projectDetailsPanel = new Tornado14.TrayApp.Controls.ProjectDetailsPanel();
            this.projectDeployApplicationPanel = new Tornado14.TrayApp.Controls.ProjectDeployApplicationPanel();
            this.projectDevelopPanel = new Tornado14.TrayApp.Controls.ProjectDevelopPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDetails = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonReport = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDevelop = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).BeginInit();
            this.panelProjects.SuspendLayout();
            this.panelProjectsGray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).BeginInit();
            this.panel8.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(Tornado14.Task.Project);
            this.projectBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.BindingSource_BindingComplete);
            this.projectBindingSource.PositionChanged += new System.EventHandler(this.BindingSource_PositionChanged);
            // 
            // sprintBindingSource
            // 
            this.sprintBindingSource.DataSource = typeof(Tornado14.Task.Sprint);
            // 
            // todoBindingSource
            // 
            this.todoBindingSource.DataSource = typeof(Tornado14.Task.Todo);
            // 
            // panelProjects
            // 
            this.panelProjects.Controls.Add(this.panelProjectsGray);
            this.panelProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProjects.Location = new System.Drawing.Point(0, 0);
            this.panelProjects.Margin = new System.Windows.Forms.Padding(0);
            this.panelProjects.Name = "panelProjects";
            this.panelProjects.Size = new System.Drawing.Size(915, 570);
            this.panelProjects.TabIndex = 3;
            // 
            // panelProjectsGray
            // 
            this.panelProjectsGray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelProjectsGray.Controls.Add(this.splitContainer1);
            this.panelProjectsGray.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProjectsGray.Location = new System.Drawing.Point(0, 0);
            this.panelProjectsGray.Margin = new System.Windows.Forms.Padding(2);
            this.panelProjectsGray.Name = "panelProjectsGray";
            this.panelProjectsGray.Size = new System.Drawing.Size(915, 570);
            this.panelProjectsGray.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewProjects);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.panel8);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(915, 570);
            this.splitContainer1.SplitterDistance = 528;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 2;
            // 
            // dataGridViewProjects
            // 
            this.dataGridViewProjects.AutoGenerateColumns = false;
            this.dataGridViewProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.shortDescriptionDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.filesFolderDataGridViewTextBoxColumn,
            this.pIdDataGridViewTextBoxColumn});
            this.dataGridViewProjects.DataSource = this.projectBindingSource;
            this.dataGridViewProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProjects.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProjects.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewProjects.Name = "dataGridViewProjects";
            this.dataGridViewProjects.RowTemplate.Height = 24;
            this.dataGridViewProjects.Size = new System.Drawing.Size(528, 570);
            this.dataGridViewProjects.TabIndex = 0;
            this.dataGridViewProjects.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProjects_CellValueChanged);
            this.dataGridViewProjects.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewProjects_DefaultValuesNeeded);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 130;
            // 
            // shortDescriptionDataGridViewTextBoxColumn
            // 
            this.shortDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ShortDescription";
            this.shortDescriptionDataGridViewTextBoxColumn.HeaderText = "ShortDescription";
            this.shortDescriptionDataGridViewTextBoxColumn.Name = "shortDescriptionDataGridViewTextBoxColumn";
            this.shortDescriptionDataGridViewTextBoxColumn.Width = 300;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 200;
            // 
            // filesFolderDataGridViewTextBoxColumn
            // 
            this.filesFolderDataGridViewTextBoxColumn.DataPropertyName = "FilesFolder";
            this.filesFolderDataGridViewTextBoxColumn.HeaderText = "Files";
            this.filesFolderDataGridViewTextBoxColumn.Name = "filesFolderDataGridViewTextBoxColumn";
            this.filesFolderDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.filesFolderDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.filesFolderDataGridViewTextBoxColumn.Visible = false;
            // 
            // pIdDataGridViewTextBoxColumn
            // 
            this.pIdDataGridViewTextBoxColumn.DataPropertyName = "pId";
            this.pIdDataGridViewTextBoxColumn.HeaderText = "pId";
            this.pIdDataGridViewTextBoxColumn.Name = "pIdDataGridViewTextBoxColumn";
            this.pIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel8.Controls.Add(this.projectFeaturesPanel);
            this.panel8.Controls.Add(this.reportPanel);
            this.panel8.Controls.Add(this.projectDetailsPanel);
            this.panel8.Controls.Add(this.projectDeployApplicationPanel);
            this.panel8.Controls.Add(this.projectDevelopPanel);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 39);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.panel8.Size = new System.Drawing.Size(384, 531);
            this.panel8.TabIndex = 10;
            // 
            // projectFeaturesPanel1
            // 
            this.projectFeaturesPanel.Location = new System.Drawing.Point(4, 370);
            this.projectFeaturesPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.projectFeaturesPanel.Name = "projectFeaturesPanel1";
            this.projectFeaturesPanel.Size = new System.Drawing.Size(374, 84);
            this.projectFeaturesPanel.TabIndex = 7;
            // 
            // reportPanel1
            // 
            this.reportPanel.Location = new System.Drawing.Point(4, 237);
            this.reportPanel.Margin = new System.Windows.Forms.Padding(2);
            this.reportPanel.Name = "reportPanel1";
            this.reportPanel.Size = new System.Drawing.Size(375, 96);
            this.reportPanel.TabIndex = 6;
            // 
            // projectDetailsPanel1
            // 
            this.projectDetailsPanel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectDetailsPanel.Location = new System.Drawing.Point(4, 15);
            this.projectDetailsPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.projectDetailsPanel.Name = "projectDetailsPanel1";
            this.projectDetailsPanel.Size = new System.Drawing.Size(375, 54);
            this.projectDetailsPanel.TabIndex = 3;
            // 
            // projectDeployApplicationPanel1
            // 
            this.projectDeployApplicationPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectDeployApplicationPanel.Location = new System.Drawing.Point(4, 176);
            this.projectDeployApplicationPanel.Margin = new System.Windows.Forms.Padding(4);
            this.projectDeployApplicationPanel.Name = "projectDeployApplicationPanel1";
            this.projectDeployApplicationPanel.Size = new System.Drawing.Size(375, 54);
            this.projectDeployApplicationPanel.TabIndex = 5;
            // 
            // projectDevelopPanel1
            // 
            this.projectDevelopPanel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectDevelopPanel.Location = new System.Drawing.Point(4, 96);
            this.projectDevelopPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.projectDevelopPanel.Name = "projectDevelopPanel1";
            this.projectDevelopPanel.Size = new System.Drawing.Size(375, 54);
            this.projectDevelopPanel.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDetails,
            this.toolStripButtonReport,
            this.toolStripButtonDevelop});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(384, 39);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonDetails
            // 
            this.toolStripButtonDetails.Checked = true;
            this.toolStripButtonDetails.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.toolStripButtonDetails.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDetails.Image")));
            this.toolStripButtonDetails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDetails.Name = "toolStripButtonDetails";
            this.toolStripButtonDetails.Size = new System.Drawing.Size(78, 36);
            this.toolStripButtonDetails.Text = "Details";
            this.toolStripButtonDetails.Click += new System.EventHandler(this.toolStripDetails_Click);
            // 
            // toolStripButtonReport
            // 
            this.toolStripButtonReport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonReport.Image")));
            this.toolStripButtonReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReport.Name = "toolStripButtonReport";
            this.toolStripButtonReport.Size = new System.Drawing.Size(78, 36);
            this.toolStripButtonReport.Text = "Report";
            this.toolStripButtonReport.Click += new System.EventHandler(this.toolStripButtonReport_Click);
            // 
            // toolStripButtonDevelop
            // 
            this.toolStripButtonDevelop.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButtonDevelop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDevelop.Image")));
            this.toolStripButtonDevelop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDevelop.Name = "toolStripButtonDevelop";
            this.toolStripButtonDevelop.Size = new System.Drawing.Size(86, 36);
            this.toolStripButtonDevelop.Text = "Develop";
            this.toolStripButtonDevelop.Click += new System.EventHandler(this.toolStripButtonDevelop_Click);
            // 
            // ProjectGridPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelProjects);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProjectGridPanel";
            this.Size = new System.Drawing.Size(915, 570);
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).EndInit();
            this.panelProjects.ResumeLayout(false);
            this.panelProjectsGray.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).EndInit();
            this.panel8.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.Panel panelProjects;
        private System.Windows.Forms.Panel panelProjectsGray;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dataGridViewProjects;
        private ProjectDetailsPanel projectDetailsPanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonDetails;
        private System.Windows.Forms.ToolStripButton toolStripButtonDevelop;
        private ProjectDeployApplicationPanel projectDeployApplicationPanel;
        private ProjectDevelopPanel projectDevelopPanel;
        private System.Windows.Forms.BindingSource sprintBindingSource;
        private System.Windows.Forms.BindingSource todoBindingSource;
        private System.Windows.Forms.ToolStripButton toolStripButtonReport;
        private ReportPanel reportPanel;
        private ProjectFeaturesPanel projectFeaturesPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn filesFolderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIdDataGridViewTextBoxColumn;
    }
}
