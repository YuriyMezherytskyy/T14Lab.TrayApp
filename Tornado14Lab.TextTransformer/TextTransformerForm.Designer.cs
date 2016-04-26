namespace Tornado14Lab.TextTransformer
{
    partial class TextTransformerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextTransformerForm));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonProcess = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCopyInput = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClearInput = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCopyResult = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClearResult = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.scenarioSelector1 = new Tornado14Lab.TextTransformer.Controls.ScenarioSelector();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(442, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 608);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(446, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox2);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer1.Size = new System.Drawing.Size(991, 608);
            this.splitContainer1.SplitterDistance = 495;
            this.splitContainer1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButtonCopyInput,
            this.toolStripButtonClearInput,
            this.toolStripButtonProcess});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(493, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(493, 581);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(0, 25);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(490, 581);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripButtonCopyResult,
            this.toolStripButtonClearResult});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(490, 25);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButtonProcess
            // 
            this.toolStripButtonProcess.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonProcess.Image = global::Tornado14Lab.TextTransformer.Properties.Resources.fantasy1;
            this.toolStripButtonProcess.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonProcess.Name = "toolStripButtonProcess";
            this.toolStripButtonProcess.Size = new System.Drawing.Size(67, 22);
            this.toolStripButtonProcess.Text = "Process";
            this.toolStripButtonProcess.Click += new System.EventHandler(this.toolStripButtonProcess_Click);
            // 
            // toolStripButtonCopyInput
            // 
            this.toolStripButtonCopyInput.Image = global::Tornado14Lab.TextTransformer.Properties.Resources.copy;
            this.toolStripButtonCopyInput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCopyInput.Name = "toolStripButtonCopyInput";
            this.toolStripButtonCopyInput.Size = new System.Drawing.Size(122, 22);
            this.toolStripButtonCopyInput.Text = "Copy to clipboard";
            this.toolStripButtonCopyInput.Click += new System.EventHandler(this.toolStripButtonCopyInput_Click);
            // 
            // toolStripButtonClearInput
            // 
            this.toolStripButtonClearInput.Image = global::Tornado14Lab.TextTransformer.Properties.Resources.erase;
            this.toolStripButtonClearInput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClearInput.Name = "toolStripButtonClearInput";
            this.toolStripButtonClearInput.Size = new System.Drawing.Size(54, 22);
            this.toolStripButtonClearInput.Text = "Clear";
            this.toolStripButtonClearInput.Click += new System.EventHandler(this.toolStripButtonClearInput_Click);
            // 
            // toolStripButtonCopyResult
            // 
            this.toolStripButtonCopyResult.Image = global::Tornado14Lab.TextTransformer.Properties.Resources.copy;
            this.toolStripButtonCopyResult.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCopyResult.Name = "toolStripButtonCopyResult";
            this.toolStripButtonCopyResult.Size = new System.Drawing.Size(122, 22);
            this.toolStripButtonCopyResult.Text = "Copy to clipboard";
            this.toolStripButtonCopyResult.Click += new System.EventHandler(this.toolStripButtonCopyResult_Click);
            // 
            // toolStripButtonClearResult
            // 
            this.toolStripButtonClearResult.Image = global::Tornado14Lab.TextTransformer.Properties.Resources.erase;
            this.toolStripButtonClearResult.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClearResult.Name = "toolStripButtonClearResult";
            this.toolStripButtonClearResult.Size = new System.Drawing.Size(54, 22);
            this.toolStripButtonClearResult.Text = "Clear";
            this.toolStripButtonClearResult.Click += new System.EventHandler(this.toolStripButtonClearResult_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel1.Text = "Input";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel2.Text = "Output";
            // 
            // scenarioSelector1
            // 
            this.scenarioSelector1.Dock = System.Windows.Forms.DockStyle.Left;
            this.scenarioSelector1.Location = new System.Drawing.Point(4, 4);
            this.scenarioSelector1.Name = "scenarioSelector1";
            this.scenarioSelector1.Size = new System.Drawing.Size(438, 608);
            this.scenarioSelector1.TabIndex = 0;
            // 
            // TextTransformerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 616);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.scenarioSelector1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TextTransformerForm";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "Text transformer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ScenarioSelector scenarioSelector1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonProcess;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButtonCopyInput;
        private System.Windows.Forms.ToolStripButton toolStripButtonClearInput;
        private System.Windows.Forms.ToolStripButton toolStripButtonCopyResult;
        private System.Windows.Forms.ToolStripButton toolStripButtonClearResult;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}

