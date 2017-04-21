using System.Windows;

namespace DemoApp
{
    /// <summary>
    /// Interaction logic for ButtonsWindow.xaml
    /// </summary>
    public partial class ButtonsWindow : Window
    {
        public ButtonsWindow()
        {
            InitializeComponent();
        }

        private void CloseClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
