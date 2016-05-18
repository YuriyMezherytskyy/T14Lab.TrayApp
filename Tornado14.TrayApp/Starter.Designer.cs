namespace Tornado14.TrayApp
{
    partial class Starter
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
      this.listView1 = new System.Windows.Forms.ListView();
      this.panelStarter = new System.Windows.Forms.Panel();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
      this.wpfStarterComboBox1 = new Tornado14.TrayApp.Controls.WPFStarterComboBox();
      this.panelStarter.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // listView1
      // 
      this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.listView1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listView1.GridLines = true;
      this.listView1.Location = new System.Drawing.Point(10, 2);
      this.listView1.Name = "listView1";
      this.listView1.Size = new System.Drawing.Size(877, 143);
      this.listView1.TabIndex = 2;
      this.listView1.TileSize = new System.Drawing.Size(200, 40);
      this.listView1.UseCompatibleStateImageBehavior = false;
      this.listView1.View = System.Windows.Forms.View.Tile;
      this.listView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listView1_KeyPress);
      this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
      // 
      // panelStarter
      // 
      this.panelStarter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
      this.panelStarter.Controls.Add(this.listView1);
      this.panelStarter.Controls.Add(this.listBox1);
      this.panelStarter.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelStarter.Location = new System.Drawing.Point(1, 58);
      this.panelStarter.Margin = new System.Windows.Forms.Padding(2);
      this.panelStarter.Name = "panelStarter";
      this.panelStarter.Size = new System.Drawing.Size(898, 157);
      this.panelStarter.TabIndex = 15;
      // 
      // listBox1
      // 
      this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new System.Drawing.Point(681, 1);
      this.listBox1.Margin = new System.Windows.Forms.Padding(8);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(202, 143);
      this.listBox1.TabIndex = 3;
      this.listBox1.Visible = false;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
      this.panel1.Controls.Add(this.elementHost1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(1, 1);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(898, 57);
      this.panel1.TabIndex = 17;
      // 
      // elementHost1
      // 
      this.elementHost1.Location = new System.Drawing.Point(4, 5);
      this.elementHost1.Name = "elementHost1";
      this.elementHost1.Size = new System.Drawing.Size(889, 49);
      this.elementHost1.TabIndex = 17;
      this.elementHost1.Text = "elementHost1";
      this.elementHost1.Child = this.wpfStarterComboBox1;
      // 
      // Starter
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
      this.ClientSize = new System.Drawing.Size(900, 216);
      this.ControlBox = false;
      this.Controls.Add(this.panelStarter);
      this.Controls.Add(this.panel1);
      this.DoubleBuffered = true;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Starter";
      this.Opacity = 0.7D;
      this.Padding = new System.Windows.Forms.Padding(1);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Starter";
      this.Load += new System.EventHandler(this.Starter_Load);
      this.panelStarter.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panelStarter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Integration.ElementHost elementHost1;
    private Controls.WPFStarterComboBox wpfStarterComboBox1;
  }
}