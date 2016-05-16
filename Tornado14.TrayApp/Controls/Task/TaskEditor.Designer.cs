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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskEditor));
            this.panelTaskDetails = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.elementHost4 = new System.Windows.Forms.Integration.ElementHost();
            this.PublicTextField = new Tornado14.TrayApp.Controls.WPFRichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.elementHost3 = new System.Windows.Forms.Integration.ElementHost();
            this.ResultField = new Tornado14.TrayApp.Controls.WPFRichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.DescriptionField = new Tornado14.TrayApp.Controls.WPFRichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.CurrentStateField = new Tornado14.TrayApp.Controls.WPFRichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonIst = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSoll = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRecherche = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonResult = new System.Windows.Forms.ToolStripButton();
            this.todoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sprintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelTaskDetails.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTaskDetails
            // 
            this.panelTaskDetails.Controls.Add(this.panel5);
            this.panelTaskDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTaskDetails.Location = new System.Drawing.Point(0, 0);
            this.panelTaskDetails.Margin = new System.Windows.Forms.Padding(2);
            this.panelTaskDetails.Name = "panelTaskDetails";
            this.panelTaskDetails.Size = new System.Drawing.Size(671, 585);
            this.panelTaskDetails.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.toolStrip1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(4);
            this.panel5.Size = new System.Drawing.Size(671, 585);
            this.panel5.TabIndex = 55;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.elementHost4);
            this.panel4.Location = new System.Drawing.Point(422, 435);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(164, 139);
            this.panel4.TabIndex = 50;
            this.panel4.Visible = false;
            // 
            // elementHost4
            // 
            this.elementHost4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.elementHost4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost4.Location = new System.Drawing.Point(0, 0);
            this.elementHost4.Name = "elementHost4";
            this.elementHost4.Size = new System.Drawing.Size(164, 139);
            this.elementHost4.TabIndex = 49;
            this.elementHost4.Text = "elementHost4";
            this.elementHost4.Child = this.PublicTextField;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.elementHost3);
            this.panel3.Location = new System.Drawing.Point(440, 285);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(141, 126);
            this.panel3.TabIndex = 53;
            this.panel3.Visible = false;
            // 
            // elementHost3
            // 
            this.elementHost3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.elementHost3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost3.Location = new System.Drawing.Point(0, 0);
            this.elementHost3.Name = "elementHost3";
            this.elementHost3.Size = new System.Drawing.Size(141, 126);
            this.elementHost3.TabIndex = 47;
            this.elementHost3.Text = "elementHost3";
            this.elementHost3.Child = this.ResultField;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.elementHost2);
            this.panel2.Location = new System.Drawing.Point(519, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 102);
            this.panel2.TabIndex = 52;
            // 
            // elementHost2
            // 
            this.elementHost2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.elementHost2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost2.Location = new System.Drawing.Point(0, 0);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(141, 102);
            this.elementHost2.TabIndex = 45;
            this.elementHost2.Text = "elementHost2";
            this.elementHost2.Child = this.DescriptionField;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.elementHost1);
            this.panel1.Location = new System.Drawing.Point(47, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 150);
            this.panel1.TabIndex = 51;
            this.panel1.Visible = false;
            // 
            // elementHost1
            // 
            this.elementHost1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(234, 150);
            this.elementHost1.TabIndex = 43;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.CurrentStateField;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripButtonIst,
            this.toolStripButtonSoll,
            this.toolStripButtonRecherche,
            this.toolStripButtonResult});
            this.toolStrip1.Location = new System.Drawing.Point(4, 4);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(661, 25);
            this.toolStrip1.TabIndex = 55;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(186)))), ((int)(((byte)(125)))));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(102, 22);
            this.toolStripLabel1.Text = "Filtered Tasks";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 22);
            this.toolStripButton1.Text = "Files";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonIst
            // 
            this.toolStripButtonIst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonIst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.toolStripButtonIst.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonIst.Image")));
            this.toolStripButtonIst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonIst.Name = "toolStripButtonIst";
            this.toolStripButtonIst.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonIst.Text = "Ist";
            this.toolStripButtonIst.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButtonIst.Click += new System.EventHandler(this.toolStripButtonIst_Click);
            // 
            // toolStripButtonSoll
            // 
            this.toolStripButtonSoll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSoll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.toolStripButtonSoll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSoll.Image")));
            this.toolStripButtonSoll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSoll.Name = "toolStripButtonSoll";
            this.toolStripButtonSoll.Size = new System.Drawing.Size(30, 22);
            this.toolStripButtonSoll.Text = "Soll";
            this.toolStripButtonSoll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButtonSoll.Click += new System.EventHandler(this.toolStripButtonSoll_Click);
            // 
            // toolStripButtonRecherche
            // 
            this.toolStripButtonRecherche.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRecherche.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.toolStripButtonRecherche.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRecherche.Image")));
            this.toolStripButtonRecherche.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRecherche.Name = "toolStripButtonRecherche";
            this.toolStripButtonRecherche.Size = new System.Drawing.Size(66, 22);
            this.toolStripButtonRecherche.Text = "Recherche";
            this.toolStripButtonRecherche.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButtonRecherche.Click += new System.EventHandler(this.toolStripButtonRecherche_Click);
            // 
            // toolStripButtonResult
            // 
            this.toolStripButtonResult.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.toolStripButtonResult.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonResult.Image")));
            this.toolStripButtonResult.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonResult.Name = "toolStripButtonResult";
            this.toolStripButtonResult.Size = new System.Drawing.Size(43, 22);
            this.toolStripButtonResult.Text = "Result";
            this.toolStripButtonResult.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButtonResult.Click += new System.EventHandler(this.toolStripButtonResult_Click);
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
            // TaskEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelTaskDetails);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TaskEditor";
            this.Size = new System.Drawing.Size(671, 585);
            this.panelTaskDetails.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTaskDetails;
        private System.Windows.Forms.BindingSource todoBindingSource;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private WPFRichTextBox CurrentStateField;
        private System.Windows.Forms.Integration.ElementHost elementHost3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.BindingSource sprintBindingSource;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Integration.ElementHost elementHost4;
        private WPFRichTextBox PublicTextField;
        private WPFRichTextBox ResultField;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private WPFRichTextBox DescriptionField;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButtonIst;
        private System.Windows.Forms.ToolStripButton toolStripButtonSoll;
        private System.Windows.Forms.ToolStripButton toolStripButtonRecherche;
        private System.Windows.Forms.ToolStripButton toolStripButtonResult;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}
