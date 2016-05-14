using HtmlAgilityPack;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.CodeCompletion;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Folding;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Sample;
using SpellCheckAvalonEdit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using System.Xml;
using System.Xml.Linq;

namespace Tornado14.WPFControls
{
    /// <summary>
    /// Interaction logic for Editor.xaml
    /// </summary>
    public partial class TEditor : UserControl
    {
        SpellingErrorColorizer spellingErrorColorizer;

        public static readonly DependencyProperty Text2Property = DependencyProperty.Register("Text2", typeof(string), typeof(TEditor), null);
        public string Text2
        {
            get
            {
                return (string)GetValue(Text2Property);
            }
            set
            {
                SetValueDp(Text2Property, value);
            }
        }


        public static readonly DependencyProperty HeaderTextProperty = DependencyProperty.Register("HeaderText", typeof(string), typeof(TEditor), null);
        public string HeaderText
        {
            get
            {
                return (string)GetValue(HeaderTextProperty);
            }
            set
            {
                SetValueDp(HeaderTextProperty, value);
            }
        }

        public TextEditor TextEditor
        {
            get
            {
                return this.textEditor;
            }
        }

        public string SelectedText
        {
            get
            {
                return this.textEditor.SelectedText;
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public class TextChangedEventArgs : EventArgs
        {
            public TextChangedEventArgs(string text)
            {
                this.NewText = text;
            }

            public string NewText { get; private set; }
        }

        void SetValueDp(DependencyProperty property, object value, [System.Runtime.CompilerServices.CallerMemberName] string p = null)
        {
            SetValue(property, value);
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(p));
            }
        }

        private void setTestText()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine("//// T14P-2 T14S-4");
            text.AppendLine("Dropdown mit Suggestion für Additional Attributen {");
            text.AppendLine("Ist Zustand:");
            text.AppendLine("Momentan sind Normale Textboxen ");
            text.AppendLine("-----");
            text.AppendLine("Soll Zustand:");
            text.AppendLine("Dropdrown mit Suggestion, die werte sind alle bischer eingegebenen Atributt");
            text.AppendLine("-----");
            text.AppendLine("Recherche:");
            text.AppendLine("http://stackoverflow.com/questions/3177717/combobox-in-windows-forms-datagridview-control");
            text.AppendLine("http://stackoverflow.com/questions/1089889/how-do-i-set-up-a-datagridview-comboboxcolumn-with-a-different-datasource-in-eac");
            text.AppendLine("http://stackoverflow.com/questions/19042962/drop-down-combobox-inside-datagridview");
            text.AppendLine("http://stackoverflow.com/questions/21323917/c-sharp-replace-default-textbox-in-datagridview-with-a-combobox");
            text.AppendLine("http://www.intertech.com/Blog/winforms-multi-column-combo-box-in-a-datagridview/");
            text.AppendLine("http://csharp.net-informations.coma/datagridview/csharp-datagridview-combobox.htm");
            text.AppendLine("http://mycsharp.de/wbb2/thread.php%3Fpostid%3D3652075");
            text.AppendLine("search word: \"winforms datagridview dropdown in cell\"");
            text.AppendLine("-----");
            text.AppendLine("Resultat: ");
            text.AppendLine("Noch nicht Fertig");
            text.AppendLine("}");
            text.AppendLine("");

            text.AppendLine("//// T14P-2 T14S-4");
            text.AppendLine("Dropdown mit Suggestion für Additional Attributen {");
            text.AppendLine("Ist:");
            text.AppendLine("Momentan sind Normale Textboxen");
            text.AppendLine("-----");
            text.AppendLine("Soll:");
            text.AppendLine("Dropdrown mit Suggestion, die werte sind alle bischer eingegebenen Atributt");
            text.AppendLine("-----");
            text.AppendLine("Recherche:");
            text.AppendLine("http://stackoverflow.com/questions/3177717/combobox-in-windows-forms-datagridview-control");
            text.AppendLine("http://stackoverflow.com/questions/1089889/how-do-i-set-up-a-datagridview-comboboxcolumn-with-a-different-datasource-in-eac");
            text.AppendLine("http://stackoverflow.com/questions/19042962/drop-down-combobox-inside-datagridview");
            text.AppendLine("http://stackoverflow.com/questions/21323917/c-sharp-replace-default-textbox-in-datagridview-with-a-combobox");
            text.AppendLine("http://www.intertech.com/Blog/winforms-multi-column-combo-box-in-a-datagridview/");
            text.AppendLine("http://csharp.net-informations.com/datagridview/csharp-datagridview-combobox.htm");
            text.AppendLine("http://mycsharp.de/wbb2/thread.php%3Fpostid%3D3652075");
            text.AppendLine("search word: \"winforms datagridview dropdown in cell\"");
            text.AppendLine("-----");
            text.AppendLine("Resultat: ");
            text.AppendLine("Noch nicht Fertig");
            text.AppendLine("}");

