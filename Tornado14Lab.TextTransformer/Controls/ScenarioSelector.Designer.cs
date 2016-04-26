namespace Tornado14Lab.TextTransformer.Controls
{
    partial class ScenarioSelector
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panelActiveFilter = new System.Windows.Forms.Panel();
            this.panelColumnAvailableFilter = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRemoveInLine = new System.Windows.Forms.TabPage();
            this.tabPageRemoveLine = new System.Windows.Forms.TabPage();
            this.tabPageModifyLine = new System.Windows.Forms.TabPage();
            this.tabPageDuplicate = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panelColumnAvailableFilter.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel1.Controls.Add(this.panelActiveFilter);
            this.splitContainer2.Panel1.Controls.Add(this.toolStrip2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel2.Controls.Add(this.panelColumnAvailableFilter);
            this.splitContainer2.Size = new System.Drawing.Size(1058, 636);
            this.splitContainer2.SplitterDistance = 302;
            this.splitContainer2.TabIndex = 14;
            // 
            // panelActiveFilter
            // 
            this.panelActiveFilter.AllowDrop = true;
            this.panelActiveFilter.AutoScroll = true;
            this.panelActiveFilter.BackColor = System.Drawing.Color.Transparent;
            this.panelActiveFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelActiveFilter.Location = new System.Drawing.Point(0, 25);
            this.panelActiveFilter.Margin = new System.Windows.Forms.Padding(2);
            this.panelActiveFilter.Name = "panelActiveFilter";
            this.panelActiveFilter.Padding = new System.Windows.Forms.Padding(4, 0, 4, 1);
            this.panelActiveFilter.Size = new System.Drawing.Size(1056, 275);
            this.panelActiveFilter.TabIndex = 3;
            this.panelActiveFilter.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragDrop);
            this.panelActiveFilter.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragEnter);
            // 
            // panelColumnAvailableFilter
            // 
            this.panelColumnAvailableFilter.AllowDrop = true;
            this.panelColumnAvailableFilter.AutoScroll = true;
            this.panelColumnAvailableFilter.Controls.Add(this.tabControl1);
            this.panelColumnAvailableFilter.Controls.Add(this.toolStrip1);
            this.panelColumnAvailableFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelColumnAvailableFilter.Location = new System.Drawing.Point(0, 0);
            this.panelColumnAvailableFilter.Margin = new System.Windows.Forms.Padding(2);
            this.panelColumnAvailableFilter.Name = "panelColumnAvailableFilter";
            this.panelColumnAvailableFilter.Size = new System.Drawing.Size(1056, 328);
            this.panelColumnAvailableFilter.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRemoveInLine);
            this.tabControl1.Controls.Add(this.tabPageRemoveLine);
            this.tabControl1.Controls.Add(this.tabPageModifyLine);
            this.tabControl1.Controls.Add(this.tabPageDuplicate);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1056, 303);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageRemoveInLine
            // 
            this.tabPageRemoveInLine.AllowDrop = true;
            this.tabPageRemoveInLine.AutoScroll = true;
            this.tabPageRemoveInLine.BackColor = System.Drawing.Color.White;
            this.tabPageRemoveInLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageRemoveInLine.Location = new System.Drawing.Point(4, 29);
            this.tabPageRemoveInLine.Name = "tabPageRemoveInLine";
            this.tabPageRemoveInLine.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRemoveInLine.Size = new System.Drawing.Size(1030, 259);
            this.tabPageRemoveInLine.TabIndex = 0;
            this.tabPageRemoveInLine.Text = "Remove In line";
            this.tabPageRemoveInLine.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragDrop);
            this.tabPageRemoveInLine.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragEnter);
            // 
            // tabPageRemoveLine
            // 
            this.tabPageRemoveLine.AllowDrop = true;
            this.tabPageRemoveLine.AutoScroll = true;
            this.tabPageRemoveLine.BackColor = System.Drawing.Color.White;
            this.tabPageRemoveLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageRemoveLine.Location = new System.Drawing.Point(4, 29);
            this.tabPageRemoveLine.Name = "tabPageRemoveLine";
            this.tabPageRemoveLine.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRemoveLine.Size = new System.Drawing.Size(1030, 259);
            this.tabPageRemoveLine.TabIndex = 1;
            this.tabPageRemoveLine.Text = "Remove Line";
            this.tabPageRemoveLine.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragDrop);
            this.tabPageRemoveLine.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragEnter);
            // 
            // tabPageModifyLine
            // 
            this.tabPageModifyLine.AllowDrop = true;
            this.tabPageModifyLine.AutoScroll = true;
            this.tabPageModifyLine.BackColor = System.Drawing.Color.White;
            this.tabPageModifyLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageModifyLine.Location = new System.Drawing.Point(4, 29);
            this.tabPageModifyLine.Name = "tabPageModifyLine";
            this.tabPageModifyLine.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageModifyLine.Size = new System.Drawing.Size(1030, 259);
            this.tabPageModifyLine.TabIndex = 2;
            this.tabPageModifyLine.Text = "Modify line";
            this.tabPageModifyLine.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragDrop);
            this.tabPageModifyLine.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragEnter);
            // 
            // tabPageDuplicate
            // 
            this.tabPageDuplicate.AllowDrop = true;
            this.tabPageDuplicate.AutoScroll = true;
            this.tabPageDuplicate.BackColor = System.Drawing.Color.White;
            this.tabPageDuplicate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageDuplicate.Location = new System.Drawing.Point(4, 22);
            this.tabPageDuplicate.Name = "tabPageDuplicate";
            this.tabPageDuplicate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDuplicate.Size = new System.Drawing.Size(1048, 277);
            this.tabPageDuplicate.TabIndex = 3;
            this.tabPageDuplicate.Text = "Duplicate";
            this.tabPageDuplicate.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragDrop);
            this.tabPageDuplicate.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragEnter);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1056, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Tornado14Lab.TextTransformer.Properties.Resources.refresh;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(63, 22);
            this.toolStripButton1.Text = "Reload";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(57, 22);
            this.toolStripLabel1.Text = "All filtres";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1056, 25);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(93, 22);
            this.toolStripLabel2.Text = "Selected Filtres";
            // 
            // ScenarioSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer2);
            this.Name = "ScenarioSelector";
            this.Size = new System.Drawing.Size(1058, 636);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panelColumnAvailableFilter.ResumeLayout(false);
            this.panelColumnAvailableFilter.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panelColumnAvailableFilter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRemoveInLine;
        private System.Windows.Forms.TabPage tabPageRemoveLine;
        private System.Windows.Forms.TabPage tabPageModifyLine;
        private System.Windows.Forms.TabPage tabPageDuplicate;
        public System.Windows.Forms.Panel panelActiveFilter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}
