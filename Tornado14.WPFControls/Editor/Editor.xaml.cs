using AvalonEdit.Sample;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.CodeCompletion;
using ICSharpCode.AvalonEdit.Folding;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Rendering;
using ICSharpCode.AvalonEdit.Sample;
using SpellCheckAvalonEdit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Xml;

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


        public event PropertyChangedEventHandler PropertyChanged;
        void SetValueDp(DependencyProperty property, object value, [System.Runtime.CompilerServices.CallerMemberName] string p = null)
        {
            SetValue(property, value);
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(p));
            }
        }
        public TEditor()
        {
            InitializeComponent();
            (this.Content as FrameworkElement).DataContext = this;
            spellingErrorColorizer = new SpellingErrorColorizer();
            //textEditor.TextArea.TextView.LineTransformers.Add(spellingErrorColorizer);
            textEditor.TextArea.LostFocus += TextArea_LostFocus;


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
        public event EventHandler TextChanged;
        private void TextArea_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TextChanged != null)
            {
                TextChanged.Invoke(this, new EventArgs());
            }
        }


        CompletionWindow completionWindow;


        private void textEditor_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private List<MyCompletionData> CompletionData = new List<MyCompletionData>();

        public void FillCompletionData(Dictionary<string, string> completionData)
        {
            foreach (KeyValuePair<string, string> completionItem in completionData)
            {
                CompletionData.Add(new MyCompletionData(completionItem.Key, completionItem.Value));
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

        private void tbrClear__Click(object sender, RoutedEventArgs e)
        {
            spellingErrorColorizer.SetLanguage("en-EN");
            string temp = textEditor.Text;
            textEditor.Text = "";
            textEditor.Text = temp + " ";
        }


    }
}
