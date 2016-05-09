using System;
using System.Collections;
using System.Collections.Generic;
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

namespace Tornado14.TrayApp.Controls
{
  /// <summary>
  /// Interaction logic for WPFStarterComboBox.xaml
  /// </summary>
  public partial class WPFStarterComboBox : UserControl
  {
    public WPFStarterComboBox()
    {
      InitializeComponent();
      //Init();
    }

    public delegate void ItemSelectedEventHandler(object selectedObject);
    public event ItemSelectedEventHandler SelectionChanged;

    public void Init(IEnumerable suggestionItems)
    {
      filteredComboBox.IsEditable = true;
      filteredComboBox.IsTextSearchEnabled = false;
      //filteredComboBox.ItemsSource = typeof(Colors).GetProperties();
      filteredComboBox.ItemsSource = suggestionItems;
    }

    private void filteredComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      if (e.AddedItems.Count > 0)
      {
        //SelectionChanged.Invoke(e.AddedItems[0]);
      }
    }

    private void filteredComboBox_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.Key == Key.Enter && filteredComboBox.SelectedItem != null)
      {
        SelectionChanged.Invoke(filteredComboBox.SelectedItem);
      }
    }
  }
}
