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

namespace Prakt_2_15_11_WPF
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
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ChangeWindowColor();
        }
        private void ChangeWindowColor()
        {
            if (RadioButtonGreen.IsChecked == true)
            {

                Color.Background = new SolidColorBrush(Colors.Green);
            }
            else if (RadioButtonYellow.IsChecked == true)
            {

                Color.Background = new SolidColorBrush(Colors.Yellow);
            }
        }

    }
}