            text.AppendLine("//// T14P-2 T14S-4");
            text.AppendLine("test 1 {");
            text.AppendLine("Ist:");
            text.AppendLine("ist Text");
            text.AppendLine("-----");
            text.AppendLine("Soll:");
            text.AppendLine("soll Text");
            text.AppendLine("-----");
            text.AppendLine("Recherche:");
            text.AppendLine("Recherche Text");
            text.AppendLine("-----");
            text.AppendLine("Resultat: ");
            text.AppendLine("resultat Text");
            text.AppendLine("}");

            text.AppendLine("//// T14P-2 T14S-4");
            text.AppendLine("test 2 {");
            text.AppendLine("Ist:");
            text.AppendLine("ist Text");
            text.AppendLine("-----");
            text.AppendLine("Soll:");
            text.AppendLine("soll Text");
            text.AppendLine("-----");
            text.AppendLine("Recherche:");
            text.AppendLine("Recherche Text");
            text.AppendLine("}");

            text.AppendLine("//// T14P-2 T14S-0");
            text.AppendLine("test 3 {");
            text.AppendLine("Ist:");
            text.AppendLine("ist Text");
            text.AppendLine("-----");
            text.AppendLine("Soll:");
            text.AppendLine("soll Text");
            text.AppendLine("}");

            text.AppendLine("//// T14P-2 T14S-1");
            text.AppendLine("test 4 {");
            text.AppendLine("Ist:");
            text.AppendLine("ist Text");
            text.AppendLine("}");

            text.AppendLine("//// T14P-2 T14S-2");
            text.AppendLine("test 5 {");
            text.AppendLine("Ist:");
            text.AppendLine("ist Text");
            text.AppendLine("-----");
            text.AppendLine("}");

            text.AppendLine("//// T14P-2 T14S-3");
            text.AppendLine("test 6 {");
            text.AppendLine("asdasd 1");
            text.AppendLine("asdasd 2");
            text.AppendLine("asdasd 3");
            text.AppendLine("}");

            text.AppendLine("//// T14P-2 T14S-4");
            text.AppendLine("test 7 {");
            text.AppendLine("}");

            text.AppendLine("//// T14P-2 T14S-0");
            text.AppendLine("test 8 {");
            text.AppendLine("Soll:");
            text.AppendLine("soll Text");
            text.AppendLine("}");

            text.AppendLine("//// T14P-2 T14S-0");
            text.AppendLine("test 8 {");
            text.AppendLine("Soll:");
            text.AppendLine("soll Text");
            text.AppendLine("-----");
            text.AppendLine("}");
            Text2 = text.ToString();
        }

