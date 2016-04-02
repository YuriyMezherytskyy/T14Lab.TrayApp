using Tornado14.TrayApp.Controls.Task;

namespace Tornado14.TrayApp.Controls.Task
{
    partial class SprintKanbanPanel
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
            this.panelKanban = new System.Windows.Forms.Panel();
            this.panelKanbanGray = new System.Windows.Forms.Panel();
            this.splitContainerKanban = new System.Windows.Forms.SplitContainer();
            this.panel5 = new System.Windows.Forms.Panel();
            this.taskSearchPanel1 = new Tornado14.TrayApp.Controls.Task.TaskSearchPanel();
            this.buttonKanBanTasksSeparator = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panelColumn5 = new System.Windows.Forms.Panel();
            this.labelColumn5 = new System.Windows.Forms.Label();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelColumn4 = new System.Windows.Forms.Panel();
            this.labelColumn4 = new System.Windows.Forms.Label();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelColumn3 = new System.Windows.Forms.Panel();
            this.labelColumn3 = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelColumn2 = new System.Windows.Forms.Panel();
            this.labelColumn2 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelColumn1 = new System.Windows.Forms.Panel();
            this.labelColumn1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelProjectList = new System.Windows.Forms.FlowLayoutPanel();
            this.labelDaysLeft = new System.Windows.Forms.Label();
            this.ShowKanban = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCurrentSprint = new System.Windows.Forms.ComboBox();
            this.sprintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.todoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelKanban.SuspendLayout();
            this.panelKanbanGray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerKanban)).BeginInit();
            this.splitContainerKanban.Panel1.SuspendLayout();
            this.splitContainerKanban.Panel2.SuspendLayout();
            this.splitContainerKanban.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelKanban
            // 
            this.panelKanban.Controls.Add(this.panelKanbanGray);
            this.panelKanban.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKanban.Location = new System.Drawing.Point(0, 0);
            this.panelKanban.Margin = new System.Windows.Forms.Padding(2);
            this.panelKanban.Name = "panelKanban";
            this.panelKanban.Size = new System.Drawing.Size(2048, 421);
            this.panelKanban.TabIndex = 3;
            // 
            // panelKanbanGray
            // 
            this.panelKanbanGray.Controls.Add(this.splitContainerKanban);
            this.panelKanbanGray.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKanbanGray.Location = new System.Drawing.Point(0, 0);
            this.panelKanbanGray.Margin = new System.Windows.Forms.Padding(2);
            this.panelKanbanGray.Name = "panelKanbanGray";
            this.panelKanbanGray.Padding = new System.Windows.Forms.Padding(1);
            this.panelKanbanGray.Size = new System.Drawing.Size(2048, 421);
            this.panelKanbanGray.TabIndex = 8;
            // 
            // splitContainerKanban
            // 
            this.splitContainerKanban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.splitContainerKanban.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerKanban.Location = new System.Drawing.Point(1, 1);
            this.splitContainerKanban.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainerKanban.Name = "splitContainerKanban";
            // 
            // splitContainerKanban.Panel1
            // 
            this.splitContainerKanban.Panel1.Controls.Add(this.panel5);
            this.splitContainerKanban.Panel1.Controls.Add(this.buttonKanBanTasksSeparator);
            this.splitContainerKanban.Panel1MinSize = 0;
            // 
            // splitContainerKanban.Panel2
            // 
            this.splitContainerKanban.Panel2.Controls.Add(this.panel8);
            this.splitContainerKanban.Panel2.Controls.Add(this.panel6);
            this.splitContainerKanban.Panel2MinSize = 0;
            this.splitContainerKanban.Size = new System.Drawing.Size(2046, 419);
            this.splitContainerKanban.SplitterDistance = 467;
            this.splitContainerKanban.SplitterWidth = 3;
            this.splitContainerKanban.TabIndex = 1;
            this.splitContainerKanban.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainerKanban_SplitterMoved);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.taskSearchPanel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(467, 419);
            this.panel5.TabIndex = 3;
            // 
            // taskSearchPanel1
            // 
            this.taskSearchPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskSearchPanel1.Location = new System.Drawing.Point(0, 0);
            this.taskSearchPanel1.Name = "taskSearchPanel1";
            this.taskSearchPanel1.Size = new System.Drawing.Size(467, 419);
            this.taskSearchPanel1.TabIndex = 0;
            // 
            // buttonKanBanTasksSeparator
            // 
            this.buttonKanBanTasksSeparator.BackColor = System.Drawing.Color.Transparent;
            this.buttonKanBanTasksSeparator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonKanBanTasksSeparator.FlatAppearance.BorderColor = System.Drawing.Color.PaleGoldenrod;
            this.buttonKanBanTasksSeparator.FlatAppearance.BorderSize = 0;
            this.buttonKanBanTasksSeparator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKanBanTasksSeparator.Location = new System.Drawing.Point(0, 0);
            this.buttonKanBanTasksSeparator.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKanBanTasksSeparator.Name = "buttonKanBanTasksSeparator";
            this.buttonKanBanTasksSeparator.Size = new System.Drawing.Size(467, 419);
            this.buttonKanBanTasksSeparator.TabIndex = 2;
            this.buttonKanBanTasksSeparator.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.splitter4);
            this.panel8.Controls.Add(this.panel4);
            this.panel8.Controls.Add(this.splitter3);
            this.panel8.Controls.Add(this.panel3);
            this.panel8.Controls.Add(this.splitter2);
            this.panel8.Controls.Add(this.panel2);
            this.panel8.Controls.Add(this.splitter1);
            this.panel8.Controls.Add(this.panel1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 96);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1576, 323);
            this.panel8.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.panelColumn5);
            this.panel9.Controls.Add(this.labelColumn5);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(1365, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.panel9.Size = new System.Drawing.Size(211, 323);
            this.panel9.TabIndex = 4;
            // 
            // panelColumn5
            // 
            this.panelColumn5.AllowDrop = true;
            this.panelColumn5.AutoScroll = true;
            this.panelColumn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelColumn5.Location = new System.Drawing.Point(0, 24);
            this.panelColumn5.Margin = new System.Windows.Forms.Padding(2);
            this.panelColumn5.Name = "panelColumn5";
            this.panelColumn5.Padding = new System.Windows.Forms.Padding(4, 0, 4, 1);
            this.panelColumn5.Size = new System.Drawing.Size(209, 297);
            this.panelColumn5.TabIndex = 5;
            this.panelColumn5.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragDrop);
            this.panelColumn5.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragEnter);
            // 
            // labelColumn5
            // 
            this.labelColumn5.AutoSize = true;
            this.labelColumn5.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelColumn5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColumn5.Location = new System.Drawing.Point(0, 3);
            this.labelColumn5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 4);
            this.labelColumn5.Name = "labelColumn5";
            this.labelColumn5.Size = new System.Drawing.Size(52, 21);
            this.labelColumn5.TabIndex = 4;
            this.labelColumn5.Text = "label4";
            // 
            // splitter4
            // 
            this.splitter4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.splitter4.Location = new System.Drawing.Point(1361, 0);
            this.splitter4.Margin = new System.Windows.Forms.Padding(2);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(4, 323);
            this.splitter4.TabIndex = 5;
            this.splitter4.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panelColumn4);
            this.panel4.Controls.Add(this.labelColumn4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(1082, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.panel4.Size = new System.Drawing.Size(279, 323);
            this.panel4.TabIndex = 2;
            // 
            // panelColumn4
            // 
            this.panelColumn4.AllowDrop = true;
            this.panelColumn4.AutoScroll = true;
            this.panelColumn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelColumn4.Location = new System.Drawing.Point(0, 24);
            this.panelColumn4.Margin = new System.Windows.Forms.Padding(2);
            this.panelColumn4.Name = "panelColumn4";
            this.panelColumn4.Padding = new System.Windows.Forms.Padding(4, 0, 4, 1);
            this.panelColumn4.Size = new System.Drawing.Size(277, 297);
            this.panelColumn4.TabIndex = 5;
            this.panelColumn4.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragDrop);
            this.panelColumn4.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragEnter);
            // 
            // labelColumn4
            // 
            this.labelColumn4.AutoSize = true;
            this.labelColumn4.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelColumn4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColumn4.Location = new System.Drawing.Point(0, 3);
            this.labelColumn4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 4);
            this.labelColumn4.Name = "labelColumn4";
            this.labelColumn4.Size = new System.Drawing.Size(52, 21);
            this.labelColumn4.TabIndex = 4;
            this.labelColumn4.Text = "label4";
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.splitter3.Location = new System.Drawing.Point(1078, 0);
            this.splitter3.Margin = new System.Windows.Forms.Padding(2);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(4, 323);
            this.splitter3.TabIndex = 3;
            this.splitter3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panelColumn3);
            this.panel3.Controls.Add(this.labelColumn3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(738, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.panel3.Size = new System.Drawing.Size(340, 323);
            this.panel3.TabIndex = 1;
            // 
            // panelColumn3
            // 
            this.panelColumn3.AllowDrop = true;
            this.panelColumn3.AutoScroll = true;
            this.panelColumn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelColumn3.Location = new System.Drawing.Point(0, 24);
            this.panelColumn3.Margin = new System.Windows.Forms.Padding(2);
            this.panelColumn3.Name = "panelColumn3";
            this.panelColumn3.Padding = new System.Windows.Forms.Padding(4, 0, 4, 1);
            this.panelColumn3.Size = new System.Drawing.Size(338, 297);
            this.panelColumn3.TabIndex = 4;
            this.panelColumn3.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragDrop);
            this.panelColumn3.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragEnter);
            // 
            // labelColumn3
            // 
            this.labelColumn3.AutoSize = true;
            this.labelColumn3.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelColumn3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColumn3.Location = new System.Drawing.Point(0, 3);
            this.labelColumn3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 4);
            this.labelColumn3.Name = "labelColumn3";
            this.labelColumn3.Size = new System.Drawing.Size(107, 21);
            this.labelColumn3.TabIndex = 3;
            this.labelColumn3.Text = "labelColumn3";
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.splitter2.Location = new System.Drawing.Point(734, 0);
            this.splitter2.Margin = new System.Windows.Forms.Padding(2);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(4, 323);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panelColumn2);
            this.panel2.Controls.Add(this.labelColumn2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(382, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.panel2.Size = new System.Drawing.Size(352, 323);
            this.panel2.TabIndex = 0;
            // 
            // panelColumn2
            // 
            this.panelColumn2.AllowDrop = true;
            this.panelColumn2.AutoScroll = true;
            this.panelColumn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelColumn2.Location = new System.Drawing.Point(0, 24);
            this.panelColumn2.Margin = new System.Windows.Forms.Padding(2);
            this.panelColumn2.Name = "panelColumn2";
            this.panelColumn2.Padding = new System.Windows.Forms.Padding(4, 0, 4, 1);
            this.panelColumn2.Size = new System.Drawing.Size(350, 297);
            this.panelColumn2.TabIndex = 2;
            this.panelColumn2.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragDrop);
            this.panelColumn2.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragEnter);
            // 
            // labelColumn2
            // 
            this.labelColumn2.AutoSize = true;
            this.labelColumn2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelColumn2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColumn2.Location = new System.Drawing.Point(0, 3);
            this.labelColumn2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 4);
            this.labelColumn2.Name = "labelColumn2";
            this.labelColumn2.Size = new System.Drawing.Size(107, 21);
            this.labelColumn2.TabIndex = 1;
            this.labelColumn2.Text = "labelColumn2";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.splitter1.Location = new System.Drawing.Point(378, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 323);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panelColumn1);
            this.panel1.Controls.Add(this.labelColumn1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.panel1.Size = new System.Drawing.Size(378, 323);
            this.panel1.TabIndex = 0;
            // 
            // panelColumn1
            // 
            this.panelColumn1.AllowDrop = true;
            this.panelColumn1.AutoScroll = true;
            this.panelColumn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelColumn1.Location = new System.Drawing.Point(0, 24);
            this.panelColumn1.Margin = new System.Windows.Forms.Padding(2);
            this.panelColumn1.Name = "panelColumn1";
            this.panelColumn1.Padding = new System.Windows.Forms.Padding(4, 0, 4, 1);
            this.panelColumn1.Size = new System.Drawing.Size(376, 297);
            this.panelColumn1.TabIndex = 1;
            this.panelColumn1.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragDrop);
            this.panelColumn1.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragEnter);
            // 
            // labelColumn1
            // 
            this.labelColumn1.AutoSize = true;
            this.labelColumn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelColumn1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColumn1.Location = new System.Drawing.Point(0, 3);
            this.labelColumn1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 4);
            this.labelColumn1.Name = "labelColumn1";
            this.labelColumn1.Size = new System.Drawing.Size(107, 21);
            this.labelColumn1.TabIndex = 0;
            this.labelColumn1.Text = "labelColumn2";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.checkBox5);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.checkBox6);
            this.panel6.Controls.Add(this.checkBox4);
            this.panel6.Controls.Add(this.checkBox3);
            this.panel6.Controls.Add(this.checkBox2);
            this.panel6.Controls.Add(this.checkBox1);
            this.panel6.Controls.Add(this.button3);
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.flowLayoutPanelProjectList);
            this.panel6.Controls.Add(this.labelDaysLeft);
            this.panel6.Controls.Add(this.ShowKanban);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.comboBoxCurrentSprint);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1576, 96);
            this.panel6.TabIndex = 1;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // checkBox5
            // 
            this.checkBox5.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox5.AutoSize = true;
            this.checkBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.checkBox5.FlatAppearance.BorderSize = 0;
            this.checkBox5.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.checkBox5.Location = new System.Drawing.Point(131, 59);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(28, 23);
            this.checkBox5.TabIndex = 22;
            this.checkBox5.Text = "All";
            this.checkBox5.UseVisualStyleBackColor = false;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Process";
            // 
            // checkBox6
            // 
            this.checkBox6.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox6.AutoSize = true;
            this.checkBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.FlatAppearance.BorderSize = 0;
            this.checkBox6.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.checkBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.checkBox6.Location = new System.Drawing.Point(366, 59);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(43, 23);
            this.checkBox6.TabIndex = 20;
            this.checkBox6.Text = "Done";
            this.checkBox6.UseVisualStyleBackColor = false;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.FlatAppearance.BorderSize = 0;
            this.checkBox4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.checkBox4.Location = new System.Drawing.Point(327, 59);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(38, 23);
            this.checkBox4.TabIndex = 18;
            this.checkBox4.Text = "Test";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.FlatAppearance.BorderSize = 0;
            this.checkBox3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.checkBox3.Location = new System.Drawing.Point(267, 59);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(58, 23);
            this.checkBox3.TabIndex = 17;
            this.checkBox3.Text = "Progress";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.FlatAppearance.BorderSize = 0;
            this.checkBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.checkBox2.Location = new System.Drawing.Point(219, 59);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(47, 23);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "Today";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.FlatAppearance.BorderSize = 0;
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.checkBox1.Location = new System.Drawing.Point(161, 59);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 23);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Planned";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(993, 10);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 19);
            this.button3.TabIndex = 14;
            this.button3.Text = "Paste";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(912, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 19);
            this.button2.TabIndex = 13;
            this.button2.Text = "Copy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(800, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 19);
            this.button1.TabIndex = 12;
            this.button1.Text = "Create Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Project in this sprint";
            // 
            // flowLayoutPanelProjectList
            // 
            this.flowLayoutPanelProjectList.Location = new System.Drawing.Point(129, 37);
            this.flowLayoutPanelProjectList.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelProjectList.Name = "flowLayoutPanelProjectList";
            this.flowLayoutPanelProjectList.Size = new System.Drawing.Size(974, 27);
            this.flowLayoutPanelProjectList.TabIndex = 10;
            // 
            // labelDaysLeft
            // 
            this.labelDaysLeft.AutoSize = true;
            this.labelDaysLeft.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDaysLeft.Location = new System.Drawing.Point(719, 10);
            this.labelDaysLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDaysLeft.Name = "labelDaysLeft";
            this.labelDaysLeft.Size = new System.Drawing.Size(81, 21);
            this.labelDaysLeft.TabIndex = 9;
            this.labelDaysLeft.Text = "5 days left";
            // 
            // ShowKanban
            // 
            this.ShowKanban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowKanban.Location = new System.Drawing.Point(652, 9);
            this.ShowKanban.Margin = new System.Windows.Forms.Padding(2);
            this.ShowKanban.Name = "ShowKanban";
            this.ShowKanban.Size = new System.Drawing.Size(63, 19);
            this.ShowKanban.TabIndex = 8;
            this.ShowKanban.Text = "Show";
            this.ShowKanban.UseVisualStyleBackColor = true;
            this.ShowKanban.Click += new System.EventHandler(this.buttonShowKanban_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kanban for Sprint";
            // 
            // comboBoxCurrentSprint
            // 
            this.comboBoxCurrentSprint.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCurrentSprint.BackColor = System.Drawing.Color.White;
            this.comboBoxCurrentSprint.DataSource = this.sprintBindingSource;
            this.comboBoxCurrentSprint.DisplayMember = "Summary";
            this.comboBoxCurrentSprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCurrentSprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCurrentSprint.FormattingEnabled = true;
            this.comboBoxCurrentSprint.Location = new System.Drawing.Point(131, 9);
            this.comboBoxCurrentSprint.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCurrentSprint.Name = "comboBoxCurrentSprint";
            this.comboBoxCurrentSprint.Size = new System.Drawing.Size(510, 28);
            this.comboBoxCurrentSprint.TabIndex = 1;
            this.comboBoxCurrentSprint.ValueMember = "pId";
            this.comboBoxCurrentSprint.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurrentSprint_SelectedIndexChanged);
            // 
            // sprintBindingSource
            // 
            this.sprintBindingSource.DataSource = typeof(Tornado14.Task.Sprint);
            this.sprintBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.sprintBindingSource_BindingComplete);
            this.sprintBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.sprintBindingSource_ListChanged);
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(Tornado14.Task.Project);
            this.projectBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.sprintBindingSource_BindingComplete);
            this.projectBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.projectBindingSource_ListChanged);
            // 
            // todoBindingSource
            // 
            this.todoBindingSource.DataSource = typeof(Tornado14.Task.Todo);
            this.todoBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.sprintBindingSource_BindingComplete);
            this.todoBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.todoBindingSource_ListChanged);
            // 
            // SprintKanbanPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelKanban);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SprintKanbanPanel";
            this.Size = new System.Drawing.Size(2048, 421);
            this.panelKanban.ResumeLayout(false);
            this.panelKanbanGray.ResumeLayout(false);
            this.splitContainerKanban.Panel1.ResumeLayout(false);
            this.splitContainerKanban.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerKanban)).EndInit();
            this.splitContainerKanban.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelKanban;
        private System.Windows.Forms.Panel panelKanbanGray;
        private System.Windows.Forms.SplitContainer splitContainerKanban;
        private System.Windows.Forms.Button buttonKanBanTasksSeparator;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelColumn4;
        private System.Windows.Forms.Label labelColumn4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelColumn3;
        private System.Windows.Forms.Label labelColumn3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelColumn2;
        private System.Windows.Forms.Label labelColumn2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelColumn1;
        private System.Windows.Forms.Label labelColumn1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCurrentSprint;
        private System.Windows.Forms.BindingSource todoBindingSource;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.BindingSource sprintBindingSource;
        private System.Windows.Forms.Button ShowKanban;
        private System.Windows.Forms.Label labelDaysLeft;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProjectList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panelColumn5;
        private System.Windows.Forms.Label labelColumn5;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Panel panel5;
        private TaskSearchPanel taskSearchPanel1;
    }
}
