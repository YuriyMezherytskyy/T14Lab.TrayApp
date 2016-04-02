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
            this.elementHost4 = new System.Windows.Forms.Integration.ElementHost();
            this.PublicTextField = new Tornado14.TrayApp.Controls.WPFRichTextBox();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.elementHost3 = new System.Windows.Forms.Integration.ElementHost();
            this.ResultField = new Tornado14.TrayApp.Controls.WPFRichTextBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.DescriptionField = new Tornado14.TrayApp.Controls.WPFRichTextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.CurrentStateField = new Tornado14.TrayApp.Controls.WPFRichTextBox();
            this.todoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelTaskDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTaskDetails
            // 
            this.panelTaskDetails.Controls.Add(this.elementHost4);
            this.panelTaskDetails.Controls.Add(this.splitter3);
            this.panelTaskDetails.Controls.Add(this.elementHost3);
            this.panelTaskDetails.Controls.Add(this.splitter2);
            this.panelTaskDetails.Controls.Add(this.elementHost2);
            this.panelTaskDetails.Controls.Add(this.splitter1);
            this.panelTaskDetails.Controls.Add(this.elementHost1);
            this.panelTaskDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTaskDetails.Location = new System.Drawing.Point(0, 0);
            this.panelTaskDetails.Margin = new System.Windows.Forms.Padding(2);
            this.panelTaskDetails.Name = "panelTaskDetails";
            this.panelTaskDetails.Size = new System.Drawing.Size(671, 585);
            this.panelTaskDetails.TabIndex = 3;
            // 
            // elementHost4
            // 
            this.elementHost4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost4.Location = new System.Drawing.Point(0, 312);
            this.elementHost4.Name = "elementHost4";
            this.elementHost4.Size = new System.Drawing.Size(671, 273);
            this.elementHost4.TabIndex = 49;
            this.elementHost4.Text = "elementHost4";
            this.elementHost4.Child = this.PublicTextField;
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.splitter3.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Location = new System.Drawing.Point(0, 308);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(671, 4);
            this.splitter3.TabIndex = 48;
            this.splitter3.TabStop = false;
            // 
            // elementHost3
            // 
            this.elementHost3.Dock = System.Windows.Forms.DockStyle.Top;
            this.elementHost3.Location = new System.Drawing.Point(0, 208);
            this.elementHost3.Name = "elementHost3";
            this.elementHost3.Size = new System.Drawing.Size(671, 100);
            this.elementHost3.TabIndex = 47;
            this.elementHost3.Text = "elementHost3";
            this.elementHost3.Child = this.ResultField;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.splitter2.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 204);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(671, 4);
            this.splitter2.TabIndex = 46;
            this.splitter2.TabStop = false;
            // 
            // elementHost2
            // 
            this.elementHost2.Dock = System.Windows.Forms.DockStyle.Top;
            this.elementHost2.Location = new System.Drawing.Point(0, 104);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(671, 100);
            this.elementHost2.TabIndex = 45;
            this.elementHost2.Text = "elementHost2";
            this.elementHost2.Child = this.DescriptionField;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.splitter1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 100);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(671, 4);
            this.splitter1.TabIndex = 44;
            this.splitter1.TabStop = false;
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Top;
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(671, 100);
            this.elementHost1.TabIndex = 43;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.CurrentStateField;
            // 
            // todoBindingSource
            // 
            this.todoBindingSource.DataSource = typeof(Tornado14.Task.Todo);
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
            ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).EndInit();
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
    }
}
