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
            textEditor.TextArea.TextView.LineTransformers.Add(spellingErrorColorizer);


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
            textEditor.TextArea.KeyDown += TextArea_KeyDown;

            DispatcherTimer foldingUpdateTimer = new DispatcherTimer();
            foldingUpdateTimer.Interval = TimeSpan.FromSeconds(2);
            foldingUpdateTimer.Tick += delegate { UpdateFoldings(); };
            foldingUpdateTimer.Start();


            if (textEditor.SyntaxHighlighting == null)
            {
                foldingStrategy = null;
            }
            else
            {
                //textEditor.TextArea.IndentationStrategy = new ICSharpCode.AvalonEdit.Indentation.CSharp.CSharpIndentationStrategy(textEditor.Options);
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

        private void TextArea_KeyDown(object sender, KeyEventArgs e)
        {
            Key key = (e.Key == Key.System ? e.SystemKey : e.Key);
            if (e.Key == Key.Space && e.KeyboardDevice.Modifiers == ModifierKeys.Control)
            {
                // open code completion after the user has pressed dot:
                completionWindow = new CompletionWindow(textEditor.TextArea);
                // provide AvalonEdit with the data:
                IList<ICompletionData> data = completionWindow.CompletionList.CompletionData;
                data.Add(new MyCompletionData("Item1"));
                data.Add(new MyCompletionData("Item2"));
                data.Add(new MyCompletionData("Item3"));
                data.Add(new MyCompletionData("Another item"));
                completionWindow.Show();
                completionWindow.Closed += delegate
                {
                    //completionWindow = null;
                };
            }
        }

        CompletionWindow completionWindow;

        void textEditor_TextArea_TextEntered(object sender, TextCompositionEventArgs e)
        {
            if (e.Text == ".")
            {
                // open code completion after the user has pressed dot:
                completionWindow = new CompletionWindow(textEditor.TextArea);
                // provide AvalonEdit with the data:
                IList<ICompletionData> data = completionWindow.CompletionList.CompletionData;
                data.Add(new MyCompletionData("Item1"));
                data.Add(new MyCompletionData("Item2"));
                data.Add(new MyCompletionData("Item3"));
                data.Add(new MyCompletionData("Another item"));
                completionWindow.Show();
                completionWindow.Closed += delegate
                {
                    completionWindow = null;
                };
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

        private void textEditor_KeyDown(object sender, KeyEventArgs e)
        {
            Key key = (e.Key == Key.System ? e.SystemKey : e.Key);
            if (key == Key.Space)
            {
                if (e.KeyboardDevice.Modifiers == ModifierKeys.Control)
                {
                    // open code completion after the user has pressed dot:
                    completionWindow = new CompletionWindow(textEditor.TextArea);
                    // provide AvalonEdit with the data:
                    IList<ICompletionData> data = completionWindow.CompletionList.CompletionData;
                    data.Add(new MyCompletionData("Item1"));
                    data.Add(new MyCompletionData("Item2"));
                    data.Add(new MyCompletionData("Item3"));
                    data.Add(new MyCompletionData("Another item"));
                    completionWindow.Show();
                    completionWindow.Closed += delegate
                    {
                        completionWindow = null;
                    };
                }
            }

        }
    }
}
