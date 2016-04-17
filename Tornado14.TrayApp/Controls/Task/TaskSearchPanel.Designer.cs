namespace Tornado14.TrayApp.Controls.Task
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panelColumn1 = new System.Windows.Forms.Panel();
            this.labelColumn1 = new System.Windows.Forms.Label();
            this.panelColumnAvailableFilter = new System.Windows.Forms.Panel();
            this.labelColumn2 = new System.Windows.Forms.Label();
            this.dataGridViewTodos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectPidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AdditionalField1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdditionalField2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdditionalField3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdditionalField4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdditionalField5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sprintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
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
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 8;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
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
            this.splitContainer2.Size = new System.Drawing.Size(200, 674);
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
            this.panelColumn1.Size = new System.Drawing.Size(188, 288);
            this.panelColumn1.TabIndex = 3;
            this.panelColumn1.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragDrop);
            this.panelColumn1.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragEnter);
            // 
            // labelColumn1
            // 
            this.labelColumn1.AutoSize = true;
            this.labelColumn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelColumn1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColumn1.ForeColor = System.Drawing.Color.White;
            this.labelColumn1.Location = new System.Drawing.Point(5, 5);
            this.labelColumn1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 10);
            this.labelColumn1.Name = "labelColumn1";
            this.labelColumn1.Size = new System.Drawing.Size(91, 21);
            this.labelColumn1.TabIndex = 2;
            this.labelColumn1.Text = "Active Filter";
            this.labelColumn1.Click += new System.EventHandler(this.labelColumn1_Click);
            // 
            // panelColumnAvailableFilter
            // 
            this.panelColumnAvailableFilter.AllowDrop = true;
            this.panelColumnAvailableFilter.AutoScroll = true;
            this.panelColumnAvailableFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelColumnAvailableFilter.Location = new System.Drawing.Point(5, 26);
            this.panelColumnAvailableFilter.Margin = new System.Windows.Forms.Padding(2);
            this.panelColumnAvailableFilter.Name = "panelColumnAvailableFilter";
            this.panelColumnAvailableFilter.Padding = new System.Windows.Forms.Padding(4, 0, 4, 1);
            this.panelColumnAvailableFilter.Size = new System.Drawing.Size(188, 316);
            this.panelColumnAvailableFilter.TabIndex = 4;
            this.panelColumnAvailableFilter.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragDrop);
            this.panelColumnAvailableFilter.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragEnter);
            // 
            // labelColumn2
            // 
            this.labelColumn2.AutoSize = true;
            this.labelColumn2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelColumn2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColumn2.ForeColor = System.Drawing.Color.White;
            this.labelColumn2.Location = new System.Drawing.Point(5, 5);
            this.labelColumn2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 4);
            this.labelColumn2.Name = "labelColumn2";
            this.labelColumn2.Size = new System.Drawing.Size(109, 21);
            this.labelColumn2.TabIndex = 3;
            this.labelColumn2.Text = "Available filter";
            this.labelColumn2.Click += new System.EventHandler(this.labelColumn2_Click);
            // 
            // dataGridViewTodos
            // 
            this.dataGridViewTodos.AllowUserToResizeRows = false;
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
            this.dataGridViewTodos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewTodos.Location = new System.Drawing.Point(5, 26);
            this.dataGridViewTodos.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTodos.Name = "dataGridViewTodos";
            this.dataGridViewTodos.RowTemplate.Height = 24;
            this.dataGridViewTodos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTodos.Size = new System.Drawing.Size(843, 641);
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
            // todoBindingSource
            // 
            this.todoBindingSource.DataSource = typeof(Tornado14.Task.Todo);
            this.todoBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.todoBindingSource_BindingComplete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtered data";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AdditionalField1";
            this.dataGridViewTextBoxColumn1.HeaderText = "AdditionalField1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AdditionalField2";
            this.dataGridViewTextBoxColumn2.HeaderText = "AdditionalField2";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AdditionalField3";
            this.dataGridViewTextBoxColumn3.HeaderText = "AdditionalField3";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AdditionalField4";
            this.dataGridViewTextBoxColumn4.HeaderText = "AdditionalField4";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AdditionalField5";
            this.dataGridViewTextBoxColumn5.HeaderText = "AdditionalField5";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource todoBindingSource;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.BindingSource sprintBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panelColumn1;
        private System.Windows.Forms.Label labelColumn1;
        private System.Windows.Forms.Panel panelColumnAvailableFilter;
        private System.Windows.Forms.Label labelColumn2;
        private System.Windows.Forms.DataGridView dataGridViewTodos;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.SplitContainer splitContainer1;
    }
}
