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
      this.dataGridViewTodos = new System.Windows.Forms.DataGridView();
      this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.shortDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.projectPidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.filesFolderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.PublicTextFilled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.todoBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.comboBoxProject = new System.Windows.Forms.ComboBox();
      this.sprintBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.label1 = new System.Windows.Forms.Label();
      this.labelAllTasks = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodos)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.SuspendLayout();
      // 
      // dataGridViewTodos
      // 
      this.dataGridViewTodos.AutoGenerateColumns = false;
      this.dataGridViewTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewTodos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.shortDescriptionDataGridViewTextBoxColumn,
            this.projectPidDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.filesFolderDataGridViewTextBoxColumn,
            this.pIdDataGridViewTextBoxColumn,
            this.PublicTextFilled});
      this.dataGridViewTodos.DataSource = this.todoBindingSource;
      this.dataGridViewTodos.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridViewTodos.Location = new System.Drawing.Point(0, 0);
      this.dataGridViewTodos.Margin = new System.Windows.Forms.Padding(2);
      this.dataGridViewTodos.Name = "dataGridViewTodos";
      this.dataGridViewTodos.RowTemplate.Height = 24;
      this.dataGridViewTodos.Size = new System.Drawing.Size(702, 674);
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
      // projectBindingSource
      // 
      this.projectBindingSource.DataSource = typeof(Tornado14.Task.Project);
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
      // filesFolderDataGridViewTextBoxColumn
      // 
      this.filesFolderDataGridViewTextBoxColumn.DataPropertyName = "FilesFolder";
      this.filesFolderDataGridViewTextBoxColumn.HeaderText = "FilesFolder";
      this.filesFolderDataGridViewTextBoxColumn.Name = "filesFolderDataGridViewTextBoxColumn";
      // 
      // pIdDataGridViewTextBoxColumn
      // 
      this.pIdDataGridViewTextBoxColumn.DataPropertyName = "pId";
      this.pIdDataGridViewTextBoxColumn.HeaderText = "pId";
      this.pIdDataGridViewTextBoxColumn.Name = "pIdDataGridViewTextBoxColumn";
      this.pIdDataGridViewTextBoxColumn.Visible = false;
      this.pIdDataGridViewTextBoxColumn.Width = 130;
      // 
      // PublicTextFilled
      // 
      this.PublicTextFilled.DataPropertyName = "PublicTextFilled";
      this.PublicTextFilled.HeaderText = "PublicTextFilled";
      this.PublicTextFilled.Name = "PublicTextFilled";
      // 
      // todoBindingSource
      // 
      this.todoBindingSource.DataSource = typeof(Tornado14.Task.Todo);
      this.todoBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.todoBindingSource_BindingComplete);
      // 
      // comboBoxProject
      // 
      this.comboBoxProject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.comboBoxProject.BackColor = System.Drawing.Color.White;
      this.comboBoxProject.DataSource = this.sprintBindingSource;
      this.comboBoxProject.DisplayMember = "Summary";
      this.comboBoxProject.Dock = System.Windows.Forms.DockStyle.Top;
      this.comboBoxProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.comboBoxProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.comboBoxProject.FormattingEnabled = true;
      this.comboBoxProject.IntegralHeight = false;
      this.comboBoxProject.ItemHeight = 20;
      this.comboBoxProject.Location = new System.Drawing.Point(0, 21);
      this.comboBoxProject.Margin = new System.Windows.Forms.Padding(2);
      this.comboBoxProject.Name = "comboBoxProject";
      this.comboBoxProject.Size = new System.Drawing.Size(353, 28);
      this.comboBoxProject.TabIndex = 6;
      this.comboBoxProject.ValueMember = "pId";
      // 
      // sprintBindingSource
      // 
      this.sprintBindingSource.DataSource = typeof(Tornado14.Task.Sprint);
      // 
      // comboBox1
      // 
      this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.comboBox1.BackColor = System.Drawing.Color.White;
      this.comboBox1.DataSource = this.projectBindingSource;
      this.comboBox1.DisplayMember = "ShortDescription";
      this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.IntegralHeight = false;
      this.comboBox1.ItemHeight = 20;
      this.comboBox1.Location = new System.Drawing.Point(0, 70);
      this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(353, 28);
      this.comboBox1.TabIndex = 7;
      this.comboBox1.ValueMember = "pId";
      this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
      this.splitContainer1.Panel1.Controls.Add(this.label1);
      this.splitContainer1.Panel1.Controls.Add(this.comboBoxProject);
      this.splitContainer1.Panel1.Controls.Add(this.labelAllTasks);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.dataGridViewTodos);
      this.splitContainer1.Size = new System.Drawing.Size(1059, 674);
      this.splitContainer1.SplitterDistance = 353;
      this.splitContainer1.TabIndex = 8;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(0, 49);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 4);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(58, 21);
      this.label1.TabIndex = 9;
      this.label1.Text = "Project";
      // 
      // labelAllTasks
      // 
      this.labelAllTasks.AutoSize = true;
      this.labelAllTasks.Dock = System.Windows.Forms.DockStyle.Top;
      this.labelAllTasks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelAllTasks.Location = new System.Drawing.Point(0, 0);
      this.labelAllTasks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 4);
      this.labelAllTasks.Name = "labelAllTasks";
      this.labelAllTasks.Size = new System.Drawing.Size(52, 21);
      this.labelAllTasks.TabIndex = 8;
      this.labelAllTasks.Text = "Sprint";
      // 
      // TaskSearchPanel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.splitContainer1);
      this.Name = "TaskSearchPanel";
      this.Size = new System.Drawing.Size(1059, 674);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodos)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).EndInit();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource todoBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewTodos;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.ComboBox comboBoxProject;
        private System.Windows.Forms.BindingSource sprintBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAllTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn projectPidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filesFolderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PublicTextFilled;
    }
}
