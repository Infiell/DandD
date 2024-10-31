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

namespace DandD
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {

            }
        }

        private void Button_Charisma(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Wisdom(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Intelligence(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Dexterity(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Constitution(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Strength(object sender, RoutedEventArgs e)
        {

        }

        private void Button_LVL(object sender, RoutedEventArgs e)
        {

        }
    }
}
