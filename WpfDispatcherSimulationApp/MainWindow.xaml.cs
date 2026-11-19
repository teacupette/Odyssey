using System.Windows;
using Project.Core;

namespace WpfDispatcherSimulationApp
{
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
    internal enum Screen
    {
        MainScreen,
        StartScreen
    }
}