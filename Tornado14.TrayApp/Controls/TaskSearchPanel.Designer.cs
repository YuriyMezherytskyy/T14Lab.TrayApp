namespace Tornado14.TrayApp.Controls
{
    partial class TaskSearchPanel
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
      this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.todoBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.splitContainer2 = new System.Windows.Forms.SplitContainer();
      this.panelColumn1 = new System.Windows.Forms.Panel();
      this.labelColumn1 = new System.Windows.Forms.Label();
      this.panelColumnAvailableFilter = new System.Windows.Forms.Panel();
      this.filterShortDescription = new Tornado14.TrayApp.Controls.TextBoxFilter();
      this.filterStatus = new Tornado14.TrayApp.Controls.ComboBoxFilter();
      this.filterSprint = new Tornado14.TrayApp.Controls.ComboBoxFilter();
      this.filterProject = new Tornado14.TrayApp.Controls.ComboBoxFilter();
      this.labelColumn2 = new System.Windows.Forms.Label();
      this.dataGridViewTodos = new System.Windows.Forms.DataGridView();
      this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.shortDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.projectPidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.AdditionalField1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.AdditionalField2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.AdditionalField3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.AdditionalField4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.AdditionalField5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.pIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.label1 = new System.Windows.Forms.Label();
      this.sprintBindingSource = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
      this.splitContainer2.Panel1.SuspendLayout();
      this.splitContainer2.Panel2.SuspendLayout();
      this.splitContainer2.SuspendLayout();
      this.panelColumnAvailableFilter.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodos)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // projectBindingSource
      // 
      this.projectBindingSource.DataSource = typeof(Tornado14.Task.Project);
      // 
      // todoBindingSource
      // 
      this.todoBindingSource.DataSource = typeof(Tornado14.Task.Todo);
      this.todoBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.todoBindingSource_BindingComplete);
      // 
      // splitContainer1
      // 
      this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.dataGridViewTodos);
      this.splitContainer1.Panel2.Controls.Add(this.label1);
      this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
      this.splitContainer1.Size = new System.Drawing.Size(1059, 674);
      this.splitContainer1.SplitterDistance = 353;
      this.splitContainer1.TabIndex = 8;
      // 
      // splitContainer2
      // 
      this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer2.Location = new System.Drawing.Point(0, 0);
      this.splitContainer2.Name = "splitContainer2";
      this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer2.Panel1
      // 
      this.splitContainer2.Panel1.Controls.Add(this.panelColumn1);
      this.splitContainer2.Panel1.Controls.Add(this.labelColumn1);
      this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(5);
      // 
      // splitContainer2.Panel2
      // 
      this.splitContainer2.Panel2.Controls.Add(this.panelColumnAvailableFilter);
      this.splitContainer2.Panel2.Controls.Add(this.labelColumn2);
      this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(5);
      this.splitContainer2.Size = new System.Drawing.Size(353, 674);
      this.splitContainer2.SplitterDistance = 321;
      this.splitContainer2.TabIndex = 13;
      // 
      // panelColumn1
      // 
      this.panelColumn1.AllowDrop = true;
      this.panelColumn1.AutoScroll = true;
      this.panelColumn1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelColumn1.Location = new System.Drawing.Point(5, 26);
      this.panelColumn1.Margin = new System.Windows.Forms.Padding(2);
      this.panelColumn1.Name = "panelColumn1";
      this.panelColumn1.Padding = new System.Windows.Forms.Padding(4, 0, 4, 1);
      this.panelColumn1.Size = new System.Drawing.Size(341, 288);
      this.panelColumn1.TabIndex = 3;
      this.panelColumn1.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragDrop);
      this.panelColumn1.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragEnter);
      // 
      // labelColumn1
      // 
      this.labelColumn1.AutoSize = true;
      this.labelColumn1.Dock = System.Windows.Forms.DockStyle.Top;
      this.labelColumn1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelColumn1.Location = new System.Drawing.Point(5, 5);
      this.labelColumn1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 10);
      this.labelColumn1.Name = "labelColumn1";
      this.labelColumn1.Size = new System.Drawing.Size(91, 21);
      this.labelColumn1.TabIndex = 2;
      this.labelColumn1.Text = "Active Filter";
      // 
      // panelColumnAvailableFilter
      // 
      this.panelColumnAvailableFilter.AllowDrop = true;
      this.panelColumnAvailableFilter.AutoScroll = true;
      this.panelColumnAvailableFilter.Controls.Add(this.filterShortDescription);
      this.panelColumnAvailableFilter.Controls.Add(this.filterStatus);
      this.panelColumnAvailableFilter.Controls.Add(this.filterSprint);
      this.panelColumnAvailableFilter.Controls.Add(this.filterProject);
      this.panelColumnAvailableFilter.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelColumnAvailableFilter.Location = new System.Drawing.Point(5, 26);
      this.panelColumnAvailableFilter.Margin = new System.Windows.Forms.Padding(2);
      this.panelColumnAvailableFilter.Name = "panelColumnAvailableFilter";
      this.panelColumnAvailableFilter.Padding = new System.Windows.Forms.Padding(4, 0, 4, 1);
      this.panelColumnAvailableFilter.Size = new System.Drawing.Size(341, 316);
      this.panelColumnAvailableFilter.TabIndex = 4;
      this.panelColumnAvailableFilter.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragDrop);
      this.panelColumnAvailableFilter.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragEnter);
      // 
      // filterShortDescription
      // 
      this.filterShortDescription.AllowDrag = true;
      this.filterShortDescription.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.filterShortDescription.Dock = System.Windows.Forms.DockStyle.Top;
      this.filterShortDescription.Location = new System.Drawing.Point(4, 180);
      this.filterShortDescription.Name = "filterShortDescription";
      this.filterShortDescription.Size = new System.Drawing.Size(333, 56);
      this.filterShortDescription.TabIndex = 3;
      this.filterShortDescription.TaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
      // 
      // filterStatus
      // 
      this.filterStatus.AllowDrag = true;
      this.filterStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.filterStatus.Dock = System.Windows.Forms.DockStyle.Top;
      this.filterStatus.Location = new System.Drawing.Point(4, 120);
      this.filterStatus.Name = "filterStatus";
      this.filterStatus.Size = new System.Drawing.Size(333, 60);
      this.filterStatus.TabIndex = 2;
      this.filterStatus.TaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
      // 
      // filterSprint
      // 
      this.filterSprint.AllowDrag = true;
      this.filterSprint.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.filterSprint.Dock = System.Windows.Forms.DockStyle.Top;
      this.filterSprint.Location = new System.Drawing.Point(4, 60);
      this.filterSprint.Name = "filterSprint";
      this.filterSprint.Size = new System.Drawing.Size(333, 60);
      this.filterSprint.TabIndex = 1;
      this.filterSprint.TaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
      // 
      // filterProject
      // 
      this.filterProject.AllowDrag = true;
      this.filterProject.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.filterProject.Dock = System.Windows.Forms.DockStyle.Top;
      this.filterProject.Location = new System.Drawing.Point(4, 0);
      this.filterProject.Name = "filterProject";
      this.filterProject.Size = new System.Drawing.Size(333, 60);
      this.filterProject.TabIndex = 0;
      this.filterProject.TaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
      // 
      // labelColumn2
      // 
      this.labelColumn2.AutoSize = true;
      this.labelColumn2.Dock = System.Windows.Forms.DockStyle.Top;
      this.labelColumn2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelColumn2.Location = new System.Drawing.Point(5, 5);
      this.labelColumn2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 4);
      this.labelColumn2.Name = "labelColumn2";
      this.labelColumn2.Size = new System.Drawing.Size(109, 21);
      this.labelColumn2.TabIndex = 3;
      this.labelColumn2.Text = "Available filter";
      // 
      // dataGridViewTodos
      // 
      this.dataGridViewTodos.AutoGenerateColumns = false;
      this.dataGridViewTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewTodos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.shortDescriptionDataGridViewTextBoxColumn,
            this.projectPidDataGridViewTextBoxColumn,
            this.AdditionalField1,
            this.AdditionalField2,
            this.AdditionalField3,
            this.AdditionalField4,
            this.AdditionalField5,
            this.statusDataGridViewTextBoxColumn,
            this.pIdDataGridViewTextBoxColumn});
      this.dataGridViewTodos.DataSource = this.todoBindingSource;
      this.dataGridViewTodos.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridViewTodos.Location = new System.Drawing.Point(5, 26);
      this.dataGridViewTodos.Margin = new System.Windows.Forms.Padding(2);
      this.dataGridViewTodos.Name = "dataGridViewTodos";
      this.dataGridViewTodos.RowTemplate.Height = 24;
      this.dataGridViewTodos.Size = new System.Drawing.Size(690, 641);
      this.dataGridViewTodos.TabIndex = 1;
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
      // projectPidDataGridViewTextBoxColumn
      // 
      this.projectPidDataGridViewTextBoxColumn.DataPropertyName = "ProjectPid";
      this.projectPidDataGridViewTextBoxColumn.DataSource = this.projectBindingSource;
      this.projectPidDataGridViewTextBoxColumn.DisplayMember = "ShortDescription";
      this.projectPidDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.projectPidDataGridViewTextBoxColumn.HeaderText = "Project";
      this.projectPidDataGridViewTextBoxColumn.Name = "projectPidDataGridViewTextBoxColumn";
      this.projectPidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.projectPidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.projectPidDataGridViewTextBoxColumn.ValueMember = "pId";
      this.projectPidDataGridViewTextBoxColumn.Width = 300;
      // 
      // AdditionalField1
      // 
      this.AdditionalField1.DataPropertyName = "AdditionalField1";
      this.AdditionalField1.HeaderText = "AdditionalField1";
      this.AdditionalField1.Name = "AdditionalField1";
      // 
      // AdditionalField2
      // 
      this.AdditionalField2.DataPropertyName = "AdditionalField2";
      this.AdditionalField2.HeaderText = "AdditionalField2";
      this.AdditionalField2.Name = "AdditionalField2";
      // 
      // AdditionalField3
      // 
      this.AdditionalField3.DataPropertyName = "AdditionalField3";
      this.AdditionalField3.HeaderText = "AdditionalField3";
      this.AdditionalField3.Name = "AdditionalField3";
      // 
      // AdditionalField4
      // 
      this.AdditionalField4.DataPropertyName = "AdditionalField4";
      this.AdditionalField4.HeaderText = "AdditionalField4";
      this.AdditionalField4.Name = "AdditionalField4";
      // 
      // AdditionalField5
      // 
      this.AdditionalField5.DataPropertyName = "AdditionalField5";
      this.AdditionalField5.HeaderText = "AdditionalField5";
      this.AdditionalField5.Name = "AdditionalField5";
      // 
      // statusDataGridViewTextBoxColumn
      // 
      this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
      this.statusDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
      this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
      this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.statusDataGridViewTextBoxColumn.Width = 130;
      // 
      // pIdDataGridViewTextBoxColumn
      // 
      this.pIdDataGridViewTextBoxColumn.DataPropertyName = "pId";
      this.pIdDataGridViewTextBoxColumn.HeaderText = "pId";
      this.pIdDataGridViewTextBoxColumn.Name = "pIdDataGridViewTextBoxColumn";
      this.pIdDataGridViewTextBoxColumn.Visible = false;
      this.pIdDataGridViewTextBoxColumn.Width = 130;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(5, 5);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 4);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(96, 21);
      this.label1.TabIndex = 3;
      this.label1.Text = "Filtered data";
      // 
      // sprintBindingSource
      // 
      this.sprintBindingSource.DataSource = typeof(Tornado14.Task.Sprint);
      // 
      // TaskSearchPanel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.splitContainer1);
      this.Name = "TaskSearchPanel";
      this.Size = new System.Drawing.Size(1059, 674);
      ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).EndInit();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.splitContainer2.Panel1.ResumeLayout(false);
      this.splitContainer2.Panel1.PerformLayout();
      this.splitContainer2.Panel2.ResumeLayout(false);
      this.splitContainer2.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
      this.splitContainer2.ResumeLayout(false);
      this.panelColumnAvailableFilter.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodos)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource todoBindingSource;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.BindingSource sprintBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panelColumn1;
        private System.Windows.Forms.Label labelColumn1;
        private System.Windows.Forms.Panel panelColumnAvailableFilter;
        private System.Windows.Forms.Label labelColumn2;
        private ComboBoxFilter filterProject;
        private ComboBoxFilter filterSprint;
        private ComboBoxFilter filterStatus;
        private TextBoxFilter filterShortDescription;
        private System.Windows.Forms.DataGridView dataGridViewTodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn projectPidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdditionalField1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdditionalField2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdditionalField3;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdditionalField4;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdditionalField5;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIdDataGridViewTextBoxColumn;
    }
}
