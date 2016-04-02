using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;
using ICSharpCode.AvalonEdit;

namespace SpellCheckAvalonEdit
{
    internal class SpellCheckBehavior : Behavior<TextEditor>
    {
        private TextBox textBox;
        private TextEditor textEditor;

        protected override void OnAttached()
        {
            textEditor = AssociatedObject;
            if (textEditor != null)
            {
                textBox = new TextBox();
                textEditor.ContextMenuOpening += textEditor_ContextMenuOpening;
            }
            base.OnAttached();
        }

        private void textEditor_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            TextViewPosition? pos = textEditor.TextArea.TextView.GetPosition(new Point(e.CursorLeft, e.CursorTop));

            if (pos != null)
            {
                //Reset the context menu
                textEditor.ContextMenu = null;

                //Get the new caret position
                int newCaret = textEditor.Document.GetOffset(pos.Value.Line, pos.Value.Column);
                
                //Text box properties
                textBox.AcceptsReturn = true;
                textBox.AcceptsTab = true;
                textBox.SpellCheck.IsEnabled = true;
                textBox.Text = textEditor.Text;

                //Check for spelling errors
                SpellingError error = textBox.GetSpellingError(newCaret);

                //If there is a spelling mistake
                if (error != null)
                {
                    textEditor.ContextMenu = new ContextMenu();
                    int wordStartOffset = textBox.GetSpellingErrorStart(newCaret);
                    int wordLength = textBox.GetSpellingErrorLength(wordStartOffset);
                    foreach (string err in error.Suggestions)
                    {
                        var item = new MenuItem {Header = err, FontWeight = FontWeights.Bold};
                        var t = new Tuple<int, int>(wordStartOffset, wordLength);
                        item.Tag = t;
                        item.Click += item_Click;
                        textEditor.ContextMenu.Items.Add(item);
                    }
                }
            }
        }

        //Click event of the context menu
        private void item_Click(object sender, RoutedEventArgs e)
        {
            var item = sender as MenuItem;
            if (item != null)
            {
                var seg = item.Tag as Tuple<int, int>;
                textEditor.Document.Replace(seg.Item1, seg.Item2, item.Header.ToString());
            }
        }
    }
}