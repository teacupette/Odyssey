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
using WpfDispatcherSimulationApp.View.UserControls;

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

            SelectableListObject.setSelectedObjectViewer(objectView);

            IncidentList.addNewObject(new SelectableListObject("Incident 1", "fire_icon.png"));
            IncidentList.addNewObject(new SelectableListObject("Incident 2", "fire_icon.png"));
            IncidentList.addNewObject(new SelectableListObject("Incident 3", "fire_icon.png"));
            IncidentList.addNewObject(new SelectableListObject("Incident 4", "fire_icon.png"));

            StationList.addNewObject(new SelectableListObject("Fire Station 1", "fire_station.png"));
            StationList.addNewObject(new SelectableListObject("Fire Station 2", "fire_station.png"));
            StationList.addNewObject(new SelectableListObject("Hospital 1", "hospital.png"));

            UnitList.addNewObject(new SelectableListObject("FireTruck 1", "fire_truck_16x16.png"));
            UnitList.addNewObject(new SelectableListObject("FireTruck 2", "fire_truck_16x16.png"));
            UnitList.addNewObject(new SelectableListObject("FireTruck 3", "fire_truck_16x16.png"));
            UnitList.addNewObject(new SelectableListObject("FireTruck 4", "fire_truck_16x16.png"));
            UnitList.addNewObject(new SelectableListObject("FireTruck 5", "fire_truck_16x16.png"));
            UnitList.addNewObject(new SelectableListObject("FireTruck 6", "fire_truck_16x16.png"));
            UnitList.addNewObject(new SelectableListObject("Ambulance 1", "ambulance.png"));
            UnitList.addNewObject(new SelectableListObject("Ambulance 2", "ambulance.png"));
            UnitList.addNewObject(new SelectableListObject("Ambulance 3", "ambulance.png"));

        }

        private void ScaleMap_Click(object sender, RoutedEventArgs e)
        {

            mapDisplay.ScaleMap();
        }
    }
}