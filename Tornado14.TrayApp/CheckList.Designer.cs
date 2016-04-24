namespace Tornado14.TrayApp
{
    partial class CheckList
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewChecklist = new System.Windows.Forms.DataGridView();
            this.Erledigt = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.aufgabeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hilfe = new System.Windows.Forms.DataGridViewButtonColumn();
            this.parameterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funktionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Resultat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checklistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tcTemplates = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonClearLogOutput = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CBChecklistSelector = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChecklist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checklistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tcTemplates.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 70);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewChecklist);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1399, 624);
            this.splitContainer1.SplitterDistance = 871;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridViewChecklist
            // 
            this.dataGridViewChecklist.AllowUserToAddRows = false;
            this.dataGridViewChecklist.AllowUserToDeleteRows = false;
            this.dataGridViewChecklist.AutoGenerateColumns = false;
            this.dataGridViewChecklist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewChecklist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewChecklist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewChecklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChecklist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Erledigt,
            this.nummerDataGridViewTextBoxColumn,
            this.jaDataGridViewCheckBoxColumn,
            this.aufgabeDataGridViewTextBoxColumn,
            this.Hilfe,
            this.parameterDataGridViewTextBoxColumn,
            this.funktionDataGridViewTextBoxColumn,
            this.Resultat});
            this.dataGridViewChecklist.DataSource = this.checklistBindingSource;
            this.dataGridViewChecklist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewChecklist.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewChecklist.Name = "dataGridViewChecklist";
            this.dataGridViewChecklist.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.dataGridViewChecklist.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewChecklist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChecklist.Size = new System.Drawing.Size(871, 624);
            this.dataGridViewChecklist.TabIndex = 0;
            this.dataGridViewChecklist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChecklist_CellContentClick_1);
            this.dataGridViewChecklist.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChecklist_CellEndEdit);
            this.dataGridViewChecklist.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChecklist_CellValueChanged);
            this.dataGridViewChecklist.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewChecklist_CurrentCellDirtyStateChanged);
            this.dataGridViewChecklist.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewChecklist_DataBindingComplete);
            // 
            // Erledigt
            // 
            this.Erledigt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Erledigt.HeaderText = "";
            this.Erledigt.Name = "Erledigt";
            this.Erledigt.Width = 50;
            // 
            // nummerDataGridViewTextBoxColumn
            // 
            this.nummerDataGridViewTextBoxColumn.DataPropertyName = "Nummer";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nummerDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.nummerDataGridViewTextBoxColumn.HeaderText = "No.";
            this.nummerDataGridViewTextBoxColumn.Name = "nummerDataGridViewTextBoxColumn";
            this.nummerDataGridViewTextBoxColumn.ReadOnly = true;
            this.nummerDataGridViewTextBoxColumn.Width = 60;
            // 
            // jaDataGridViewCheckBoxColumn
            // 
            this.jaDataGridViewCheckBoxColumn.DataPropertyName = "Ja";
            this.jaDataGridViewCheckBoxColumn.HeaderText = "Ja";
            this.jaDataGridViewCheckBoxColumn.Name = "jaDataGridViewCheckBoxColumn";
            this.jaDataGridViewCheckBoxColumn.Width = 50;
            // 
            // aufgabeDataGridViewTextBoxColumn
            // 
            this.aufgabeDataGridViewTextBoxColumn.DataPropertyName = "Aufgabe";
            this.aufgabeDataGridViewTextBoxColumn.HeaderText = "Aufgabe";
            this.aufgabeDataGridViewTextBoxColumn.Name = "aufgabeDataGridViewTextBoxColumn";
            this.aufgabeDataGridViewTextBoxColumn.ReadOnly = true;
            this.aufgabeDataGridViewTextBoxColumn.Width = 250;
            // 
            // Hilfe
            // 
            this.Hilfe.DataPropertyName = "Hilfe";
            this.Hilfe.HeaderText = "Hilfe";
            this.Hilfe.Name = "Hilfe";
            this.Hilfe.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Hilfe.Text = "?";
            this.Hilfe.UseColumnTextForButtonValue = true;
            this.Hilfe.Width = 70;
            // 
            // parameterDataGridViewTextBoxColumn
            // 
            this.parameterDataGridViewTextBoxColumn.DataPropertyName = "Parameter";
            this.parameterDataGridViewTextBoxColumn.HeaderText = "Parameter";
            this.parameterDataGridViewTextBoxColumn.Name = "parameterDataGridViewTextBoxColumn";
            this.parameterDataGridViewTextBoxColumn.Width = 150;
            // 
            // funktionDataGridViewTextBoxColumn
            // 
            this.funktionDataGridViewTextBoxColumn.DataPropertyName = "Funktion";
            this.funktionDataGridViewTextBoxColumn.HeaderText = "Funktion";
            this.funktionDataGridViewTextBoxColumn.Name = "funktionDataGridViewTextBoxColumn";
            this.funktionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.funktionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.funktionDataGridViewTextBoxColumn.Width = 120;
            // 
            // Resultat
            // 
            this.Resultat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Resultat.DataPropertyName = "Resultat";
            this.Resultat.HeaderText = "Resultat";
            this.Resultat.Name = "Resultat";
            this.Resultat.ReadOnly = true;
            // 
            // checklistBindingSource
            // 
            this.checklistBindingSource.DataSource = typeof(Tornado14.Task.ChecklistItem);
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackColor = System.Drawing.Color.Black;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.panel6);
            this.splitContainer3.Panel1.Controls.Add(this.panel4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.richTextBoxLog);
            this.splitContainer3.Panel2.Controls.Add(this.panel3);
            this.splitContainer3.Size = new System.Drawing.Size(525, 624);
            this.splitContainer3.SplitterDistance = 312;
            this.splitContainer3.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.panel6.Controls.Add(this.tcTemplates);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 39);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(525, 273);
            this.panel6.TabIndex = 6;
            // 
            // tcTemplates
            // 
            this.tcTemplates.Controls.Add(this.tabPage1);
            this.tcTemplates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTemplates.Location = new System.Drawing.Point(0, 0);
            this.tcTemplates.Margin = new System.Windows.Forms.Padding(0);
            this.tcTemplates.Name = "tcTemplates";
            this.tcTemplates.Padding = new System.Drawing.Point(0, 0);
            this.tcTemplates.SelectedIndex = 0;
            this.tcTemplates.Size = new System.Drawing.Size(525, 273);
            this.tcTemplates.TabIndex = 5;
            this.tcTemplates.SelectedIndexChanged += new System.EventHandler(this.tcTemplates_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(517, 247);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "template1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(525, 39);
            this.panel4.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Antwort";
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.richTextBoxLog.HideSelection = false;
            this.richTextBoxLog.Location = new System.Drawing.Point(0, 39);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(525, 269);
            this.richTextBoxLog.TabIndex = 0;
            this.richTextBoxLog.Text = "";
            this.richTextBoxLog.TextChanged += new System.EventHandler(this.richTextBoxLog_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.panel3.Controls.Add(this.buttonClearLogOutput);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(525, 39);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // buttonClearLogOutput
            // 
            this.buttonClearLogOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearLogOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearLogOutput.ForeColor = System.Drawing.Color.White;
            this.buttonClearLogOutput.Location = new System.Drawing.Point(175, 5);
            this.buttonClearLogOutput.Name = "buttonClearLogOutput";
            this.buttonClearLogOutput.Size = new System.Drawing.Size(115, 30);
            this.buttonClearLogOutput.TabIndex = 10;
            this.buttonClearLogOutput.Text = "Bereinigen";
            this.buttonClearLogOutput.UseVisualStyleBackColor = true;
            this.buttonClearLogOutput.Click += new System.EventHandler(this.buttonClearLogOutput_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Funktionsausgabe";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CBChecklistSelector);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1399, 70);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(877, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.CBChecklistSelector_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(161, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Checklist:";
            // 
            // CBChecklistSelector
            // 
            this.CBChecklistSelector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBChecklistSelector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBChecklistSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBChecklistSelector.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBChecklistSelector.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CBChecklistSelector.FormattingEnabled = true;
            this.CBChecklistSelector.Location = new System.Drawing.Point(272, 22);
            this.CBChecklistSelector.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.CBChecklistSelector.Name = "CBChecklistSelector";
            this.CBChecklistSelector.Size = new System.Drawing.Size(599, 41);
            this.CBChecklistSelector.TabIndex = 5;
            this.CBChecklistSelector.SelectedValueChanged += new System.EventHandler(this.CBChecklistSelector_SelectedValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(1296, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(103, 70);
            this.panel2.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 70);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1399, 3);
            this.panel5.TabIndex = 3;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.DataPropertyName = "Hilfe";
            this.dataGridViewButtonColumn1.HeaderText = "Hilfe";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.Text = "?";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Resultat";
            this.dataGridViewTextBoxColumn1.HeaderText = "Resultat";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // CheckList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 694);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "CheckList";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChecklist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checklistBindingSource)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tcTemplates.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.BindingSource checklistBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewChecklist;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CBChecklistSelector;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonClearLogOutput;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TabControl tcTemplates;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Erledigt;
        private System.Windows.Forms.DataGridViewTextBoxColumn nummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn jaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aufgabeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Hilfe;
        private System.Windows.Forms.DataGridViewTextBoxColumn parameterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn funktionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultat;
    }
}