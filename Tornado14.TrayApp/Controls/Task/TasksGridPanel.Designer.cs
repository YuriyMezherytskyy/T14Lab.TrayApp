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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TasksGridPanel));
            this.panelTasks = new System.Windows.Forms.Panel();
            this.panelTasksGray = new System.Windows.Forms.Panel();
            this.panelTaskSearch = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTaskFeatures = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDocumentation = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFeatures = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFiles = new System.Windows.Forms.ToolStripButton();
            this.panelTaskDetails = new System.Windows.Forms.Panel();
            this.taskEditor1 = new Tornado14.TrayApp.Controls.Task.TaskEditor();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.todoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.taskSearchPanel1 = new Tornado14.TrayApp.Controls.Task.TaskSearchPanel();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sprintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelTasks.SuspendLayout();
            this.panelTasksGray.SuspendLayout();
            this.panelTaskSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTaskFeatures.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panelTaskDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
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
            this.panelTasksGray.Controls.Add(this.panelTaskSearch);
            this.panelTasksGray.Controls.Add(this.splitter1);
            this.panelTasksGray.Controls.Add(this.taskSearchPanel1);
            this.panelTasksGray.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTasksGray.Location = new System.Drawing.Point(0, 0);
            this.panelTasksGray.Margin = new System.Windows.Forms.Padding(2);
            this.panelTasksGray.Name = "panelTasksGray";
            this.panelTasksGray.Padding = new System.Windows.Forms.Padding(1);
            this.panelTasksGray.Size = new System.Drawing.Size(1218, 532);
            this.panelTasksGray.TabIndex = 6;
            // 
            // panelTaskSearch
            // 
            this.panelTaskSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTaskSearch.Controls.Add(this.panel1);
            this.panelTaskSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTaskSearch.Location = new System.Drawing.Point(600, 1);
            this.panelTaskSearch.Name = "panelTaskSearch";
            this.panelTaskSearch.Padding = new System.Windows.Forms.Padding(5);
            this.panelTaskSearch.Size = new System.Drawing.Size(617, 530);
            this.panelTaskSearch.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelTaskFeatures);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.panelTaskDetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 518);
            this.panel1.TabIndex = 1;
            // 
            // panelTaskFeatures
            // 
            this.panelTaskFeatures.Controls.Add(this.checkedListBox1);
            this.panelTaskFeatures.Location = new System.Drawing.Point(637, 42);
            this.panelTaskFeatures.Margin = new System.Windows.Forms.Padding(2);
            this.panelTaskFeatures.Name = "panelTaskFeatures";
            this.panelTaskFeatures.Size = new System.Drawing.Size(206, 425);
            this.panelTaskFeatures.TabIndex = 14;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(13, 109);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(150, 240);
            this.checkedListBox1.TabIndex = 46;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDocumentation,
            this.toolStripButtonFeatures,
            this.toolStripButtonFiles});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(605, 39);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonDocumentation
            // 
            this.toolStripButtonDocumentation.Checked = true;
            this.toolStripButtonDocumentation.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.toolStripButtonDocumentation.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDocumentation.Image")));
            this.toolStripButtonDocumentation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDocumentation.Name = "toolStripButtonDocumentation";
            this.toolStripButtonDocumentation.Size = new System.Drawing.Size(126, 36);
            this.toolStripButtonDocumentation.Text = "Documentation";
            this.toolStripButtonDocumentation.Click += new System.EventHandler(this.toolStripButtonDocumentation_Click);
            // 
            // toolStripButtonFeatures
            // 
            this.toolStripButtonFeatures.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButtonFeatures.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFeatures.Image")));
            this.toolStripButtonFeatures.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFeatures.Name = "toolStripButtonFeatures";
            this.toolStripButtonFeatures.Size = new System.Drawing.Size(188, 36);
            this.toolStripButtonFeatures.Text = "Project Feature Assignment";
            this.toolStripButtonFeatures.Visible = false;
            this.toolStripButtonFeatures.Click += new System.EventHandler(this.toolStripButtonFeatures_Click);
            // 
            // toolStripButtonFiles
            // 
            this.toolStripButtonFiles.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButtonFiles.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFiles.Image")));
            this.toolStripButtonFiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFiles.Name = "toolStripButtonFiles";
            this.toolStripButtonFiles.Size = new System.Drawing.Size(66, 36);
            this.toolStripButtonFiles.Text = "Files";
            this.toolStripButtonFiles.Click += new System.EventHandler(this.toolStripButtonFiles_Click);
            // 
            // panelTaskDetails
            // 
            this.panelTaskDetails.Controls.Add(this.taskEditor1);
            this.panelTaskDetails.Controls.Add(this.bindingNavigator1);
            this.panelTaskDetails.Location = new System.Drawing.Point(160, 42);
            this.panelTaskDetails.Margin = new System.Windows.Forms.Padding(2);
            this.panelTaskDetails.Name = "panelTaskDetails";
            this.panelTaskDetails.Size = new System.Drawing.Size(442, 443);
            this.panelTaskDetails.TabIndex = 2;
            // 
            // taskEditor1
            // 
            this.taskEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskEditor1.Location = new System.Drawing.Point(0, 39);
            this.taskEditor1.Margin = new System.Windows.Forms.Padding(2);
            this.taskEditor1.Name = "taskEditor1";
            this.taskEditor1.Size = new System.Drawing.Size(442, 404);
            this.taskEditor1.TabIndex = 42;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bindingNavigator1.BindingSource = this.todoBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bindingNavigator1.Size = new System.Drawing.Size(442, 39);
            this.bindingNavigator1.TabIndex = 41;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // todoBindingSource
            // 
            this.todoBindingSource.DataSource = typeof(Tornado14.Task.Todo);
            this.todoBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.todoBindingSource_BindingComplete);
            this.todoBindingSource.PositionChanged += new System.EventHandler(this.todoBindingSource_PositionChanged);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 36);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bindingNavigatorPositionItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bindingNavigatorPositionItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.splitter1.Location = new System.Drawing.Point(596, 1);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 530);
            this.splitter1.TabIndex = 18;
            this.splitter1.TabStop = false;
            // 
            // taskSearchPanel1
            // 
            this.taskSearchPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.taskSearchPanel1.Location = new System.Drawing.Point(1, 1);
            this.taskSearchPanel1.Name = "taskSearchPanel1";
            this.taskSearchPanel1.Size = new System.Drawing.Size(595, 530);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTaskFeatures.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelTaskDetails.ResumeLayout(false);
            this.panelTaskDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource todoBindingSource;
        private System.Windows.Forms.Panel panelTasks;
        private System.Windows.Forms.Panel panelTasksGray;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTaskFeatures;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonDocumentation;
        private System.Windows.Forms.ToolStripButton toolStripButtonFeatures;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ToolStripButton toolStripButtonFiles;
        private System.Windows.Forms.Panel panelTaskDetails;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private TaskEditor taskEditor1;
        private TaskSearchPanel taskSearchPanel1;
        private System.Windows.Forms.BindingSource sprintBindingSource;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelTaskSearch;
    }
}
