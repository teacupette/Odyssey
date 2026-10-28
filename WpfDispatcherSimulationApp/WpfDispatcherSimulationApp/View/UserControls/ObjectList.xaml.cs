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
    /// Interaction logic for ObjectList.xaml
    /// </summary>
    public partial class ObjectList : UserControl
    {
        public ObjectList()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public String ObjectListHedder { get; set; }


        public void addNewObject(string newUnitName, string iconPath)
        {
            StackPanel123.Children.Add(new SelectableListObject(newUnitName, iconPath));
        }
    }
}
