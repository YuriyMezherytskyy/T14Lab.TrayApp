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
            this.labelColumn1 = new System.Windows.Forms.Label();
            this.panelColumnAvailableFilter = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRemoveInLine = new System.Windows.Forms.TabPage();
            this.tabPageRemoveLine = new System.Windows.Forms.TabPage();
            this.tabPageModifyLine = new System.Windows.Forms.TabPage();
            this.tabPageDuplicate = new System.Windows.Forms.TabPage();
            this.labelColumn2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panelColumnAvailableFilter.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            this.splitContainer2.Panel1.Controls.Add(this.labelColumn1);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel2.Controls.Add(this.panelColumnAvailableFilter);
            this.splitContainer2.Panel2.Controls.Add(this.labelColumn2);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(5);
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
            this.panelActiveFilter.Location = new System.Drawing.Point(5, 32);
            this.panelActiveFilter.Margin = new System.Windows.Forms.Padding(2);
            this.panelActiveFilter.Name = "panelActiveFilter";
            this.panelActiveFilter.Padding = new System.Windows.Forms.Padding(4, 0, 4, 1);
            this.panelActiveFilter.Size = new System.Drawing.Size(1046, 263);
            this.panelActiveFilter.TabIndex = 3;
            this.panelActiveFilter.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragDrop);
            this.panelActiveFilter.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragEnter);
            // 
            // labelColumn1
            // 
            this.labelColumn1.BackColor = System.Drawing.Color.Transparent;
            this.labelColumn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelColumn1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColumn1.ForeColor = System.Drawing.Color.Black;
            this.labelColumn1.Location = new System.Drawing.Point(5, 5);
            this.labelColumn1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 10);
            this.labelColumn1.Name = "labelColumn1";
            this.labelColumn1.Size = new System.Drawing.Size(1046, 27);
            this.labelColumn1.TabIndex = 2;
            this.labelColumn1.Text = "Active Filter";
            // 
            // panelColumnAvailableFilter
            // 
            this.panelColumnAvailableFilter.AllowDrop = true;
            this.panelColumnAvailableFilter.AutoScroll = true;
            this.panelColumnAvailableFilter.Controls.Add(this.tabControl1);
            this.panelColumnAvailableFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelColumnAvailableFilter.Location = new System.Drawing.Point(5, 32);
            this.panelColumnAvailableFilter.Margin = new System.Windows.Forms.Padding(2);
            this.panelColumnAvailableFilter.Name = "panelColumnAvailableFilter";
            this.panelColumnAvailableFilter.Padding = new System.Windows.Forms.Padding(4, 0, 4, 1);
            this.panelColumnAvailableFilter.Size = new System.Drawing.Size(1046, 291);
            this.panelColumnAvailableFilter.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRemoveInLine);
            this.tabControl1.Controls.Add(this.tabPageRemoveLine);
            this.tabControl1.Controls.Add(this.tabPageModifyLine);
            this.tabControl1.Controls.Add(this.tabPageDuplicate);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(4, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1038, 290);
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
            this.tabPageRemoveInLine.Size = new System.Drawing.Size(1030, 257);
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
            this.tabPageRemoveLine.Size = new System.Drawing.Size(1030, 257);
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
            this.tabPageModifyLine.Size = new System.Drawing.Size(1030, 257);
            this.tabPageModifyLine.TabIndex = 2;
            this.tabPageModifyLine.Text = "Modify line";
            // 
            // tabPageDuplicate
            // 
            this.tabPageDuplicate.AllowDrop = true;
            this.tabPageDuplicate.AutoScroll = true;
            this.tabPageDuplicate.BackColor = System.Drawing.Color.White;
            this.tabPageDuplicate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageDuplicate.Location = new System.Drawing.Point(4, 29);
            this.tabPageDuplicate.Name = "tabPageDuplicate";
            this.tabPageDuplicate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDuplicate.Size = new System.Drawing.Size(1030, 257);
            this.tabPageDuplicate.TabIndex = 3;
            this.tabPageDuplicate.Text = "Duplicate";
            // 
            // labelColumn2
            // 
            this.labelColumn2.BackColor = System.Drawing.Color.Transparent;
            this.labelColumn2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelColumn2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColumn2.ForeColor = System.Drawing.Color.Black;
            this.labelColumn2.Location = new System.Drawing.Point(5, 5);
            this.labelColumn2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 4);
            this.labelColumn2.Name = "labelColumn2";
            this.labelColumn2.Size = new System.Drawing.Size(1046, 27);
            this.labelColumn2.TabIndex = 3;
            this.labelColumn2.Text = "Available filter";
            // 
            // ScenarioSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer2);
            this.Name = "ScenarioSelector";
            this.Size = new System.Drawing.Size(1058, 636);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panelColumnAvailableFilter.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label labelColumn1;
        private System.Windows.Forms.Panel panelColumnAvailableFilter;
        private System.Windows.Forms.Label labelColumn2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRemoveInLine;
        private System.Windows.Forms.TabPage tabPageRemoveLine;
        private System.Windows.Forms.TabPage tabPageModifyLine;
        private System.Windows.Forms.TabPage tabPageDuplicate;
        public System.Windows.Forms.Panel panelActiveFilter;
    }
}
