namespace Tornado14.TrayApp
{
    partial class TaskItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskItem));
            this.labelProjectName = new System.Windows.Forms.Label();
            this.linkLabelFiles = new System.Windows.Forms.LinkLabel();
            this.labelTaskId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxShortDescription = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DeleteButton = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labeEdit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProjectName
            // 
            this.labelProjectName.AutoSize = true;
            this.labelProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProjectName.Location = new System.Drawing.Point(87, 48);
            this.labelProjectName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(69, 13);
            this.labelProjectName.TabIndex = 2;
            this.labelProjectName.Text = "Project name";
            this.labelProjectName.Visible = false;
            // 
            // linkLabelFiles
            // 
            this.linkLabelFiles.AutoSize = true;
            this.linkLabelFiles.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelFiles.Location = new System.Drawing.Point(76, 6);
            this.linkLabelFiles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelFiles.Name = "linkLabelFiles";
            this.linkLabelFiles.Size = new System.Drawing.Size(30, 13);
            this.linkLabelFiles.TabIndex = 3;
            this.linkLabelFiles.TabStop = true;
            this.linkLabelFiles.Text = "Files";
            this.linkLabelFiles.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFiles_LinkClicked);
            this.linkLabelFiles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxShortDescription_MouseDown);
            this.linkLabelFiles.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.linkLabelFiles.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBoxShortDescription_MouseMove);
            // 
            // labelTaskId
            // 
            this.labelTaskId.AutoSize = true;
            this.labelTaskId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaskId.Location = new System.Drawing.Point(11, 6);
            this.labelTaskId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTaskId.Name = "labelTaskId";
            this.labelTaskId.Size = new System.Drawing.Size(41, 13);
            this.labelTaskId.TabIndex = 4;
            this.labelTaskId.Text = "label1";
            this.labelTaskId.Click += new System.EventHandler(this.TaskItem_Click);
            this.labelTaskId.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxShortDescription_MouseDown);
            this.labelTaskId.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.labelTaskId.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBoxShortDescription_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 4);
            this.panel1.TabIndex = 5;
            // 
            // textBoxShortDescription
            // 
            this.textBoxShortDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxShortDescription.BackColor = System.Drawing.Color.White;
            this.textBoxShortDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxShortDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxShortDescription.Location = new System.Drawing.Point(10, 15);
            this.textBoxShortDescription.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxShortDescription.Multiline = true;
            this.textBoxShortDescription.Name = "textBoxShortDescription";
            this.textBoxShortDescription.Size = new System.Drawing.Size(333, 37);
            this.textBoxShortDescription.TabIndex = 6;
            this.textBoxShortDescription.Text = "sdffh sdf hsfd öglhksfj gdölhkj sdölfkhj ölsdkjf gölksdjf gölksdj glökksjd flökgj" +
    " söldfkgj ösldkffj gölsdkj gölsdj glsdj öglkjsdöfl gkjsdäl gj";
            this.textBoxShortDescription.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxShortDescription_MouseDown);
            this.textBoxShortDescription.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.textBoxShortDescription.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBoxShortDescription_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 59);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "weöshzwertgwer\r\nt\r\nwert\r\nwert\r\nwe\r\nrt\r\nwert\r\nwerrtwert\r\n\r\n");
            this.pictureBox1.Click += new System.EventHandler(this.TaskItem_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxShortDescription_MouseDown);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBoxShortDescription_MouseMove);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.Location = new System.Drawing.Point(341, 41);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(17, 20);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "   ";
            this.DeleteButton.Click += new System.EventHandler(this.label1_Click);
            this.DeleteButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxShortDescription_MouseDown);
            this.DeleteButton.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.DeleteButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBoxShortDescription_MouseMove);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 500000;
            this.toolTip1.BackColor = System.Drawing.Color.Black;
            this.toolTip1.ForeColor = System.Drawing.Color.White;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Description";
            // 
            // labeEdit
            // 
            this.labeEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labeEdit.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeEdit.ForeColor = System.Drawing.Color.Black;
            this.labeEdit.Image = ((System.Drawing.Image)(resources.GetObject("labeEdit.Image")));
            this.labeEdit.Location = new System.Drawing.Point(344, 5);
            this.labeEdit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeEdit.Name = "labeEdit";
            this.labeEdit.Size = new System.Drawing.Size(16, 18);
            this.labeEdit.TabIndex = 9;
            this.labeEdit.Text = "   ";
            this.labeEdit.Click += new System.EventHandler(this.labeEdit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(326, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "   ";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TaskItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labeEdit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabelFiles);
            this.Controls.Add(this.labelProjectName);
            this.Controls.Add(this.labelTaskId);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxShortDescription);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TaskItem";
            this.Size = new System.Drawing.Size(360, 62);
            this.Load += new System.EventHandler(this.TaskItem_Load);
            this.Click += new System.EventHandler(this.TaskItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProjectName;
        private System.Windows.Forms.LinkLabel linkLabelFiles;
        private System.Windows.Forms.Label labelTaskId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label DeleteButton;
        public System.Windows.Forms.TextBox textBoxShortDescription;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Label labeEdit;
        public System.Windows.Forms.Label label1;



    }
}