        public TEditor()
        {
            InitializeComponent();
            (this.Content as FrameworkElement).DataContext = this;
            spellingErrorColorizer = new SpellingErrorColorizer();
            //textEditor.TextArea.TextView.LineTransformers.Add(spellingErrorColorizer);
            textEditor.TextArea.LostFocus += TextArea_LostFocus;
            var converter = new System.Windows.Media.BrushConverter();
            textEditor.TextArea.TextView.LinkTextForegroundBrush = (Brush)converter.ConvertFromString("#007acc");

            //setTestText();
            // Load our custom highlighting definition
            IHighlightingDefinition customHighlighting = null;
            try
            {
                using (XmlReader reader = new XmlTextReader("CustomHighlighting.xshd"))
                {
                    customHighlighting = ICSharpCode.AvalonEdit.Highlighting.Xshd.
                        HighlightingLoader.Load(reader, HighlightingManager.Instance);

                }
                HighlightingManager.Instance.RegisterHighlighting("Custom Highlighting", new string[] { ".cool" }, customHighlighting);
            }
            catch (Exception ex)
            {

            }



#if DOTNET4
			this.SetValue(TextOptions.TextFormattingModeProperty, TextFormattingMode.Display);
#endif

            //textEditor.SyntaxHighlighting = HighlightingManager.Instance.GetDefinition("C#");
            textEditor.SyntaxHighlighting = customHighlighting;
            // initial highlighting now set by XAML

            textEditor.TextArea.TextEntering += textEditor_TextArea_TextEntering;
            textEditor.TextArea.TextEntered += textEditor_TextArea_TextEntered;
            textEditor.TextArea.PreviewKeyDown += TextArea_PreviewKeyDown;

            DispatcherTimer foldingUpdateTimer = new DispatcherTimer();
            foldingUpdateTimer.Interval = TimeSpan.FromSeconds(1);
            foldingUpdateTimer.Tick += delegate { UpdateFoldings(); };
            foldingUpdateTimer.Start();


            if (textEditor.SyntaxHighlighting == null)
            {
                foldingStrategy = null;
            }
            else
            {
                textEditor.Options.HighlightCurrentLine = true;
                //textEditor.Options.ShowColumnRuler = true;
                //textEditor.Options.ShowTabs = true;
                textEditor.Options.EnableEmailHyperlinks = true;
                textEditor.Options.EnableHyperlinks = true;
                textEditor.Options.EnableTextDragDrop = true;
                textEditor.Options.ShowBoxForControlCharacters = true;
                //textEditor.Options.ShowEndOfLine = true;
                //textEditor.Options.ShowSpaces = true;
                //textEditor.TextArea.IndentationStrategy = new ICSharpCode.AvalonEdit.Indentation.CSharp.CSharpIndentationStrategy(textEditor.Options);
                textEditor.TextArea.IndentationStrategy = new ICSharpCode.AvalonEdit.Indentation.DefaultIndentationStrategy();
                foldingStrategy = new BraceFoldingStrategy();
            }
            if (foldingStrategy != null)
            {
                if (foldingManager == null)
                    foldingManager = FoldingManager.Install(textEditor.TextArea);
                UpdateFoldings();
            }
            else
            {
                if (foldingManager != null)
                {
                    FoldingManager.Uninstall(foldingManager);
                    foldingManager = null;
                }
            }
        }

