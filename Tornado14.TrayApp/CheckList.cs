using Antlr4.StringTemplate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Tornado14.Task;
using Tornado14.TrayApp.Properties;
using Tornado14Lab.Utils;
using Tornado14Lab.Utils.DataGridViewHelper;
using Tornado14Lab.Utils.NativeTheme;

namespace Tornado14.TrayApp
{
    public partial class CheckList : Form
    {

        RichTextBox currentRichTextBox;
        private string currentTemplate;
        private List<string> templateList;

        public CheckList()
        {
            InitializeComponent();

            DirectoryInfo localFolder = new DirectoryInfo(Path.Combine(Application.StartupPath, "checklists"));
            DirectoryInfo networkFolder = new DirectoryInfo(Path.Combine(Settings.Default.DataFolder, "checklists"));

            foreach (FileInfo configurationFile in localFolder.GetFiles())
            {
                if (configurationFile.Extension == ".xml")
                {
                    ChecklistFile newChecklist = new ChecklistFile(configurationFile.Name, configurationFile, true);
                    CBChecklistSelector.Items.Add(newChecklist);
                }
            }

            foreach (FileInfo configurationFile in networkFolder.GetFiles())
            {
                if (configurationFile.Extension == ".xml")
                {
                    ChecklistFile newChecklist = new ChecklistFile(configurationFile.Name, configurationFile, false);
                    CBChecklistSelector.Items.Add(newChecklist);
                }
            }

            SetGridStyle();
        }

        #region Events

        private void dataGridViewChecklist_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            renderEmail();
        }

        private void CBChecklistSelector_SelectedValueChanged(object sender, EventArgs e)
        {
            loadSelectedXMLFile();
            renderEmail();
            CBChecklistSelector.Focus();
        }

