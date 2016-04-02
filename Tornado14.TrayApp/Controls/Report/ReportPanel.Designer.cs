namespace Tornado14.TrayApp.Controls.Task
{
    partial class ReportPanel
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonReport = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.todoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sprintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkedListBoxSprintFilter = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkedListBoxStatus = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel6.Controls.Add(this.buttonReport);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 287);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(904, 153);
            this.panel6.TabIndex = 50;
            // 
            // buttonReport
            // 
            this.buttonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.buttonReport.Location = new System.Drawing.Point(8, 6);
            this.buttonReport.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(146, 29);
            this.buttonReport.TabIndex = 63;
            this.buttonReport.Text = "Create Report";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 287);
            this.splitter2.Margin = new System.Windows.Forms.Padding(2);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(904, 2);
            this.splitter2.TabIndex = 55;
            this.splitter2.TabStop = false;
            // 
            // todoBindingSource
            // 
            this.todoBindingSource.DataSource = typeof(Tornado14.Task.Todo);
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(Tornado14.Task.Project);
            // 
            // sprintBindingSource
            // 
            this.sprintBindingSource.DataSource = typeof(Tornado14.Task.Sprint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.checkedListBoxSprintFilter);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(4, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(433, 287);
            this.panel4.TabIndex = 47;
            // 
            // checkedListBoxSprintFilter
            // 
            this.checkedListBoxSprintFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.checkedListBoxSprintFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxSprintFilter.CheckOnClick = true;
            this.checkedListBoxSprintFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxSprintFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.checkedListBoxSprintFilter.FormattingEnabled = true;
            this.checkedListBoxSprintFilter.Location = new System.Drawing.Point(0, 21);
            this.checkedListBoxSprintFilter.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBoxSprintFilter.Name = "checkedListBoxSprintFilter";
            this.checkedListBoxSprintFilter.Size = new System.Drawing.Size(433, 266);
            this.checkedListBoxSprintFilter.TabIndex = 45;
            this.checkedListBoxSprintFilter.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxSprintFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 50;
            this.label1.Text = "Sprint filter";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.splitter1.Location = new System.Drawing.Point(437, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 287);
            this.splitter1.TabIndex = 45;
            this.splitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkedListBoxStatus);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(439, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(461, 287);
            this.panel3.TabIndex = 46;
            // 
            // checkedListBoxStatus
            // 
            this.checkedListBoxStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.checkedListBoxStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.checkedListBoxStatus.FormattingEnabled = true;
            this.checkedListBoxStatus.Items.AddRange(new object[] {
            "Planned",
            "Today",
            "Progress",
            "Test",
            "Done"});
            this.checkedListBoxStatus.Location = new System.Drawing.Point(0, 21);
            this.checkedListBoxStatus.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBoxStatus.Name = "checkedListBoxStatus";
            this.checkedListBoxStatus.Size = new System.Drawing.Size(461, 266);
            this.checkedListBoxStatus.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 21);
            this.label9.TabIndex = 50;
            this.label9.Text = "Task filter";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.panel1.Size = new System.Drawing.Size(904, 287);
            this.panel1.TabIndex = 48;
            // 
            // ReportPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReportPanel";
            this.Size = new System.Drawing.Size(904, 440);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource todoBindingSource;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.BindingSource sprintBindingSource;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckedListBox checkedListBoxSprintFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckedListBox checkedListBoxStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
    }
}
