using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DemoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonsDemo(object sender, RoutedEventArgs e)
        {
            new ButtonsWindow().ShowDialog();
        }

        private void ListsDemo(object sender, RoutedEventArgs e)
        {
            new ListsWindow().ShowDialog();
        }

        private void TreeDemo(object sender, RoutedEventArgs e)
        {
            new TreeWindow().ShowDialog();
        }
    }
}