        private void TextArea_PreviewKeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.F1)
            {
                string selectedText = textEditor.SelectedText;

                StringBuilder sb = new StringBuilder();
                byte[] ResultsBuffer = new byte[8192];
                string SearchResults = "http://google.com/search?q=" + selectedText;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(SearchResults);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                Stream resStream = response.GetResponseStream();
                string tempString = null;
                int count = 0;
                do
                {
                    count = resStream.Read(ResultsBuffer, 0, ResultsBuffer.Length);
                    if (count != 0)
                    {
                        tempString = Encoding.ASCII.GetString(ResultsBuffer, 0, count);
                        sb.Append(tempString);
                    }
                }

                while (count > 0);
                string sbb = sb.ToString();

                HtmlAgilityPack.HtmlDocument html = new HtmlAgilityPack.HtmlDocument();
                html.OptionOutputAsXml = true;
                html.LoadHtml(sbb);
                HtmlNode doc = html.DocumentNode;
                StringBuilder results = new StringBuilder();
                foreach (HtmlNode link in doc.SelectNodes("//a[@href]"))
                {
                    //HtmlAttribute att = link.Attributes["href"];
                    string hrefValue = link.GetAttributeValue("href", string.Empty);
                    if (!hrefValue.ToString().ToUpper().Contains("GOOGLE") && hrefValue.ToString().Contains("/url?q=") && hrefValue.ToString().ToUpper().Contains("HTTP://"))
                    {
                        int index = hrefValue.IndexOf("&");
                        if (index > 0)
                        {
                            hrefValue = hrefValue.Substring(0, index);
                            results.AppendLine(hrefValue.Replace("/url?q=", ""));
                        }
                    }
                }

                textEditor.Document.Insert(textEditor.SelectionStart, results.ToString());
            }

            if (e.Key == Key.F2)
            {
                string selectedText = textEditor.SelectedText;
                selectedText = selectedText.Replace(System.Environment.NewLine, string.Empty);
                selectedText = Uri.EscapeDataString(selectedText.Trim());
                selectedText = RemoveLineEndings(selectedText);


                Uri target = new Uri(string.Format(@"http://google.com/complete/search?output=toolbar&q={0}", selectedText));
                WebRequest httpWebRequest = HttpWebRequest.Create(target);
                var webResponse = httpWebRequest.GetResponse();
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.XmlResolver = null;
                StreamReader reader = new StreamReader(webResponse.GetResponseStream(), true);
                string result2 = reader.ReadToEnd();
                xmlDoc.LoadXml(result2);
                XmlNodeList result = xmlDoc.SelectNodes("//CompleteSuggestion");
                StringBuilder s = new StringBuilder();
                foreach (XmlNode b in result)
                {
                    s.AppendLine(b.FirstChild.Attributes["data"].Value);
                }
                textEditor.Document.Insert(textEditor.SelectionStart, s.ToString());
            }
        }

        private string RemoveLineEndings(string value)
        {
            if (String.IsNullOrEmpty(value))
            {
                return value;
            }
            string lineSeparator = ((char)0x2028).ToString();
            string paragraphSeparator = ((char)0x2029).ToString();

            return value.Replace("\r\n", string.Empty).Replace("\n", string.Empty).Replace("\r", string.Empty).Replace(lineSeparator, string.Empty).Replace(paragraphSeparator, string.Empty);
        }


        public event EventHandler TextChanged;
        private void TextArea_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TextChanged != null)
            {
                TextChanged.Invoke(this, new TextChangedEventArgs(this.textEditor.Text));
            }
        }


        CompletionWindow completionWindow;


        private void textEditor_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private List<MyCompletionData> CompletionData = new List<MyCompletionData>();

        public void FillCompletionData(Dictionary<string, List<string>> completionData)
        {
            foreach (KeyValuePair<string, List<string>> completionItem in completionData)
            {
                CompletionData.Add(new MyCompletionData(completionItem.Key, completionItem.Value[0], completionItem.Value[1]));
            }
        }

        void textEditor_TextArea_TextEntered(object sender, TextCompositionEventArgs e)
        {

            if (((KeyboardDevice)e.Device).Modifiers == ModifierKeys.Control)
            {
                if (e.Text == " ")
                {
                    // open code completion after the user has pressed dot:
                    completionWindow = new CompletionWindow(textEditor.TextArea);
                    completionWindow.Background = new SolidColorBrush(Color.FromRgb(40, 40, 40));
                    completionWindow.Foreground = new SolidColorBrush(Color.FromRgb(225, 225, 225));
                    completionWindow.BorderBrush = new SolidColorBrush(Color.FromRgb(225, 225, 225));
                    completionWindow.Width = 400;
                    // provide AvalonEdit with the data:
                    IList<ICompletionData> data = completionWindow.CompletionList.CompletionData;
                    foreach (MyCompletionData competitionData in CompletionData)
                    {
                        data.Add(competitionData);
                    }
                    completionWindow.Closed += delegate
                    {
                        completionWindow = null;
                    };
                    completionWindow.Show();
                }

                if (e.Text == "1")
                {
                    // open code completion after the user has pressed dot:
                    completionWindow = new CompletionWindow(textEditor.TextArea);
                    completionWindow.Background = new SolidColorBrush(Color.FromRgb(40, 40, 40));
                    completionWindow.Foreground = new SolidColorBrush(Color.FromRgb(225, 225, 225));
                    completionWindow.BorderBrush = new SolidColorBrush(Color.FromRgb(225, 225, 225));
                    completionWindow.Width = 400;
                    // provide AvalonEdit with the data:
                    IList<ICompletionData> data = completionWindow.CompletionList.CompletionData;
                    foreach (MyCompletionData competitionData in CompletionData)
                    {
                        data.Add(competitionData);
                    }
                    completionWindow.Closed += delegate
                    {
                        completionWindow = null;
                    };
                    completionWindow.Show();
                }

            }
        }

        void textEditor_TextArea_TextEntering(object sender, TextCompositionEventArgs e)
        {
            if (e.Text.Length > 0 && completionWindow != null)
            {
                if (!char.IsLetterOrDigit(e.Text[0]))
                {
                    completionWindow.CompletionList.RequestInsertion(e);
                }
            }
        }

        #region Folding
        FoldingManager foldingManager;
        object foldingStrategy;

        void HighlightingComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (textEditor.SyntaxHighlighting == null)
            {
                foldingStrategy = null;
            }
            else
            {
                switch (textEditor.SyntaxHighlighting.Name)
                {
                    case "XML":
                        foldingStrategy = new XmlFoldingStrategy();
                        textEditor.TextArea.IndentationStrategy = new ICSharpCode.AvalonEdit.Indentation.DefaultIndentationStrategy();
                        break;
                    case "C#":
                    case "C++":
                    case "PHP":
                    case "Java":
                        textEditor.TextArea.IndentationStrategy = new ICSharpCode.AvalonEdit.Indentation.CSharp.CSharpIndentationStrategy(textEditor.Options);
                        foldingStrategy = new BraceFoldingStrategy();
                        break;
                    default:
                        textEditor.TextArea.IndentationStrategy = new ICSharpCode.AvalonEdit.Indentation.DefaultIndentationStrategy();
                        foldingStrategy = null;
                        break;
                }
            }
            if (foldingStrategy != null)
            {
                if (foldingManager == null)
                    foldingManager = FoldingManager.Install(textEditor.TextArea);
                UpdateFoldings();
            }
            else
            {
                if (foldingManager != null)
                {
                    FoldingManager.Uninstall(foldingManager);
                    foldingManager = null;
                }
            }
        }

        void UpdateFoldings()
        {
            if (foldingStrategy is BraceFoldingStrategy)
            {
                ((BraceFoldingStrategy)foldingStrategy).UpdateFoldings(foldingManager, textEditor.Document);
            }
            if (foldingStrategy is XmlFoldingStrategy)
            {
                ((XmlFoldingStrategy)foldingStrategy).UpdateFoldings(foldingManager, textEditor.Document);
            }
        }
        #endregion

        private void ToolBar_Loaded(object sender, RoutedEventArgs e)
        {
            ToolBar toolBar = sender as ToolBar;
            var overflowGrid = toolBar.Template.FindName("OverflowGrid", toolBar) as FrameworkElement;
            if (overflowGrid != null)
            {
                overflowGrid.Visibility = Visibility.Collapsed;
            }

            var mainPanelBorder = toolBar.Template.FindName("MainPanelBorder", toolBar) as FrameworkElement;
            if (mainPanelBorder != null)
            {
                mainPanelBorder.Margin = new Thickness(0);
            }
        }

        private void tbrClear_Click(object sender, RoutedEventArgs e)
        {
            spellingErrorColorizer.SetLanguage("de-DE");
            string temp = textEditor.Text;
            textEditor.Text = "";
            textEditor.Text = temp + " ";
        }
        private void tbrSpellOff__Click(object sender, RoutedEventArgs e)
        {

        }

        private void tbrClear__Click(object sender, RoutedEventArgs e)
        {
            spellingErrorColorizer.SetLanguage("en-EN");
            string temp = textEditor.Text;
            textEditor.Text = "";
            textEditor.Text = temp + " ";
        }

        private void tbrSpell__ClickOff(object sender, RoutedEventArgs e)
        {
            textEditor.TextArea.TextView.LineTransformers.Remove(spellingErrorColorizer);
            string temp = textEditor.Text;
            textEditor.Text = "";
            textEditor.Text = temp + " ";
        }

        private void tbrMail__Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Outlook.Application oApp = new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook._MailItem oMailItem = (Microsoft.Office.Interop.Outlook._MailItem)oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
            oMailItem.Body = Text2;
            oMailItem.Display(true);
        }

        private void tbrWord__ClickOff(object sender, RoutedEventArgs e)
        {
            Process[] proc = Process.GetProcessesByName("WINWORD");
            foreach (Process proc1 in proc)
            {
                proc1.Kill();
            }
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();

            int errors = 0;
            if (Text2.Length > 0)
            {
                app.Visible = true;

                // Setting these variables is comparable to passing null to the function.
                // This is necessary because the C# null cannot be passed by reference.
                object template = Missing.Value;
                object newTemplate = Missing.Value;
                object documentType = Missing.Value;
                object visible = true;

                Microsoft.Office.Interop.Word._Document doc1 = app.Documents.Add(ref template, ref newTemplate, ref documentType, ref visible);
                doc1.Words.First.InsertBefore(Text2);
                Microsoft.Office.Interop.Word.ProofreadingErrors spellErrorsColl = doc1.SpellingErrors;
                errors = spellErrorsColl.Count;

                object optional = Missing.Value;

                doc1.CheckSpelling(
                    ref optional, ref optional, ref optional, ref optional, ref optional, ref optional,
                    ref optional, ref optional, ref optional, ref optional, ref optional, ref optional);

                //toolStripLabelStatus.Text = errors + " errors corrected ";
                object first = 0;
                object last = doc1.Characters.Count - 1;
                Text2 = doc1.Range(ref first, ref last).Text.Replace("\r", "\r\n");
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
        public event EventHandler HeaderClicked;

        private void tbrSpell__Click(object sender, RoutedEventArgs e)
        {
            textEditor.TextArea.TextView.LineTransformers.Add(spellingErrorColorizer);
            string temp = textEditor.Text;
            textEditor.Text = "";
            textEditor.Text = temp + " ";
        }
        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            HeaderClicked.Invoke(this, new EventArgs());
        }
    }
}
