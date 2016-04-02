namespace Tornado14.TrayApp.Controls.Task
{
    partial class ReportScreen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGetDoneTask = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxHeaders = new System.Windows.Forms.CheckBox();
            this.checkBoxEmptyLines = new System.Windows.Forms.CheckBox();
            this.checkBoxBlackText = new System.Windows.Forms.CheckBox();
            this.checkBoxTaskId = new System.Windows.Forms.CheckBox();
            this.checkBoxTaskStatus = new System.Windows.Forms.CheckBox();
            this.checkBoxTaskShortDescription = new System.Windows.Forms.CheckBox();
            this.checkBoxProjectName = new System.Windows.Forms.CheckBox();
            this.checkBoxIstZustand = new System.Windows.Forms.CheckBox();
            this.checkBoxTaskSollZustand = new System.Windows.Forms.CheckBox();
            this.checkBoxTaskResult = new System.Windows.Forms.CheckBox();
            this.checkBoxTaskPublicText = new System.Windows.Forms.CheckBox();
            this.TextBox1 = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGetDoneTask
            // 
            this.buttonGetDoneTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetDoneTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.buttonGetDoneTask.Location = new System.Drawing.Point(648, 72);
            this.buttonGetDoneTask.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGetDoneTask.Name = "buttonGetDoneTask";
            this.buttonGetDoneTask.Size = new System.Drawing.Size(143, 29);
            this.buttonGetDoneTask.TabIndex = 47;
            this.buttonGetDoneTask.Text = "Copy to clipboard";
            this.buttonGetDoneTask.UseVisualStyleBackColor = true;
            this.buttonGetDoneTask.Click += new System.EventHandler(this.buttonGetDoneTask_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonReport);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.buttonGetDoneTask);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 129);
            this.panel1.TabIndex = 48;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.button1.Location = new System.Drawing.Point(798, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 29);
            this.button1.TabIndex = 63;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.buttonReport.Location = new System.Drawing.Point(648, 32);
            this.buttonReport.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(143, 29);
            this.buttonReport.TabIndex = 62;
            this.buttonReport.Text = "Create Report";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 21);
            this.label9.TabIndex = 61;
            this.label9.Text = "Report generator options";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxHeaders);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxEmptyLines);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxBlackText);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxTaskId);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxTaskStatus);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxTaskShortDescription);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxProjectName);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxIstZustand);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxTaskSollZustand);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxTaskResult);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxTaskPublicText);
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 32);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(432, 69);
            this.flowLayoutPanel1.TabIndex = 60;
            // 
            // checkBoxHeaders
            // 
            this.checkBoxHeaders.AutoSize = true;
            this.checkBoxHeaders.Location = new System.Drawing.Point(2, 2);
            this.checkBoxHeaders.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxHeaders.Name = "checkBoxHeaders";
            this.checkBoxHeaders.Size = new System.Drawing.Size(66, 17);
            this.checkBoxHeaders.TabIndex = 53;
            this.checkBoxHeaders.Text = "Headers";
            this.checkBoxHeaders.UseVisualStyleBackColor = true;
            // 
            // checkBoxEmptyLines
            // 
            this.checkBoxEmptyLines.AutoSize = true;
            this.checkBoxEmptyLines.Checked = true;
            this.checkBoxEmptyLines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEmptyLines.Location = new System.Drawing.Point(72, 2);
            this.checkBoxEmptyLines.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEmptyLines.Name = "checkBoxEmptyLines";
            this.checkBoxEmptyLines.Size = new System.Drawing.Size(83, 17);
            this.checkBoxEmptyLines.TabIndex = 57;
            this.checkBoxEmptyLines.Text = "Empty Lines";
            this.checkBoxEmptyLines.UseVisualStyleBackColor = true;
            // 
            // checkBoxBlackText
            // 
            this.checkBoxBlackText.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxBlackText, true);
            this.checkBoxBlackText.Location = new System.Drawing.Point(159, 2);
            this.checkBoxBlackText.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxBlackText.Name = "checkBoxBlackText";
            this.checkBoxBlackText.Size = new System.Drawing.Size(77, 17);
            this.checkBoxBlackText.TabIndex = 54;
            this.checkBoxBlackText.Text = "Black Text";
            this.checkBoxBlackText.UseVisualStyleBackColor = true;
            // 
            // checkBoxTaskId
            // 
            this.checkBoxTaskId.AutoSize = true;
            this.checkBoxTaskId.Checked = true;
            this.checkBoxTaskId.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTaskId.Location = new System.Drawing.Point(2, 23);
            this.checkBoxTaskId.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxTaskId.Name = "checkBoxTaskId";
            this.checkBoxTaskId.Size = new System.Drawing.Size(62, 17);
            this.checkBoxTaskId.TabIndex = 55;
            this.checkBoxTaskId.Text = "Task Id";
            this.checkBoxTaskId.UseVisualStyleBackColor = true;
            // 
            // checkBoxTaskStatus
            // 
            this.checkBoxTaskStatus.AutoSize = true;
            this.checkBoxTaskStatus.Checked = true;
            this.checkBoxTaskStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTaskStatus.Location = new System.Drawing.Point(68, 23);
            this.checkBoxTaskStatus.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxTaskStatus.Name = "checkBoxTaskStatus";
            this.checkBoxTaskStatus.Size = new System.Drawing.Size(83, 17);
            this.checkBoxTaskStatus.TabIndex = 58;
            this.checkBoxTaskStatus.Text = "Task Status";
            this.checkBoxTaskStatus.UseVisualStyleBackColor = true;
            // 
            // checkBoxTaskShortDescription
            // 
            this.checkBoxTaskShortDescription.AutoSize = true;
            this.checkBoxTaskShortDescription.Checked = true;
            this.checkBoxTaskShortDescription.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTaskShortDescription.Location = new System.Drawing.Point(155, 23);
            this.checkBoxTaskShortDescription.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxTaskShortDescription.Name = "checkBoxTaskShortDescription";
            this.checkBoxTaskShortDescription.Size = new System.Drawing.Size(134, 17);
            this.checkBoxTaskShortDescription.TabIndex = 56;
            this.checkBoxTaskShortDescription.Text = "Task Short Description";
            this.checkBoxTaskShortDescription.UseVisualStyleBackColor = true;
            // 
            // checkBoxProjectName
            // 
            this.checkBoxProjectName.AutoSize = true;
            this.checkBoxProjectName.Checked = true;
            this.checkBoxProjectName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxProjectName, true);
            this.checkBoxProjectName.Location = new System.Drawing.Point(293, 23);
            this.checkBoxProjectName.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxProjectName.Name = "checkBoxProjectName";
            this.checkBoxProjectName.Size = new System.Drawing.Size(88, 17);
            this.checkBoxProjectName.TabIndex = 52;
            this.checkBoxProjectName.Text = "Project name";
            this.checkBoxProjectName.UseVisualStyleBackColor = true;
            // 
            // checkBoxIstZustand
            // 
            this.checkBoxIstZustand.AutoSize = true;
            this.checkBoxIstZustand.Location = new System.Drawing.Point(2, 44);
            this.checkBoxIstZustand.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxIstZustand.Name = "checkBoxIstZustand";
            this.checkBoxIstZustand.Size = new System.Drawing.Size(106, 17);
            this.checkBoxIstZustand.TabIndex = 48;
            this.checkBoxIstZustand.Text = "Task Ist Zustand";
            this.checkBoxIstZustand.UseVisualStyleBackColor = true;
            // 
            // checkBoxTaskSollZustand
            // 
            this.checkBoxTaskSollZustand.AutoSize = true;
            this.checkBoxTaskSollZustand.Location = new System.Drawing.Point(112, 44);
            this.checkBoxTaskSollZustand.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxTaskSollZustand.Name = "checkBoxTaskSollZustand";
            this.checkBoxTaskSollZustand.Size = new System.Drawing.Size(112, 17);
            this.checkBoxTaskSollZustand.TabIndex = 49;
            this.checkBoxTaskSollZustand.Text = "Task Soll Zustand";
            this.checkBoxTaskSollZustand.UseVisualStyleBackColor = true;
            // 
            // checkBoxTaskResult
            // 
            this.checkBoxTaskResult.AutoSize = true;
            this.checkBoxTaskResult.Location = new System.Drawing.Point(228, 44);
            this.checkBoxTaskResult.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxTaskResult.Name = "checkBoxTaskResult";
            this.checkBoxTaskResult.Size = new System.Drawing.Size(83, 17);
            this.checkBoxTaskResult.TabIndex = 50;
            this.checkBoxTaskResult.Text = "Task Result";
            this.checkBoxTaskResult.UseVisualStyleBackColor = true;
            // 
            // checkBoxTaskPublicText
            // 
            this.checkBoxTaskPublicText.AutoSize = true;
            this.checkBoxTaskPublicText.Checked = true;
            this.checkBoxTaskPublicText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTaskPublicText.Location = new System.Drawing.Point(315, 44);
            this.checkBoxTaskPublicText.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxTaskPublicText.Name = "checkBoxTaskPublicText";
            this.checkBoxTaskPublicText.Size = new System.Drawing.Size(106, 17);
            this.checkBoxTaskPublicText.TabIndex = 51;
            this.checkBoxTaskPublicText.Text = "Task Public Text";
            this.checkBoxTaskPublicText.UseVisualStyleBackColor = true;
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.TextBox1.Location = new System.Drawing.Point(0, 129);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(869, 262);
            this.TextBox1.TabIndex = 49;
            this.TextBox1.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TextBox1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1319, 391);
            this.splitContainer1.SplitterDistance = 869;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 50;
            // 
            // ReportScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1319, 391);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReportScreen";
            this.Text = "ReportScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGetDoneTask;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.RichTextBox TextBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBoxHeaders;
        private System.Windows.Forms.CheckBox checkBoxEmptyLines;
        private System.Windows.Forms.CheckBox checkBoxBlackText;
        private System.Windows.Forms.CheckBox checkBoxTaskId;
        private System.Windows.Forms.CheckBox checkBoxTaskStatus;
        private System.Windows.Forms.CheckBox checkBoxTaskShortDescription;
        private System.Windows.Forms.CheckBox checkBoxProjectName;
        private System.Windows.Forms.CheckBox checkBoxIstZustand;
        private System.Windows.Forms.CheckBox checkBoxTaskSollZustand;
        private System.Windows.Forms.CheckBox checkBoxTaskResult;
        private System.Windows.Forms.CheckBox checkBoxTaskPublicText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button button1;



    }
}