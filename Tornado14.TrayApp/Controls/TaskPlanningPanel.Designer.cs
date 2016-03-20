namespace Tornado14.TrayApp.Controls
{
    partial class TaskPlanningPanel
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
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange1 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange2 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange3 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange4 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange5 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskPlanningPanel));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.taskSearchPanel1 = new Tornado14.TrayApp.Controls.TaskSearchPanel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.monthView1 = new System.Windows.Forms.Calendar.MonthView();
            this.calendar1 = new System.Windows.Forms.Calendar.Calendar();
            this.todoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sprintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripKanban = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSaveKanban = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).BeginInit();
            this.toolStripKanban.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 32);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.taskSearchPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(997, 597);
            this.splitContainer1.SplitterDistance = 387;
            this.splitContainer1.TabIndex = 3;
            // 
            // taskSearchPanel1
            // 
            this.taskSearchPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskSearchPanel1.Location = new System.Drawing.Point(0, 0);
            this.taskSearchPanel1.Name = "taskSearchPanel1";
            this.taskSearchPanel1.Size = new System.Drawing.Size(387, 597);
            this.taskSearchPanel1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.monthView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.calendar1);
            this.splitContainer2.Size = new System.Drawing.Size(606, 597);
            this.splitContainer2.SplitterDistance = 136;
            this.splitContainer2.TabIndex = 2;
            // 
            // monthView1
            // 
            this.monthView1.ArrowsColor = System.Drawing.SystemColors.Window;
            this.monthView1.ArrowsSelectedColor = System.Drawing.Color.Gold;
            this.monthView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.monthView1.DayBackgroundColor = System.Drawing.Color.Empty;
            this.monthView1.DayGrayedText = System.Drawing.SystemColors.GrayText;
            this.monthView1.DaySelectedBackgroundColor = System.Drawing.SystemColors.Highlight;
            this.monthView1.DaySelectedColor = System.Drawing.SystemColors.WindowText;
            this.monthView1.DaySelectedTextColor = System.Drawing.SystemColors.HighlightText;
            this.monthView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthView1.ForeColor = System.Drawing.Color.White;
            this.monthView1.ItemPadding = new System.Windows.Forms.Padding(2);
            this.monthView1.Location = new System.Drawing.Point(0, 0);
            this.monthView1.MonthTitleColor = System.Drawing.SystemColors.ActiveCaption;
            this.monthView1.MonthTitleColorInactive = System.Drawing.SystemColors.InactiveCaption;
            this.monthView1.MonthTitleTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.monthView1.MonthTitleTextColorInactive = System.Drawing.SystemColors.InactiveCaptionText;
            this.monthView1.Name = "monthView1";
            this.monthView1.Size = new System.Drawing.Size(606, 136);
            this.monthView1.TabIndex = 1;
            this.monthView1.Text = "monthView1";
            this.monthView1.TodayBorderColor = System.Drawing.Color.Maroon;
            this.monthView1.SelectionChanged += new System.EventHandler(this.monthView1_SelectionChanged);
            // 
            // calendar1
            // 
            this.calendar1.AllowNew = false;
            this.calendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendar1.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calendar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            calendarHighlightRange1.DayOfWeek = System.DayOfWeek.Monday;
            calendarHighlightRange1.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange1.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange2.DayOfWeek = System.DayOfWeek.Tuesday;
            calendarHighlightRange2.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange2.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange3.DayOfWeek = System.DayOfWeek.Wednesday;
            calendarHighlightRange3.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange3.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange4.DayOfWeek = System.DayOfWeek.Thursday;
            calendarHighlightRange4.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange4.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange5.DayOfWeek = System.DayOfWeek.Friday;
            calendarHighlightRange5.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange5.StartTime = System.TimeSpan.Parse("08:00:00");
            this.calendar1.HighlightRanges = new System.Windows.Forms.Calendar.CalendarHighlightRange[] {
        calendarHighlightRange1,
        calendarHighlightRange2,
        calendarHighlightRange3,
        calendarHighlightRange4,
        calendarHighlightRange5};
            this.calendar1.Location = new System.Drawing.Point(0, 0);
            this.calendar1.Name = "calendar1";
            this.calendar1.Size = new System.Drawing.Size(606, 457);
            this.calendar1.TabIndex = 0;
            this.calendar1.Text = "calendar1";
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
            // toolStripKanban
            // 
            this.toolStripKanban.AutoSize = false;
            this.toolStripKanban.BackColor = System.Drawing.Color.DimGray;
            this.toolStripKanban.GripMargin = new System.Windows.Forms.Padding(4);
            this.toolStripKanban.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripKanban.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripKanban.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSaveKanban,
            this.toolStripButton2});
            this.toolStripKanban.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripKanban.Location = new System.Drawing.Point(0, 0);
            this.toolStripKanban.Name = "toolStripKanban";
            this.toolStripKanban.Size = new System.Drawing.Size(997, 32);
            this.toolStripKanban.TabIndex = 8;
            this.toolStripKanban.Text = "toolStrip1";
            // 
            // toolStripButtonSaveKanban
            // 
            this.toolStripButtonSaveKanban.ForeColor = System.Drawing.Color.White;
            this.toolStripButtonSaveKanban.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveKanban.Image")));
            this.toolStripButtonSaveKanban.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveKanban.Name = "toolStripButtonSaveKanban";
            this.toolStripButtonSaveKanban.Size = new System.Drawing.Size(67, 29);
            this.toolStripButtonSaveKanban.Text = "Save";
            this.toolStripButtonSaveKanban.Click += new System.EventHandler(this.toolStripButtonSaveKanban_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(82, 29);
            this.toolStripButton2.Text = "Restore";
            // 
            // TaskPlanningPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripKanban);
            this.Name = "TaskPlanningPanel";
            this.Size = new System.Drawing.Size(997, 629);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).EndInit();
            this.toolStripKanban.ResumeLayout(false);
            this.toolStripKanban.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Calendar.MonthView monthView1;
        private System.Windows.Forms.Calendar.Calendar calendar1;
        private System.Windows.Forms.BindingSource todoBindingSource;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.BindingSource sprintBindingSource;
        private System.Windows.Forms.ToolStrip toolStripKanban;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveKanban;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private TaskSearchPanel taskSearchPanel1;
    }
}
