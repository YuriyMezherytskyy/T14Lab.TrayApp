using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tornado14Lab.Utils.NativeTheme;
using System.Diagnostics;
using System.IO;
using Tornado14.Task;
using Tornado14Lab.Utils.File;

namespace Tornado14.TrayApp.Controls
{
    public partial class ProjectDevelopPanel : UserControl
    {
        public ProjectDevelopPanel()
        {
            InitializeComponent();
            label2.DataBindings.Add("Text", projectBindingSource, "ShortDescription", true);
            label3.DataBindings.Add("Text", projectBindingSource, "id", true);
            label4.ForeColor = BlackTheme.ColorTextNotifyBlue;
        }

        public BindingSource ProjectBindingSource
        {
            get
            {

                return projectBindingSource;
            }
            set
            {
                projectBindingSource = value;
            }
        }


        private void label2_TextChanged(object sender, EventArgs e)
        {
            label1.Text = string.Format("Develop \"{0}\" project", label2.Text);
        }

        private void projectBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            // Check if the data source has been updated, and that no error has occured.
            if (e.BindingCompleteContext ==
                BindingCompleteContext.DataSourceUpdate && e.Exception == null)

                // If not, end the current edit.
                e.Binding.BindingManagerBase.EndCurrentEdit();
        }

        private void buttonStartVisualStudioSolution_Click(object sender, EventArgs e)
        {
            bool valid = true;
            if (textBoxVisualStudioSolutionPath.Text.Length > 0)
            {
                FileInfo solution = new FileInfo(textBoxVisualStudioSolutionPath.Text);
                if (solution.Exists)
                {
                    Process.Start(@"C:\Program Files (x86)\Common7\IDE\devenv.exe", textBoxVisualStudioSolutionPath.Text);
                }
                else
                {
                    valid = false;
                }
            }
            else
            {
                valid = false;
            }
            if (!valid)
            {
                MessageBox.Show("Something goes wrong.", "Openning Solution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool valid = true;
            DirectoryInfo targetFolder = null;
            if (textBoxSvnRepository.Text.Length > 0)
            {
                Project project = (Project)projectBindingSource.Current;
                string tartgetFolderPath = string.Format(@"{0}{1}\\{3}",
                    ProjectExplorer.devFolderSvn,
                    FileHelper.RemoveBadCharactersFromFileName(string.Format("{0} {1}", project.Id, project.ShortDescription)),
                    comboBoxProjectVersion.Text);

                targetFolder = new DirectoryInfo(tartgetFolderPath);
                if (targetFolder.Exists)
                {
                    valid = false;
                }
            }
            else
            {
                valid = false;
            }
            if (!valid)
            {
                MessageBox.Show("Something goes wrong.", "Openning Solution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!targetFolder.Exists)
                {
                    targetFolder.Create();
                }
                Process.Start("svn", string.Format("checkout {0} \"{1}", textBoxSvnRepository.Text, targetFolder.ToString()));
            }
        }

        private void textBoxVisualStudioSolutionPath_TextChanged(object sender, EventArgs e)
        {
            if (textBoxVisualStudioSolutionPath.Text.Length > 5)
            {
                try
                {
                    FileInfo solutionFile = new FileInfo(textBoxVisualStudioSolutionPath.Text);
                    BindingList<SolutionProject> projects = new BindingList<SolutionProject>();
                    foreach (DirectoryInfo dir in solutionFile.Directory.GetDirectories())
                    {
                        if (!dir.Name.StartsWith("."))
                        {
                            //checkedListBox1.Items.Add(dir.Name);
                            SolutionProject project = new SolutionProject();
                            project.Name = dir.Name;
                            projects.Add(project);
                        }
                    }
                    dataGridView1.DataSource = projects;
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tasks = "Clean";
            Build(tasks);
        }

        private void Build(string tasks)
        {
            bool valid = true;
            if (textBoxVisualStudioSolutionPath.Text.Length > 0)
            {
                StringBuilder buildOptions = new StringBuilder();
                FileInfo solution = new FileInfo(textBoxVisualStudioSolutionPath.Text);
                if (solution.Exists)
                {
                    buildOptions.Append(solution.FullName);
                    buildOptions.Append(string.Format(" /t:{0} ", tasks));
                    buildOptions.Append(string.Format(" /p:Configuration={0} ", comboBox1.Text));
                    Process.Start(@"C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe ", buildOptions.ToString());
                }
                else
                {
                    valid = false;
                }
            }
            else
            {
                valid = false;
            }
            if (!valid)
            {
                MessageBox.Show("Something goes wrong.", "Openning Solution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tasks = "Clean,Build";
            Build(tasks);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingList<SolutionProject> projects = (BindingList<SolutionProject>)dataGridView1.DataSource;
            FileInfo solution = new FileInfo(textBoxVisualStudioSolutionPath.Text);
            if (solution.Exists)
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    foreach (SolutionProject project in projects)
                    {
                        if (project.Start)
                        {
                            try
                            {
                                DirectoryInfo projectFolder = new DirectoryInfo(folderBrowserDialog1.SelectedPath + "\\" + project.Name + "\\");
                                if (!projectFolder.Exists)
                                {
                                    projectFolder.Create();
                                }
                                else
                                {
                                    projectFolder.Delete(true);
                                    projectFolder.Create();
                                }
                                string strCmdText;
                                strCmdText = "/C copy /b " + string.Format(@"{0}\{1}\bin\{2}\*.* {3}\ ", solution.Directory, project.Name, comboBox2.Text, projectFolder);
                                //System.Diagnostics.Process.Start("CMD.exe", strCmdText);
                                string SourcePath = string.Format(@"{0}\{1}\bin\{2}", solution.Directory, project.Name, comboBox2.Text, projectFolder);
                                string DestinationPath = string.Format(@"{3}", solution.Directory, project.Name, comboBox2.Text, projectFolder);
                                foreach (string dirPath in Directory.GetDirectories(SourcePath, "*", SearchOption.AllDirectories))
                                    Directory.CreateDirectory(dirPath.Replace(SourcePath, DestinationPath));

                                //Copy all the files & Replaces any files with the same name
                                foreach (string newPath in Directory.GetFiles(SourcePath, "*.*",
                                    SearchOption.AllDirectories))
                                    File.Copy(newPath, newPath.Replace(SourcePath, DestinationPath), true);
                            }
                            catch (Exception ex)
                            {
                            }
                        }
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            BindingList<SolutionProject> projects = (BindingList<SolutionProject>)dataGridView1.DataSource;
            FileInfo solution = new FileInfo(textBoxVisualStudioSolutionPath.Text);
            if (solution.Exists)
            {
                foreach (SolutionProject project in projects)
                {
                    if (project.Start)
                    {
                        try
                        {
                            Process.Start(string.Format(@"{0}\{1}\bin\{2}\{1}.exe", solution.Directory, project.Name, comboBox2.Text), project.Params);
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FileInfo solution = new FileInfo(textBoxVisualStudioSolutionPath.Text);
            if (solution.Exists)
            {

                Process.Start(@"explorer.exe", solution.DirectoryName);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BindingList<SolutionProject> projects = (BindingList<SolutionProject>)dataGridView1.DataSource;
            FileInfo solution = new FileInfo(textBoxVisualStudioSolutionPath.Text);
            if (solution.Exists)
            {
                foreach (SolutionProject project in projects)
                {
                    if (project.Start)
                    {
                        try
                        {
                            DirectoryInfo projectFolder = new DirectoryInfo(solution.DirectoryName + "\\" + project.Name + "\\");
                            if (projectFolder.Exists)
                            {
                                string SourcePath = string.Format(@"{0}\{1}\bin\{2}", solution.Directory, project.Name, comboBox2.Text, projectFolder);

                                Process.Start(@"explorer.exe", SourcePath);
                            }

                        }
                        catch (Exception ex)
                        {
                        }
                    }
                }
            }
        }
    }
}
