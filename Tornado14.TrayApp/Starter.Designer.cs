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
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
      this.wpfStarterComboBox1 = new Tornado14.TrayApp.Controls.WPFStarterComboBox();
      this.panelStarter.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // listView1
      // 
      this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.listView1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listView1.GridLines = true;
      this.listView1.Location = new System.Drawing.Point(7, 6);
      this.listView1.Name = "listView1";
      this.listView1.Size = new System.Drawing.Size(667, 143);
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
      this.panelStarter.Location = new System.Drawing.Point(1, 74);
      this.panelStarter.Margin = new System.Windows.Forms.Padding(2);
      this.panelStarter.Name = "panelStarter";
      this.panelStarter.Size = new System.Drawing.Size(890, 156);
      this.panelStarter.TabIndex = 15;
      // 
      // listBox1
      // 
      this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new System.Drawing.Point(681, 6);
      this.listBox1.Margin = new System.Windows.Forms.Padding(8);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(202, 143);
      this.listBox1.TabIndex = 3;
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
      this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
      this.pictureBox1.ImageLocation = "";
      this.pictureBox1.Location = new System.Drawing.Point(701, 0);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
      this.pictureBox1.Size = new System.Drawing.Size(189, 73);
      this.pictureBox1.TabIndex = 16;
      this.pictureBox1.TabStop = false;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
      this.panel1.Controls.Add(this.elementHost1);
      this.panel1.Controls.Add(this.pictureBox1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(1, 1);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(890, 73);
      this.panel1.TabIndex = 17;
      // 
      // elementHost1
      // 
      this.elementHost1.Location = new System.Drawing.Point(6, 33);
      this.elementHost1.Name = "elementHost1";
      this.elementHost1.Size = new System.Drawing.Size(668, 38);
      this.elementHost1.TabIndex = 17;
      this.elementHost1.Text = "elementHost1";
      this.elementHost1.Child = this.wpfStarterComboBox1;
      // 
      // Starter
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(892, 231);
      this.ControlBox = false;
      this.Controls.Add(this.panelStarter);
      this.Controls.Add(this.panel1);
      this.DoubleBuffered = true;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Starter";
      this.Padding = new System.Windows.Forms.Padding(1);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Starter";
      this.Load += new System.EventHandler(this.Starter_Load);
      this.panelStarter.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panelStarter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Integration.ElementHost elementHost1;
    private Controls.WPFStarterComboBox wpfStarterComboBox1;
  }
}