namespace Tornado14.TrayApp.Controls.Task
{
    partial class SprintGridPanel
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
            this.sprintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelSprints = new System.Windows.Forms.Panel();
            this.panelSprintsGray = new System.Windows.Forms.Panel();
            this.dataGridViewSprints = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new Tornado14Lab.Utils.DataGridViewHelper.CalendarColumn();
            this.endDateDataGridViewTextBoxColumn = new Tornado14Lab.Utils.DataGridViewHelper.CalendarColumn();
            this.summaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filesFolderDataGridViewTextBoxColumn = new Tornado14Lab.Utils.DataGridViewHelper.FilePathColumn();
            this.pIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).BeginInit();
            this.panelSprints.SuspendLayout();
            this.panelSprintsGray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSprints)).BeginInit();
            this.SuspendLayout();
            // 
            // sprintBindingSource
            // 
            this.sprintBindingSource.DataSource = typeof(Tornado14.Task.Sprint);
            this.sprintBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.sprintBindingSource_BindingComplete);
            // 
            // panelSprints
            // 
            this.panelSprints.Controls.Add(this.panelSprintsGray);
            this.panelSprints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSprints.Location = new System.Drawing.Point(0, 0);
            this.panelSprints.Margin = new System.Windows.Forms.Padding(0);
            this.panelSprints.Name = "panelSprints";
            this.panelSprints.Size = new System.Drawing.Size(813, 327);
            this.panelSprints.TabIndex = 5;
            // 
            // panelSprintsGray
            // 
            this.panelSprintsGray.Controls.Add(this.dataGridViewSprints);
            this.panelSprintsGray.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSprintsGray.Location = new System.Drawing.Point(0, 0);
            this.panelSprintsGray.Margin = new System.Windows.Forms.Padding(2);
            this.panelSprintsGray.Name = "panelSprintsGray";
            this.panelSprintsGray.Padding = new System.Windows.Forms.Padding(1);
            this.panelSprintsGray.Size = new System.Drawing.Size(813, 327);
            this.panelSprintsGray.TabIndex = 4;
            // 
            // dataGridViewSprints
            // 
            this.dataGridViewSprints.AutoGenerateColumns = false;
            this.dataGridViewSprints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSprints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.shortDescriptionDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.summaryDataGridViewTextBoxColumn,
            this.filesFolderDataGridViewTextBoxColumn,
            this.pIdDataGridViewTextBoxColumn});
            this.dataGridViewSprints.DataSource = this.sprintBindingSource;
            this.dataGridViewSprints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSprints.Location = new System.Drawing.Point(1, 1);
            this.dataGridViewSprints.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSprints.Name = "dataGridViewSprints";
            this.dataGridViewSprints.RowTemplate.Height = 24;
            this.dataGridViewSprints.Size = new System.Drawing.Size(811, 325);
            this.dataGridViewSprints.TabIndex = 0;
            this.dataGridViewSprints.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSprints_CellValueChanged);
            this.dataGridViewSprints.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewSprints_DefaultValuesNeeded);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // shortDescriptionDataGridViewTextBoxColumn
            // 
            this.shortDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ShortDescription";
            this.shortDescriptionDataGridViewTextBoxColumn.HeaderText = "ShortDescription";
            this.shortDescriptionDataGridViewTextBoxColumn.Name = "shortDescriptionDataGridViewTextBoxColumn";
            this.shortDescriptionDataGridViewTextBoxColumn.Width = 300;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.startDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.startDateDataGridViewTextBoxColumn.Width = 130;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.endDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.endDateDataGridViewTextBoxColumn.Width = 130;
            // 
            // summaryDataGridViewTextBoxColumn
            // 
            this.summaryDataGridViewTextBoxColumn.DataPropertyName = "ShortSummary2";
            this.summaryDataGridViewTextBoxColumn.HeaderText = "Summary";
            this.summaryDataGridViewTextBoxColumn.Name = "summaryDataGridViewTextBoxColumn";
            this.summaryDataGridViewTextBoxColumn.Width = 250;
            // 
            // filesFolderDataGridViewTextBoxColumn
            // 
            this.filesFolderDataGridViewTextBoxColumn.DataPropertyName = "FilesFolder";
            this.filesFolderDataGridViewTextBoxColumn.HeaderText = "FilesFolder";
            this.filesFolderDataGridViewTextBoxColumn.Name = "filesFolderDataGridViewTextBoxColumn";
            this.filesFolderDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.filesFolderDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.filesFolderDataGridViewTextBoxColumn.UseFolderSelectionDialog = false;
            this.filesFolderDataGridViewTextBoxColumn.Visible = false;
            // 
            // pIdDataGridViewTextBoxColumn
            // 
            this.pIdDataGridViewTextBoxColumn.DataPropertyName = "pId";
            this.pIdDataGridViewTextBoxColumn.HeaderText = "pId";
            this.pIdDataGridViewTextBoxColumn.Name = "pIdDataGridViewTextBoxColumn";
            this.pIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // SprintGridPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelSprints);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SprintGridPanel";
            this.Size = new System.Drawing.Size(813, 327);
            ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).EndInit();
            this.panelSprints.ResumeLayout(false);
            this.panelSprintsGray.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSprints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource sprintBindingSource;
        private System.Windows.Forms.Panel panelSprints;
        private System.Windows.Forms.Panel panelSprintsGray;
        private System.Windows.Forms.DataGridView dataGridViewSprints;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortDescriptionDataGridViewTextBoxColumn;
        private Tornado14Lab.Utils.DataGridViewHelper.CalendarColumn startDateDataGridViewTextBoxColumn;
        private Tornado14Lab.Utils.DataGridViewHelper.CalendarColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaryDataGridViewTextBoxColumn;
        private Tornado14Lab.Utils.DataGridViewHelper.FilePathColumn filesFolderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIdDataGridViewTextBoxColumn;
    }
}
