namespace Tornado14.TrayApp.Controls.Task
{
    partial class TextBoxFilter
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.textBox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 58);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(337, 2);
      this.panel1.TabIndex = 49;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.textBox);
      this.panel2.Controls.Add(this.label1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Padding = new System.Windows.Forms.Padding(5);
      this.panel2.Size = new System.Drawing.Size(337, 58);
      this.panel2.TabIndex = 50;
      this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Filter_MouseDown);
      this.panel2.MouseLeave += new System.EventHandler(this.Filter_MouseLeave);
      this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Filter_MouseMove);
      // 
      // textBox
      // 
      this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox.Dock = System.Windows.Forms.DockStyle.Top;
      this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox.Location = new System.Drawing.Point(5, 26);
      this.textBox.Name = "textBox";
      this.textBox.Size = new System.Drawing.Size(327, 27);
      this.textBox.TabIndex = 50;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(5, 5);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 4);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(56, 21);
      this.label1.TabIndex = 49;
      this.label1.Text = "Label1";
      // 
      // TextBoxFilter
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "TextBoxFilter";
      this.Size = new System.Drawing.Size(337, 60);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    protected System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox;
  }
}