        private void dataGridViewChecklist_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AfterBindingGridStyle();
        }

        private void dataGridViewChecklist_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ChecklistFile selectedChecklist = (ChecklistFile)CBChecklistSelector.SelectedItem;
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                ChecklistItem item = (ChecklistItem)senderGrid.Rows[index].DataBoundItem;
                if (e.ColumnIndex == 4)
                {
                    if (item.Hilfe.Programm != null && item.Hilfe.Programm.Length > 0)
                    {
                        ProcessStartInfo processInfo;
                        processInfo = new ProcessStartInfo(item.Hilfe.Programm, item.Hilfe.Parameter);
                        processInfo.UseShellExecute = true;
                        Process.Start(processInfo);
                    }
                }
                else
                {
                    string filename = item.Funktion.Programm;
                    if (selectedChecklist != null)
                    {
                        FileInfo batchFile = new FileInfo(selectedChecklist.DirectoryWithFiles.FullName + @"\" + filename);
                        if (batchFile.Exists)
                        {
                            int exitCode;
                            ProcessStartInfo processInfo;
                            Process process;
                            string parameters = "";
                            if (item.Parameter != null)
                            {
                                parameters = item.Parameter.Replace(';', ' ');
                            }


                            Template parameterTemplate = initXMLFileTemplate(parameters);
                            string gerendeteparameter = parameterTemplate.Render();
                            processInfo = new ProcessStartInfo("cmd.exe", "/c " + batchFile.FullName + " " + gerendeteparameter);
                            processInfo.CreateNoWindow = false;
                            processInfo.UseShellExecute = false;
                            // *** Redirect the output ***
                            processInfo.RedirectStandardError = true;
                            processInfo.RedirectStandardOutput = true;

                            process = Process.Start(processInfo);
                            process.WaitForExit();

                            // *** Read the streams ***
                            // Warning: This approach can lead to deadlocks, see Edit #2
                            string output = process.StandardOutput.ReadToEnd();
                            string error = process.StandardError.ReadToEnd();

                            exitCode = process.ExitCode;
                            item.Resultat = exitCode.ToString();
                            //item.Funktion = "Pressed";
                            richTextBoxLog.BeginInvoke((MethodInvoker)delegate
                            {
                                AppendLogText(string.Format("Punkt '{0}', Funktion '{2}', Parameter '{1}'", item.Nummer, gerendeteparameter, item.Funktion.Programm), Color.FromArgb(128, 207, 240));
                                //AppendLogText(output, Color.Black);
                                if (error.Length > 0)
                                {
                                    AppendLogText("Error: " + error + "\r\n\r\n", Color.Red);
                                }
                                if (exitCode > 0)
                                {
                                    AppendLogText("Exit Code: " + exitCode + "\r\n\r\n", Color.Green);
                                }
                            });
                            foreach (Resultat resultat in item.Funktion.ResultatList)
                            {
                                if (item.Resultat == resultat.ResultatCode)
                                {
                                    ProcessResultat(resultat, false);
                                }
                            }
                        }
                    }
                }
            }
            dataGridViewChecklist.Refresh();
            richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length; //Set the current caret position at the end
            richTextBoxLog.ScrollToCaret();
        }

        private void ProcessResultat(Resultat resultat, bool invert)
        {
            if (resultat != null)
            {
                // Active Template
                foreach (TabPage page in tcTemplates.TabPages)
                {
                    if (resultat.Template != null)
                    {
                        if (page.Text == resultat.Template)
                        {
                            tcTemplates.SelectedTab = page;
                        }
                    }
                }

                // Rows visibility
                if (invert)
                {
                    if (resultat.Enable != null && resultat.Enable.Length > 0)
                    {
                        RowsVisibility(resultat.Enable.Split(';'), false);
                    }
                    if (resultat.Disable != null && resultat.Disable.Length > 0)
                    {
                        RowsVisibility(resultat.Disable.Split(';'), true);
                    }
                }
                else
                {
                    if (resultat.Disable != null && resultat.Disable.Length > 0)
                    {
                        RowsVisibility(resultat.Disable.Split(';'), false);
                    }
                    if (resultat.Enable != null && resultat.Enable.Length > 0)
                    {
                        RowsVisibility(resultat.Enable.Split(';'), true);
                    }
                }
            }
        }

        void process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            richTextBoxLog.BeginInvoke((MethodInvoker)delegate
            {
                richTextBoxLog.Text += e.Data + "\r\n"; // runs on UI thread
            });
        }

        private void buttonClearLogOutput_Click(object sender, EventArgs e)
        {
            richTextBoxLog.Text = "";
        }

        private void tcTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage selectedPage = tcTemplates.SelectedTab;
            if (selectedPage != null)
            {
                foreach (Control control in selectedPage.Controls)
                {
                    if (control is RichTextBox)
                    {
                        ChecklistFile selectedChecklist = (ChecklistFile)CBChecklistSelector.SelectedItem;
                        currentRichTextBox = (RichTextBox)control;
                        currentTemplate = System.IO.File.ReadAllText(selectedChecklist.DirectoryWithFiles.FullName + @"\" + selectedPage.Text);
                        renderEmail();
                    }
                }
            }
        }
        
        #endregion

        #region Methods

        private void loadSelectedXMLFile()
        {
            if (CBChecklistSelector.SelectedItem is ChecklistFile)
            {
                ChecklistFile selectedChecklist = (ChecklistFile)CBChecklistSelector.SelectedItem;
                checklistBindingSource.DataSource = SortableBindingListHelper.GetBindingListFromXmlFile<ChecklistItem>(selectedChecklist.File.FullName);
                foreach (DataGridViewRow row in dataGridViewChecklist.Rows)
                {
                    ChecklistItem item3 = (ChecklistItem)row.DataBoundItem;
                    if (item3.Versteckt)
                    {
                        row.Visible = false;
                    }
                }

                templateList = new List<string>();
                currentTemplate = null;
                tcTemplates.TabPages.Clear();
                TabPage happyPathPage = null;
                foreach (FileInfo template in selectedChecklist.DirectoryWithFiles.GetFiles("*.txt"))
                {
                    templateList.Add(template.Name);
                    RichTextBox richTextBox = new RichTextBox();
                    TabPage tabpage = new TabPage();
                    tabpage.Text = template.Name;
                    tabpage.Controls.Add(richTextBox);
                    tcTemplates.TabPages.Add(tabpage);
                    richTextBox.Dock = DockStyle.Fill;
                    richTextBox.BorderStyle = BorderStyle.None;
                    if (template.Name == selectedChecklist.HappyPathTemplateName)
                    {
                        FileInfo happyPathTemplate = selectedChecklist.GetHappyPathTemplate();
                        currentTemplate = System.IO.File.ReadAllText(happyPathTemplate.FullName);
                        currentRichTextBox = richTextBox;
                        happyPathPage = tabpage;
                    }
                }

                if (happyPathPage != null)
                {
                    tcTemplates.SelectedTab = happyPathPage;
                    renderEmail();
                }
            }
        }

        private Template initXMLFileTemplate(string templateString)
        {
            Template mailTemplate = new Template(templateString);
            foreach (DataGridViewRow row in dataGridViewChecklist.Rows)
            {
                ChecklistItem item = (ChecklistItem)row.DataBoundItem;
                if (item.SetupJa)
                {
                    mailTemplate.Add(string.Format("n{0}f", item.Nummer.ToString()), (item.Ja) ? "true" : null);
                }
                if (item.Parameter != null)
                {
                    string[] parameters2 = item.Parameter.Split(';');
                    int paramsCount = 1;
                    foreach (string parameter in parameters2)
                    {
                        mailTemplate.Add(string.Format("n{0}p{1}", item.Nummer.ToString(), paramsCount), parameter);
                        paramsCount++;
                    }
                }
            }
            return mailTemplate;
        }

        private void SetGridStyle()
        {
            dataGridViewChecklist.RowTemplate.Height = 35;
            dataGridViewChecklist.GridColor = Color.FromArgb(221, 245, 255);
            dataGridViewChecklist.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewChecklist.ColumnHeadersHeight = 40;
            dataGridViewChecklist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dataGridViewChecklist.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 207, 240);
            dataGridViewChecklist.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewChecklist.EnableHeadersVisualStyles = false;
            dataGridViewChecklist.DefaultCellStyle.BackColor = Color.White;
            dataGridViewChecklist.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewChecklist.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewChecklist.RowHeadersVisible = false;
            dataGridViewChecklist.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 207, 240);
            dataGridViewChecklist.BorderStyle = BorderStyle.None;
            dataGridViewChecklist.BackgroundColor = Color.White;

        }

        private void AfterBindingGridStyle()
        {
            DataGridViewButtonColumn c = (DataGridViewButtonColumn)dataGridViewChecklist.Columns[4];
            c.FlatStyle = FlatStyle.Popup;
            c.DefaultCellStyle.ForeColor = Color.Black;
            c.DefaultCellStyle.BackColor = Color.White;


            DataGridViewButtonColumn d = (DataGridViewButtonColumn)dataGridViewChecklist.Columns[6];
            d.FlatStyle = FlatStyle.Popup;
            d.DefaultCellStyle.ForeColor = Color.Black;
            d.DefaultCellStyle.BackColor = Color.White;

            foreach (DataGridViewRow row in dataGridViewChecklist.Rows)
            {
                ChecklistItem item = (ChecklistItem)row.DataBoundItem;
                if (item != null)
                {
                    if (item.Nummer == null || item.Nummer.Length < 1)
                    {
                        row.Cells[3].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
                    }
                    row.Cells[1].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);

                    if (item.Hilfe == null || item.Hilfe.Programm != null)
                    {
                        row.Cells[4] = new DataGridViewTextBoxCell();
                        row.Cells[4].ReadOnly = true;
                    }

                    if (!item.SetupJa)
                    {
                        row.Cells[2] = new DataGridViewTextBoxCell();
                        row.Cells[2].Style.ForeColor = Color.Transparent;
                        row.Cells[2].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.1F, System.Drawing.FontStyle.Regular);
                        row.Cells[2].ReadOnly = true;
                    }
                    if (item.Funktion != null && String.IsNullOrEmpty(item.Funktion.Programm))
                    {
                        row.Cells[6] = new DataGridViewTextBoxCell();
                        row.Cells[6].ReadOnly = true;
                    }
                }
            }
        }

        private void RowsVisibility(string[] rowsNumbers, bool visible)
        {
            foreach (string rowNo in rowsNumbers)
            {
                foreach (DataGridViewRow row in dataGridViewChecklist.Rows)
                {
                    ChecklistItem item2 = (ChecklistItem)row.DataBoundItem;
                    if (item2.Nummer == rowNo)
                    {
                        row.Visible = visible;
                    }
                }
            }
        }

        private void saveGridTo(string filename)
        {
            DirectoryInfo dataFolderProfiles = new DirectoryInfo(Path.Combine(Settings.Default.DataFolder, "checklists"));
            BindingSource source = (BindingSource)dataGridViewChecklist.DataSource;
            string data = XmlSerializationHelper.Serialize(source.List);
            StreamWriter file = new StreamWriter(dataFolderProfiles.FullName + @"\" + filename);
            file.WriteLine(data);
            file.Close();
        }



        private void renderEmail()
        {
            if (currentRichTextBox != null)
            {
                if (currentTemplate != null)
                {
                    Template email = initXMLFileTemplate(currentTemplate);
                    currentRichTextBox.BeginInvoke((MethodInvoker)delegate
                    {
                        currentRichTextBox.Text = email.Render();
                    });
                }
                else
                {
                    if (currentRichTextBox.Text != "")
                    {
                        currentRichTextBox.BeginInvoke((MethodInvoker)delegate
                        {
                            currentRichTextBox.Text = "";
                        });
                    }
                }
            }
        }

        public void AppendLogText(string text, Color color, bool AddNewLine = false)
        {
            if (AddNewLine)
            {
                text += Environment.NewLine;
            }

            richTextBoxLog.SelectionStart = richTextBoxLog.TextLength;
            richTextBoxLog.SelectionLength = 0;

            richTextBoxLog.SelectionColor = color;
            richTextBoxLog.AppendText(text);
            richTextBoxLog.SelectionColor = richTextBoxLog.ForeColor;
        }

        #endregion

        private void dataGridViewChecklist_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewChecklist.CurrentCell.ColumnIndex == 2)
            {
                if (dataGridViewChecklist.IsCurrentCellDirty)
                {
                    dataGridViewChecklist.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
        }

        private void dataGridViewChecklist_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0 && dataGridViewChecklist.Rows[e.RowIndex].DataBoundItem is ChecklistItem)
            {
                ChecklistItem item = (ChecklistItem)dataGridViewChecklist.Rows[e.RowIndex].DataBoundItem;
                if (item.Ja)
                {
                    ProcessResultat(item.SetupJaFunktion, false);
                }
                else
                {
                    ProcessResultat(item.SetupJaFunktion, true);
                }
                renderEmail();
            }
        }

        private void richTextBoxLog_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }






    }
}
