using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using DandD.Home;

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
            var levl = new DandD.Home.PointsGet();
            try
            {
                int Level = Convert.ToInt32(LevelText.Text);
                int Points = Convert.ToInt32(PointsText.Text);
                LevelText.Text = Convert.ToString(PointsGet.LevelChange(Level));
                PointsText.Text = Convert.ToString(PointsGet.PointsChange(Points, Level));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Проверьте формат ввода. Ошибка: {ex}");
            }
        }

        private void Button_PDF(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Reset(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_CharChange(object sender, SelectionChangedEventArgs e)
        {
            ImageChar.Source = CharSelect.SelectedIndex switch
            {
                0 => new BitmapImage(new Uri("pack://application:,,,/Reference/charAssasin.png")),
                1 => new BitmapImage(new Uri("pack://application:,,,/Reference/charMage.png")),
                2 => new BitmapImage(new Uri("pack://application:,,,/Reference/charHealer.png")),
                3 => new BitmapImage(new Uri("pack://application:,,,/Reference/charTank.png")),
                4 => new BitmapImage(new Uri("pack://application:,,,/Reference/charWarrior.png")),
                _ => new BitmapImage(new Uri("pack://application:,,,/Reference/charAssasin.png")),
            };
        }
    }
}
