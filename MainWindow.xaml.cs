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

        private void Button_PDF(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Reset(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_CharChange(object sender, SelectionChangedEventArgs e)
        {
            switch (CharSelect.SelectedIndex) {
                case 0: ImageChar.Source = new BitmapImage(new Uri("pack://application:,,,/Reference/charAssasin.png")); break;
                case 1: ImageChar.Source = new BitmapImage(new Uri("pack://application:,,,/Reference/charMage.png")); break;
                case 2: ImageChar.Source = new BitmapImage(new Uri("pack://application:,,,/Reference/charHealer.png")); break;
                case 3: ImageChar.Source = new BitmapImage(new Uri("pack://application:,,,/Reference/charTank.png")); break;
                case 4: ImageChar.Source = new BitmapImage(new Uri("pack://application:,,,/Reference/charWarrior.png")); break;
                    default: ImageChar.Source = new BitmapImage(new Uri("pack://application:,,,/Reference/charAssasin.png")); break;
        }
        }
    }
}
