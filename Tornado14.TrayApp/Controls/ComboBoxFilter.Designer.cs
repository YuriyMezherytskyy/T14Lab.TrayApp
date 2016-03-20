namespace Tornado14.TrayApp.Controls
{
    partial class ComboBoxFilter
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
            this.comboBoxProject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxProject
            // 
            this.comboBoxProject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxProject.BackColor = System.Drawing.Color.White;
            this.comboBoxProject.DisplayMember = "pId";
            this.comboBoxProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProject.FormattingEnabled = true;
            this.comboBoxProject.IntegralHeight = false;
            this.comboBoxProject.ItemHeight = 20;
            this.comboBoxProject.Location = new System.Drawing.Point(5, 26);
            this.comboBoxProject.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxProject.Name = "comboBoxProject";
            this.comboBoxProject.Size = new System.Drawing.Size(327, 28);
            this.comboBoxProject.TabIndex = 10;
            this.comboBoxProject.ValueMember = "pId";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Label";
            this.label1.ForeColorChanged += new System.EventHandler(this.label1_ForeColorChanged);
            // 
            // ComboBoxFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxProject);
            this.Controls.Add(this.label1);
            this.Name = "ComboBoxFilter";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(337, 60);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Filter_MouseDown);
            this.MouseLeave += new System.EventHandler(this.Filter_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ComboBox comboBoxProject;
        protected System.Windows.Forms.Label label1;
    }
}
