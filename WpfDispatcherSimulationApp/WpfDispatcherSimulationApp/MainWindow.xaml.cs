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
using WpfDispatcherSimulationApp.View;
using WpfDispatcherSimulationApp.View.UserControls;

namespace WpfDispatcherSimulationApp
{
    public enum Screen
    {
        MainScreen,
        StartScreen
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            changeScreen(Screen.StartScreen);
        }

        private void changeScreen(Screen nextScreen)
        {
            startScreen.Visibility = Visibility.Hidden;
            mainScreen.Visibility = Visibility.Hidden;
            switch (nextScreen)
            {
                case Screen.MainScreen:
                    mainScreen.Visibility = Visibility.Visible;

                    break;
                
                case Screen.StartScreen:
                    startScreen.Visibility = Visibility.Visible;
                    break;
            }
        }
        private void startScreen_StartPressed(object sender, RoutedEventArgs e)
        {
            changeScreen(Screen.MainScreen);
        }

        private void mainScreen_ExitPressed(object sender, RoutedEventArgs e)
        {
            changeScreen(Screen.StartScreen);
        }
    }
}