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

namespace WpfDispatcherSimulationApp.View
{
    /// <summary>
    /// Interaction logic for StartScreen.xaml
    /// </summary>
    public partial class StartScreen : UserControl
    {
        public StartScreen()
        {
            InitializeComponent();
        }
        public event RoutedEventHandler? StartPressed;

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            StartPressed?.Invoke(this, new RoutedEventArgs());
        }
    }
}
