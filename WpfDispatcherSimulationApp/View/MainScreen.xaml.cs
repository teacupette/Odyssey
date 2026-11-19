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
using WpfDispatcherSimulationApp.View.UserControls;

namespace WpfDispatcherSimulationApp.View
{
    /// <summary>
    /// Interaction logic for MainScreen.xaml
    /// </summary>
    public partial class MainScreen : UserControl
    {
        public event RoutedEventHandler? ExitPressed;

        public MainScreen()
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


            CallTranscricpt.Text = "Operator: “112, what’s your emergency?” \r\n    • Caller: “My shop’s fire alarm has gone off. The address is Perlegade 67.” \r\n    • Operator: “What’s your phone number, in case we get cut off?” \r\n    • Operator: “Are you at the shop now, or is anyone there?” \r\n    • Caller: “No, I’m at home, far away. I just got an alarm notification on my phone.” \r\n    • Operator: “Do you know of any smoke, fire, or smell, or has anyone nearby reported anything?” \r\n    • Caller: “No, I only know the alarm has been triggered.” \r\n    • Operator: “Is the building more than one floor, and is it connected to other buildings or homes?” \r\n    • Caller: “No, only ground floor, and it stands alone.” \r\n    • Operator: “What’s the name of the shop, and your name?” \r\n    • Caller: “Alberts Bageri. Albert Mikkelsen.” \r\n    • Operator: “Is there anything dangerous inside, like gas, ovens that might be on, or other hazards?” \r\n    • Caller: “There are gas ovens, but they should be off at night.” \r\n    • Operator: “Has this alarm gone off falsely before?” \r\n    • Caller: “No, definitely not.” \r\n    • Operator: “Can the fire service access the building, or does someone need to bring a key?” \r\n    • Caller: “There’s a key box by the front door. I can also drive over.” \r\n    • Operator: “Please don’t go inside if you arrive before us. Wait outside and stay reachable on this number. We are sending help now.”";
        }

        private void ScaleMap_Click(object sender, RoutedEventArgs e)
        {

            mapDisplay.ScaleMap();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            ExitPressed?.Invoke(this, new RoutedEventArgs());
        }
    }
}
