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
    /// Interaction logic for SelectableListObject.xaml
    /// </summary>
    public partial class SelectableListObject : UserControl
    {
        private static SelectedObjectView? selectedObjectViewer;

        public SelectableListObject(string name, string iconPath)
        {
            InitializeComponent();
            unitname.Text = name;
            changeIcon(iconPath);
        }


        public static void setSelectedObjectViewer(SelectedObjectView selectedObjectView)
        {
            selectedObjectViewer = selectedObjectView;
        }

        //Made with AI (Because I had a lot of problems with Loading Assets and Paths)
        public void changeIcon(string iconPath)
        {
            string fullPackUri = $"pack://application:,,,/Assets/{iconPath}";

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(fullPackUri, UriKind.Absolute);

            RenderOptions.SetBitmapScalingMode(bitmap, BitmapScalingMode.NearestNeighbor);

            bitmap.EndInit();

            icon.Source = bitmap;
        }

        private void selectObjectButton_Click(object sender, RoutedEventArgs e)
        {
            if (selectedObjectViewer == null)
            {
                throw new Exception("SelectedObjectViewer is not set. Please set it before using this method.");
            }

            selectedObjectViewer.selectObject(this);
        }
    }
}
