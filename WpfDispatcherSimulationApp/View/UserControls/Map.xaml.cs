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
    
    public partial class Map : UserControl
    {
        private bool isScaled = false; 

        public Map()
        {
            InitializeComponent();
            for (int i = 0; i < 32; i++)
            {
                for (int j = 0; j < 32; j++)
                {
                    Image tileImage = new Image
                    {
                        Source = new BitmapImage(new Uri("pack://application:,,,/Assets/grass_tile.png")),
                        Width = 16,
                        Height = 16
                    };
                    RenderOptions.SetBitmapScalingMode(tileImage, BitmapScalingMode.NearestNeighbor);
                    Canvas.SetLeft(tileImage, j * 16);
                    Canvas.SetTop(tileImage, i * 16);
                    mapCanvas.Children.Add(tileImage);
                }
            }
            Image fireTruck = new Image
            {
                Source = new BitmapImage(new Uri("pack://application:,,,/Assets/fire_truck_16x16.png")),
                Width = 16,
                Height = 16
            };

            Canvas.SetLeft(fireTruck, 50);
            Canvas.SetTop(fireTruck, 100);


            mapCanvas.Children.Add(fireTruck);


            

            Canvas.SetLeft(fireTruck, 32); 
            Canvas.SetTop(fireTruck, 32);  

            //mapCanvas.Children.Remove(fireTruck); 

        }

        public void ScaleMap()
        {
            if (!isScaled)
            {
                foreach (Image item in mapCanvas.Children)
                {
                    Canvas.SetLeft(item, Canvas.GetLeft(item) * 2);
                    Canvas.SetTop(item, Canvas.GetTop(item) * 2);
                    item.Width = 32;
                    item.Height = 32;
                }
                isScaled = true;
            }
            else
            {
                foreach (Image item in mapCanvas.Children)
                {
                    Canvas.SetLeft(item, Canvas.GetLeft(item) / 2);
                    Canvas.SetTop(item, Canvas.GetTop(item) / 2);
                    item.Width = 16;
                    item.Height = 16;
                }
                isScaled = false;
            }
        }
    }
}
