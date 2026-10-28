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

namespace WpfDispatcherSimulationApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            IncidentList.addNewObject("Incident 1", "fire_icon.png", objectView);
            IncidentList.addNewObject("Incident 2", "fire_icon.png", objectView);
            IncidentList.addNewObject("Incident 3", "fire_icon.png", objectView);
            IncidentList.addNewObject("Incident 4", "fire_icon.png", objectView);

            StationList.addNewObject("Fire Station 1", "fire_station.png", objectView);
            StationList.addNewObject("Fire Station 2", "fire_station.png", objectView);
            StationList.addNewObject("Hospital 1", "hospital.png", objectView);

            UnitList.addNewObject("FireTruck 1", "fire_truck_16x16.png", objectView);
            UnitList.addNewObject("FireTruck 2", "fire_truck_16x16.png", objectView);
            UnitList.addNewObject("FireTruck 3", "fire_truck_16x16.png", objectView);
            UnitList.addNewObject("FireTruck 4", "fire_truck_16x16.png", objectView);
            UnitList.addNewObject("FireTruck 5", "fire_truck_16x16.png", objectView);
            UnitList.addNewObject("FireTruck 6", "fire_truck_16x16.png", objectView);
            UnitList.addNewObject("Ambulance 1", "ambulance.png", objectView);
            UnitList.addNewObject("Ambulance 2", "ambulance.png", objectView);
            UnitList.addNewObject("Ambulance 3", "ambulance.png", objectView);

        }

        private void ScaleMap_Click(object sender, RoutedEventArgs e)
        {

            mapDisplay.ScaleMap();
        }
    }
}