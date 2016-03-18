using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;
using Tornado14.Task;
using System.IO;
using Tornado14Lab.Utils.NativeTheme;
using System.Text.RegularExpressions;
using SyntaxHighlighter;

namespace Tornado14.TrayApp.Controls
{
    public partial class SpelledMultilineTextbox : UserControl
    {
        public SyntaxRichTextBox Textbox
        {
            get
            {
                return this.syntaxRichTextBox1;
            }
        }

        private List<string> projectIdList = new List<string>();
        public List<string> ProjectIdList
        {
            get
            {
                return projectIdList;
            }
            set
            {
                projectIdList = value;
            }
        }

        private List<string> sprintIdList = new List<string>();
        public List<string> SprintIdList
        {
            get
            {
                return sprintIdList;
            }
            set
            {
                sprintIdList = value;
            }
        }
        public void AddKeywords(List<string> keywords1, List<string> keywords2)
        {
            // Add the keywords to the list.
            foreach (string project in keywords1)
            {
                syntaxRichTextBox1.Settings.Keywords.Add(project);
            }
            projectIdList = syntaxRichTextBox1.Settings.Keywords;
            // Add the keywords to the list.
            foreach (string project in keywords2)
            {
                syntaxRichTextBox1.Settings.Keywords2.Add(project);
            }
            sprintIdList = syntaxRichTextBox1.Settings.Keywords2;
            syntaxRichTextBox1.CompileKeywords();
        }

        public SpelledMultilineTextbox()
        {
            InitializeComponent();




            syntaxRichTextBox1.Settings.CommentColor2 = BlackTheme.mBlueLight2;
            syntaxRichTextBox1.Settings.CommentColor = BlackTheme.mViolett2;
            syntaxRichTextBox1.Settings.KeywordColor = BlackTheme.mYellow2;
            syntaxRichTextBox1.Settings.KeywordColor2 = BlackTheme.mGreenLight2;

            // Set the comment identifier. 
            // For Lua this is two minus-signs after each other (--).
            // For C++ code we would set this property to "//".
            syntaxRichTextBox1.Settings.Comment = "--";
            syntaxRichTextBox1.Settings.Comment2 = @"\*\*";

            // Set the colors that will be used.
            syntaxRichTextBox1.Settings.StringColor = Color.Gray;
            syntaxRichTextBox1.Settings.IntegerColor = Color.Red;

            // Let's not process strings and integers.
            syntaxRichTextBox1.Settings.EnableStrings = false;
            syntaxRichTextBox1.Settings.EnableIntegers = false;
            syntaxRichTextBox1.Settings.EnableComments2 = true;

            // Let's make the settings we just set valid by compiling
            // the keywords to a regular expression.
            syntaxRichTextBox1.CompileKeywords();

            // Load a file and update the syntax highlighting.

            //syntaxRichTextBox1.LoadFile("script.txt", RichTextBoxStreamType.PlainText);
            syntaxRichTextBox1.ProcessAllLines();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Process[] proc = Process.GetProcessesByName("WINWORD");
            foreach(Process proc1 in proc) {
                proc1.Kill();
            }
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();

            int errors = 0;
            if (syntaxRichTextBox1.Text.Length > 0)
            {
                app.Visible = true;

                // Setting these variables is comparable to passing null to the function.
                // This is necessary because the C# null cannot be passed by reference.
                object template = Missing.Value;
                object newTemplate = Missing.Value;
                object documentType = Missing.Value;
                object visible = true;

                Microsoft.Office.Interop.Word._Document doc1 = app.Documents.Add(ref template, ref newTemplate, ref documentType, ref visible);
                doc1.Words.First.InsertBefore(syntaxRichTextBox1.Text);
                Microsoft.Office.Interop.Word.ProofreadingErrors spellErrorsColl = doc1.SpellingErrors;
                errors = spellErrorsColl.Count;

                object optional = Missing.Value;

                doc1.CheckSpelling(
                    ref optional, ref optional, ref optional, ref optional, ref optional, ref optional,
                    ref optional, ref optional, ref optional, ref optional, ref optional, ref optional);

                toolStripLabelStatus.Text = errors + " errors corrected ";
                object first = 0;
                object last = doc1.Characters.Count - 1;
                syntaxRichTextBox1.Text = doc1.Range(ref first, ref last).Text.Replace("\r", "\r\n");
                //doc1.Close(ref optional, ref optional, ref optional);
                //doc1 = null;
            }

            object saveChanges = false;
            object originalFormat = Missing.Value;
            object routeDocument = Missing.Value;

            app.Quit(ref saveChanges, ref originalFormat, ref routeDocument);
            //app.Quit();
            app = null;

            //app.Quit(ref originalFormat, ref originalFormat, ref originalFormat);
            Process[] proc3 = Process.GetProcessesByName("WINWORD");
            foreach (Process proc4 in proc3)
            {
                proc4.Kill();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(syntaxRichTextBox1.Text);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            toolStripLabelStatus.Text = "Not checked";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            BrowserTest b = new BrowserTest();
            b.Show();
        }


        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void syntaxRichTextBox1_DoubleClick(object sender, EventArgs e)
        {
            Textbox.ProcessAllLines();
        }
    }
}
