namespace Tornado14.TrayApp
{
    partial class AddNewTasks
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewTasks));
      this.panelNewTask = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.panel5 = new System.Windows.Forms.Panel();
      this.dataGridView2 = new System.Windows.Forms.DataGridView();
      this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.shortDescriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.sprintBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.label2 = new System.Windows.Forms.Label();
      this.splitter2 = new System.Windows.Forms.Splitter();
      this.panel4 = new System.Windows.Forms.Panel();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.shortDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.label1 = new System.Windows.Forms.Label();
      this.splitter3 = new System.Windows.Forms.Splitter();
      this.panel6 = new System.Windows.Forms.Panel();
      this.button1 = new System.Windows.Forms.Button();
      this.splitter1 = new System.Windows.Forms.Splitter();
      this.spelledMultilineTextbox1 = new Tornado14.TrayApp.Controls.SpelledMultilineTextbox();
      this.todoBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.panel1 = new System.Windows.Forms.Panel();
      this.panelNewTask.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel5.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).BeginInit();
      this.panel4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
      this.panel6.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panelNewTask
      // 
      this.panelNewTask.Controls.Add(this.panel2);
      this.panelNewTask.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelNewTask.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.panelNewTask.Location = new System.Drawing.Point(5, 5);
      this.panelNewTask.Margin = new System.Windows.Forms.Padding(2);
      this.panelNewTask.Name = "panelNewTask";
      this.panelNewTask.Size = new System.Drawing.Size(1178, 613);
      this.panelNewTask.TabIndex = 18;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.panel3);
      this.panel2.Controls.Add(this.splitter1);
      this.panel2.Controls.Add(this.spelledMultilineTextbox1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Margin = new System.Windows.Forms.Padding(2);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(1178, 613);
      this.panel2.TabIndex = 2;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.panel5);
      this.panel3.Controls.Add(this.splitter2);
      this.panel3.Controls.Add(this.panel4);
      this.panel3.Controls.Add(this.splitter3);
      this.panel3.Controls.Add(this.panel6);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel3.Location = new System.Drawing.Point(538, 0);
      this.panel3.Margin = new System.Windows.Forms.Padding(2);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(640, 613);
      this.panel3.TabIndex = 2;
      // 
      // panel5
      // 
      this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
      this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel5.Controls.Add(this.dataGridView2);
      this.panel5.Controls.Add(this.label2);
      this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel5.Location = new System.Drawing.Point(0, 329);
      this.panel5.Margin = new System.Windows.Forms.Padding(2);
      this.panel5.Name = "panel5";
      this.panel5.Size = new System.Drawing.Size(640, 284);
      this.panel5.TabIndex = 2;
      // 
      // dataGridView2
      // 
      this.dataGridView2.AllowUserToAddRows = false;
      this.dataGridView2.AllowUserToDeleteRows = false;
      this.dataGridView2.AutoGenerateColumns = false;
      this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.shortDescriptionDataGridViewTextBoxColumn1});
      this.dataGridView2.DataSource = this.sprintBindingSource;
      this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView2.Location = new System.Drawing.Point(0, 21);
      this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
      this.dataGridView2.Name = "dataGridView2";
      this.dataGridView2.RowTemplate.Height = 24;
      this.dataGridView2.Size = new System.Drawing.Size(638, 261);
      this.dataGridView2.TabIndex = 1;
      this.dataGridView2.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
      // 
      // idDataGridViewTextBoxColumn1
      // 
      this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
      this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
      this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
      // 
      // shortDescriptionDataGridViewTextBoxColumn1
      // 
      this.shortDescriptionDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.shortDescriptionDataGridViewTextBoxColumn1.DataPropertyName = "ShortDescription";
      this.shortDescriptionDataGridViewTextBoxColumn1.HeaderText = "ShortDescription";
      this.shortDescriptionDataGridViewTextBoxColumn1.Name = "shortDescriptionDataGridViewTextBoxColumn1";
      // 
      // sprintBindingSource
      // 
      this.sprintBindingSource.DataSource = typeof(Tornado14.Task.Sprint);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Dock = System.Windows.Forms.DockStyle.Top;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(0, 0);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 4);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(59, 21);
      this.label2.TabIndex = 16;
      this.label2.Text = "Sprints";
      // 
      // splitter2
      // 
      this.splitter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
      this.splitter2.Location = new System.Drawing.Point(0, 325);
      this.splitter2.Margin = new System.Windows.Forms.Padding(2);
      this.splitter2.Name = "splitter2";
      this.splitter2.Size = new System.Drawing.Size(640, 4);
      this.splitter2.TabIndex = 1;
      this.splitter2.TabStop = false;
      // 
      // panel4
      // 
      this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
      this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel4.Controls.Add(this.dataGridView1);
      this.panel4.Controls.Add(this.label1);
      this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel4.Location = new System.Drawing.Point(0, 42);
      this.panel4.Margin = new System.Windows.Forms.Padding(2);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(640, 283);
      this.panel4.TabIndex = 0;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.shortDescriptionDataGridViewTextBoxColumn});
      this.dataGridView1.DataSource = this.projectBindingSource;
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView1.Location = new System.Drawing.Point(0, 21);
      this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.Size = new System.Drawing.Size(638, 260);
      this.dataGridView1.TabIndex = 0;
      this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
      // 
      // idDataGridViewTextBoxColumn
      // 
      this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
      this.idDataGridViewTextBoxColumn.HeaderText = "Id";
      this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
      // 
      // shortDescriptionDataGridViewTextBoxColumn
      // 
      this.shortDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.shortDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ShortDescription";
      this.shortDescriptionDataGridViewTextBoxColumn.HeaderText = "ShortDescription";
      this.shortDescriptionDataGridViewTextBoxColumn.Name = "shortDescriptionDataGridViewTextBoxColumn";
      // 
      // projectBindingSource
      // 
      this.projectBindingSource.DataSource = typeof(Tornado14.Task.Project);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 4);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(65, 21);
      this.label1.TabIndex = 15;
      this.label1.Text = "Projects";
      // 
      // splitter3
      // 
      this.splitter3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
      this.splitter3.Location = new System.Drawing.Point(0, 38);
      this.splitter3.Margin = new System.Windows.Forms.Padding(2);
      this.splitter3.Name = "splitter3";
      this.splitter3.Size = new System.Drawing.Size(640, 4);
      this.splitter3.TabIndex = 18;
      this.splitter3.TabStop = false;
      // 
      // panel6
      // 
      this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
      this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel6.Controls.Add(this.button1);
      this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel6.Location = new System.Drawing.Point(0, 0);
      this.panel6.Margin = new System.Windows.Forms.Padding(2);
      this.panel6.Name = "panel6";
      this.panel6.Size = new System.Drawing.Size(640, 38);
      this.panel6.TabIndex = 19;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(4, 4);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(94, 29);
      this.button1.TabIndex = 18;
      this.button1.Text = "Add Tasks";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // splitter1
      // 
      this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.splitter1.Location = new System.Drawing.Point(534, 0);
      this.splitter1.Margin = new System.Windows.Forms.Padding(2);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new System.Drawing.Size(4, 613);
      this.splitter1.TabIndex = 1;
      this.splitter1.TabStop = false;
      // 
      // spelledMultilineTextbox1
      // 
      this.spelledMultilineTextbox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.spelledMultilineTextbox1.Dock = System.Windows.Forms.DockStyle.Left;
      this.spelledMultilineTextbox1.Location = new System.Drawing.Point(0, 0);
      this.spelledMultilineTextbox1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
      this.spelledMultilineTextbox1.Name = "spelledMultilineTextbox1";
      this.spelledMultilineTextbox1.ProjectIdList = ((System.Collections.Generic.List<string>)(resources.GetObject("spelledMultilineTextbox1.ProjectIdList")));
      this.spelledMultilineTextbox1.Size = new System.Drawing.Size(534, 613);
      this.spelledMultilineTextbox1.SprintIdList = ((System.Collections.Generic.List<string>)(resources.GetObject("spelledMultilineTextbox1.SprintIdList")));
      this.spelledMultilineTextbox1.TabIndex = 0;
      // 
      // todoBindingSource
      // 
      this.todoBindingSource.DataSource = typeof(Tornado14.Task.Todo);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel1.Controls.Add(this.panelNewTask);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Padding = new System.Windows.Forms.Padding(5);
      this.panel1.Size = new System.Drawing.Size(1190, 625);
      this.panel1.TabIndex = 19;
      // 
      // AddNewTasks
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.panel1);
      this.Name = "AddNewTasks";
      this.Size = new System.Drawing.Size(1190, 625);
      this.panelNewTask.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.panel5.ResumeLayout(false);
      this.panel5.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).EndInit();
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
      this.panel6.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).EndInit();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNewTask;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Splitter splitter1;
        private Controls.SpelledMultilineTextbox spelledMultilineTextbox1;
        private System.Windows.Forms.BindingSource todoBindingSource;
        private System.Windows.Forms.BindingSource sprintBindingSource;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortDescriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortDescriptionDataGridViewTextBoxColumn;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
    }
}
