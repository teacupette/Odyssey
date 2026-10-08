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
        public SelectableListObject(string name, string iconPath)
        {
            InitializeComponent();
            
            unitname.Text = name;
            changeIcon(iconPath);
        }




        //AI
        public void changeIcon(string iconPath)
        {
            // Wir bauen den Pfad so um, dass er absolut aus der Anwendung geladen wird
            string fullPackUri = $"pack://application:,,,/Assets/{iconPath}";

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(fullPackUri, UriKind.Absolute);

            // Für Pixel-Art: Verhindert Unschärfe beim Skalieren
            RenderOptions.SetBitmapScalingMode(bitmap, BitmapScalingMode.NearestNeighbor);

            bitmap.EndInit();

            icon.Source = bitmap;
        }

    }
}
