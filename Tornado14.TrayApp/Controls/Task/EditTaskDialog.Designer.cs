using Tornado14.TrayApp.Controls.Task;

namespace Tornado14.TrayApp.Controls.Task
{
    partial class EditTaskDialog
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
            this.components = new System.ComponentModel.Container();
            this.taskEditor1 = new Tornado14.TrayApp.Controls.Task.TaskEditor();
            this.SuspendLayout();
            // 
            // taskEditor1
            // 
            this.taskEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskEditor1.Location = new System.Drawing.Point(4, 4);
            this.taskEditor1.Margin = new System.Windows.Forms.Padding(2);
            this.taskEditor1.Name = "taskEditor1";
            this.taskEditor1.Size = new System.Drawing.Size(912, 573);
            this.taskEditor1.TabIndex = 0;
            // 
            // EditTaskDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(920, 581);
            this.Controls.Add(this.taskEditor1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditTaskDialog";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditTaskDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private TaskEditor taskEditor1;
    }
}