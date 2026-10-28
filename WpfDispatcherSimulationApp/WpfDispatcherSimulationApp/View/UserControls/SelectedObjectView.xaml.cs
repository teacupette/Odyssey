using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDispatcherSimulationApp.View.UserControls
{
    /// <summary>
    /// Interaction logic for SelectedObjectView.xaml
    /// </summary>
    public partial class SelectedObjectView : UserControl
    {
        public SelectedObjectView()
        {
            InitializeComponent();
        }

        public void selectObject(SelectableListObject currentSelectedObject)
        {
            nonselected_Text.Visibility = Visibility.Hidden;

            icon.Source = currentSelectedObject.icon.Source;
            objectName.Text = currentSelectedObject.unitname.Text;
        }
    }
}
