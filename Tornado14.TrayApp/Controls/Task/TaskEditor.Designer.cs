namespace Tornado14.TrayApp.Controls.Task
{
    partial class TaskEditor
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
            this.panelTaskDetails = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.elementHost4 = new System.Windows.Forms.Integration.ElementHost();
            this.PublicTextField = new Tornado14.TrayApp.Controls.WPFRichTextBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.elementHost3 = new System.Windows.Forms.Integration.ElementHost();
            this.ResultField = new Tornado14.TrayApp.Controls.WPFRichTextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.DescriptionField = new Tornado14.TrayApp.Controls.WPFRichTextBox();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.CurrentStateField = new Tornado14.TrayApp.Controls.WPFRichTextBox();
            this.todoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sprintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelTaskDetails.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTaskDetails
            // 
            this.panelTaskDetails.Controls.Add(this.panel4);
            this.panelTaskDetails.Controls.Add(this.splitter2);
            this.panelTaskDetails.Controls.Add(this.panel3);
            this.panelTaskDetails.Controls.Add(this.splitter1);
            this.panelTaskDetails.Controls.Add(this.panel2);
            this.panelTaskDetails.Controls.Add(this.splitter3);
            this.panelTaskDetails.Controls.Add(this.panel1);
            this.panelTaskDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTaskDetails.Location = new System.Drawing.Point(0, 0);
            this.panelTaskDetails.Margin = new System.Windows.Forms.Padding(2);
            this.panelTaskDetails.Name = "panelTaskDetails";
            this.panelTaskDetails.Size = new System.Drawing.Size(671, 585);
            this.panelTaskDetails.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.elementHost4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 316);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(4);
            this.panel4.Size = new System.Drawing.Size(671, 269);
            this.panel4.TabIndex = 50;
            // 
            // elementHost4
            // 
            this.elementHost4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.elementHost4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost4.Location = new System.Drawing.Point(4, 4);
            this.elementHost4.Name = "elementHost4";
            this.elementHost4.Size = new System.Drawing.Size(661, 259);
            this.elementHost4.TabIndex = 49;
            this.elementHost4.Text = "elementHost4";
            this.elementHost4.Child = this.PublicTextField;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.splitter2.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 312);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(671, 4);
            this.splitter2.TabIndex = 46;
            this.splitter2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.elementHost3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 212);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(4);
            this.panel3.Size = new System.Drawing.Size(671, 100);
            this.panel3.TabIndex = 53;
            // 
            // elementHost3
            // 
            this.elementHost3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.elementHost3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost3.Location = new System.Drawing.Point(4, 4);
            this.elementHost3.Name = "elementHost3";
            this.elementHost3.Size = new System.Drawing.Size(661, 90);
            this.elementHost3.TabIndex = 47;
            this.elementHost3.Text = "elementHost3";
            this.elementHost3.Child = this.ResultField;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.splitter1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 208);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(671, 4);
            this.splitter1.TabIndex = 44;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.elementHost2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 104);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4);
            this.panel2.Size = new System.Drawing.Size(671, 104);
            this.panel2.TabIndex = 52;
            // 
            // elementHost2
            // 
            this.elementHost2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.elementHost2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost2.Location = new System.Drawing.Point(4, 4);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(661, 94);
            this.elementHost2.TabIndex = 45;
            this.elementHost2.Text = "elementHost2";
            this.elementHost2.Child = this.DescriptionField;
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.splitter3.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Location = new System.Drawing.Point(0, 100);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(671, 4);
            this.splitter3.TabIndex = 48;
            this.splitter3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.elementHost1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(671, 100);
            this.panel1.TabIndex = 51;
            // 
            // elementHost1
            // 
            this.elementHost1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(4, 4);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(661, 90);
            this.elementHost1.TabIndex = 43;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.CurrentStateField;
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
            // TaskEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelTaskDetails);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TaskEditor";
            this.Size = new System.Drawing.Size(671, 585);
            this.panelTaskDetails.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTaskDetails;
        private System.Windows.Forms.BindingSource todoBindingSource;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private WPFRichTextBox CurrentStateField;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private WPFRichTextBox DescriptionField;
        private System.Windows.Forms.Integration.ElementHost elementHost4;
        private WPFRichTextBox PublicTextField;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Integration.ElementHost elementHost3;
        private WPFRichTextBox ResultField;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.BindingSource sprintBindingSource;
    }
}
