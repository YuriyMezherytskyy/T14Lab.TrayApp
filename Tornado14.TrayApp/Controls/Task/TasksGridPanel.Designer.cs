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
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.todoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.taskSearchPanel1 = new Tornado14.TrayApp.Controls.Task.TaskSearchPanel();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sprintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelTasks.SuspendLayout();
            this.panelTasksGray.SuspendLayout();
            this.panelTaskSearch.SuspendLayout();
            this.panelTaskDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
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
            this.panelTaskDetails.Controls.Add(this.splitter2);
            this.panelTaskDetails.Controls.Add(this.panel1);
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
            this.taskEditor1.Location = new System.Drawing.Point(4, 43);
            this.taskEditor1.Margin = new System.Windows.Forms.Padding(2);
            this.taskEditor1.Name = "taskEditor1";
            this.taskEditor1.Size = new System.Drawing.Size(512, 487);
            this.taskEditor1.TabIndex = 42;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(4, 39);
            this.splitter2.Margin = new System.Windows.Forms.Padding(2);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(512, 4);
            this.splitter2.TabIndex = 48;
            this.splitter2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bindingNavigator2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(512, 39);
            this.panel1.TabIndex = 47;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bindingNavigator2.BindingSource = this.todoBindingSource;
            this.bindingNavigator2.CountItem = null;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigator2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5});
            this.bindingNavigator2.Location = new System.Drawing.Point(4, 26);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bindingNavigator2.Size = new System.Drawing.Size(506, 32);
            this.bindingNavigator2.TabIndex = 48;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // todoBindingSource
            // 
            this.todoBindingSource.DataSource = typeof(Tornado14.Task.Todo);
            this.todoBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.todoBindingSource_BindingComplete);
            this.todoBindingSource.PositionChanged += new System.EventHandler(this.todoBindingSource_PositionChanged);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.ForeColor = System.Drawing.Color.White;
            this.toolStripButton5.Image = global::Tornado14.TrayApp.Properties.Resources.opened_folder7;
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(59, 29);
            this.toolStripButton5.Text = "Files";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 2, 4);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.label1.Size = new System.Drawing.Size(118, 26);
            this.label1.TabIndex = 47;
            this.label1.Text = "Filtered data";
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
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
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
    }
}
