using Tornado14.TrayApp.Controls.Task;

namespace Tornado14.TrayApp.Controls.Task
{
    partial class TasksGridPanel
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
            this.panelTasks = new System.Windows.Forms.Panel();
            this.panelTasksGray = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelTaskSearch = new System.Windows.Forms.Panel();
            this.panelTaskDetails = new System.Windows.Forms.Panel();
            this.taskEditor1 = new Tornado14.TrayApp.Controls.Task.TaskEditor();
            this.todoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskSearchPanel1 = new Tornado14.TrayApp.Controls.Task.TaskSearchPanel();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sprintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelTasks.SuspendLayout();
            this.panelTasksGray.SuspendLayout();
            this.panelTaskSearch.SuspendLayout();
            this.panelTaskDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTasks
            // 
            this.panelTasks.Controls.Add(this.panelTasksGray);
            this.panelTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTasks.Location = new System.Drawing.Point(5, 0);
            this.panelTasks.Margin = new System.Windows.Forms.Padding(0);
            this.panelTasks.Name = "panelTasks";
            this.panelTasks.Size = new System.Drawing.Size(1218, 532);
            this.panelTasks.TabIndex = 3;
            // 
            // panelTasksGray
            // 
            this.panelTasksGray.Controls.Add(this.splitter1);
            this.panelTasksGray.Controls.Add(this.panelTaskSearch);
            this.panelTasksGray.Controls.Add(this.taskSearchPanel1);
            this.panelTasksGray.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTasksGray.Location = new System.Drawing.Point(0, 0);
            this.panelTasksGray.Margin = new System.Windows.Forms.Padding(2);
            this.panelTasksGray.Name = "panelTasksGray";
            this.panelTasksGray.Padding = new System.Windows.Forms.Padding(1);
            this.panelTasksGray.Size = new System.Drawing.Size(1218, 532);
            this.panelTasksGray.TabIndex = 6;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.splitter1.Location = new System.Drawing.Point(701, 1);
            this.splitter1.Margin = new System.Windows.Forms.Padding(0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 530);
            this.splitter1.TabIndex = 20;
            this.splitter1.TabStop = false;
            // 
            // panelTaskSearch
            // 
            this.panelTaskSearch.Controls.Add(this.panelTaskDetails);
            this.panelTaskSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTaskSearch.Location = new System.Drawing.Point(701, 1);
            this.panelTaskSearch.Name = "panelTaskSearch";
            this.panelTaskSearch.Size = new System.Drawing.Size(516, 530);
            this.panelTaskSearch.TabIndex = 19;
            // 
            // panelTaskDetails
            // 
            this.panelTaskDetails.Controls.Add(this.taskEditor1);
            this.panelTaskDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTaskDetails.Location = new System.Drawing.Point(0, 0);
            this.panelTaskDetails.Margin = new System.Windows.Forms.Padding(0);
            this.panelTaskDetails.Name = "panelTaskDetails";
            this.panelTaskDetails.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.panelTaskDetails.Size = new System.Drawing.Size(516, 530);
            this.panelTaskDetails.TabIndex = 5;
            // 
            // taskEditor1
            // 
            this.taskEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskEditor1.Location = new System.Drawing.Point(4, 0);
            this.taskEditor1.Margin = new System.Windows.Forms.Padding(2);
            this.taskEditor1.Name = "taskEditor1";
            this.taskEditor1.Size = new System.Drawing.Size(512, 530);
            this.taskEditor1.TabIndex = 42;
            // 
            // todoBindingSource
            // 
            this.todoBindingSource.DataSource = typeof(Tornado14.Task.Todo);
            this.todoBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.todoBindingSource_BindingComplete);
            this.todoBindingSource.PositionChanged += new System.EventHandler(this.todoBindingSource_PositionChanged);
            // 
            // taskSearchPanel1
            // 
            this.taskSearchPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.taskSearchPanel1.Location = new System.Drawing.Point(1, 1);
            this.taskSearchPanel1.Name = "taskSearchPanel1";
            this.taskSearchPanel1.Size = new System.Drawing.Size(700, 530);
            this.taskSearchPanel1.TabIndex = 15;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(Tornado14.Task.Project);
            this.projectBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.todoBindingSource_BindingComplete);
            // 
            // sprintBindingSource
            // 
            this.sprintBindingSource.DataSource = typeof(Tornado14.Task.Sprint);
            // 
            // TasksGridPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelTasks);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TasksGridPanel";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Size = new System.Drawing.Size(1223, 532);
            this.panelTasks.ResumeLayout(false);
            this.panelTasksGray.ResumeLayout(false);
            this.panelTaskSearch.ResumeLayout(false);
            this.panelTaskDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource todoBindingSource;
        private System.Windows.Forms.Panel panelTasks;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.BindingSource sprintBindingSource;
        private System.Windows.Forms.Panel panelTasksGray;
        private TaskSearchPanel taskSearchPanel1;
        private System.Windows.Forms.Panel panelTaskSearch;
        private System.Windows.Forms.Panel panelTaskDetails;
        private TaskEditor taskEditor1;
        private System.Windows.Forms.Splitter splitter1;
    }
}
