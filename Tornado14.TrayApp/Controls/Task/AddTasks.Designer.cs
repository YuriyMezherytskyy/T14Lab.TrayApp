namespace Tornado14.TrayApp.Controls.Task
{
    partial class AddTasks
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
            this.panelWrapper = new System.Windows.Forms.Panel();
            this.panelMenuWrapper = new System.Windows.Forms.Panel();
            this.buttonAddTasks = new System.Windows.Forms.Button();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sprintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.todoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddTasksEditorElementHost = new System.Windows.Forms.Integration.ElementHost();
            this.AddTasksEditor = new Tornado14.TrayApp.Controls.WPFRichTextBox();
            this.panelWrapper.SuspendLayout();
            this.panelMenuWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelWrapper
            // 
            this.panelWrapper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWrapper.Controls.Add(this.AddTasksEditorElementHost);
            this.panelWrapper.Controls.Add(this.panelMenuWrapper);
            this.panelWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWrapper.Location = new System.Drawing.Point(5, 5);
            this.panelWrapper.Name = "panelWrapper";
            this.panelWrapper.Padding = new System.Windows.Forms.Padding(5);
            this.panelWrapper.Size = new System.Drawing.Size(995, 644);
            this.panelWrapper.TabIndex = 1;
            // 
            // panelMenuWrapper
            // 
            this.panelMenuWrapper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenuWrapper.Controls.Add(this.buttonAddTasks);
            this.panelMenuWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuWrapper.Location = new System.Drawing.Point(5, 5);
            this.panelMenuWrapper.Name = "panelMenuWrapper";
            this.panelMenuWrapper.Padding = new System.Windows.Forms.Padding(5);
            this.panelMenuWrapper.Size = new System.Drawing.Size(983, 40);
            this.panelMenuWrapper.TabIndex = 1;
            // 
            // buttonAddTasks
            // 
            this.buttonAddTasks.Location = new System.Drawing.Point(3, 4);
            this.buttonAddTasks.Name = "buttonAddTasks";
            this.buttonAddTasks.Size = new System.Drawing.Size(94, 29);
            this.buttonAddTasks.TabIndex = 19;
            this.buttonAddTasks.Text = "Add Tasks";
            this.buttonAddTasks.UseVisualStyleBackColor = true;
            this.buttonAddTasks.Click += new System.EventHandler(this.buttonAddTasks_Click);
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(Tornado14.Task.Project);
            // 
            // sprintBindingSource
            // 
            this.sprintBindingSource.DataSource = typeof(Tornado14.Task.Sprint);
            // 
            // todoBindingSource
            // 
            this.todoBindingSource.DataSource = typeof(Tornado14.Task.Todo);
            // 
            // AddTasksEditorElementHost
            // 
            this.AddTasksEditorElementHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddTasksEditorElementHost.Location = new System.Drawing.Point(5, 45);
            this.AddTasksEditorElementHost.Name = "AddTasksEditorElementHost";
            this.AddTasksEditorElementHost.Size = new System.Drawing.Size(983, 592);
            this.AddTasksEditorElementHost.TabIndex = 0;
            this.AddTasksEditorElementHost.Text = "AddTasksEditor";
            this.AddTasksEditorElementHost.Child = this.AddTasksEditor;
            // 
            // AddTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelWrapper);
            this.Name = "AddTasks";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1005, 654);
            this.panelWrapper.ResumeLayout(false);
            this.panelMenuWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost AddTasksEditorElementHost;
        private WPFRichTextBox AddTasksEditor;
        private System.Windows.Forms.Panel panelWrapper;
        private System.Windows.Forms.Panel panelMenuWrapper;
        private System.Windows.Forms.Button buttonAddTasks;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.BindingSource sprintBindingSource;
        private System.Windows.Forms.BindingSource todoBindingSource;
    }
}
