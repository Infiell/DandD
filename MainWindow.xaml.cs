using DandD.Home;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

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
            CharismaText.Text = Convert.ToString(PointsGet.PointCost(Convert.ToInt32(PointsText.Text), Convert.ToInt32(CharismaText.Text)));
            PointsText.Text = Convert.ToString(PointsGet.PointSpend(Convert.ToInt32(PointsText.Text)));

            var MultStats = new Calculate().GetCharStat(Convert.ToInt32(CharSelect.SelectedIndex), Convert.ToInt32(CharismaText.Text), "Charisma", 
                Convert.ToInt32(Weapon.SelectedIndex), Convert.ToInt32(Helmet.SelectedIndex), Convert.ToInt32(Chest.SelectedIndex), Convert.ToInt32(Pants.SelectedIndex),
                Convert.ToInt32(Boots.SelectedIndex), Convert.ToInt32(Skill1.SelectedIndex), Convert.ToInt32(Skill2.SelectedIndex),
                Convert.ToInt32(Skill3.SelectedIndex), Convert.ToInt32(Skill4.SelectedIndex), Convert.ToInt32(Skill5.SelectedIndex),
                Convert.ToInt32(Skill6.SelectedIndex), Convert.ToInt32(Skill7.SelectedIndex), Convert.ToInt32(Skill8.SelectedIndex),
                Convert.ToInt32(Skill9.SelectedIndex), Convert.ToInt32(Skill10.SelectedIndex));
            CharismaTextHide.Text = MultStats.ToString();

            var Power = new PowerCalc();
            PowerText.Text = Convert.ToString(Power.Calculator(Convert.ToInt32(StrengthTextHide.Text), Convert.ToInt32(ConstitutionTextHide.Text),
                Convert.ToInt32(DexterityTextHide.Text), Convert.ToInt32(IntelligenceTextHide.Text), Convert.ToInt32(WisdomTextHide.Text),
                Convert.ToInt32(CharismaTextHide.Text)));
        }

        private void Button_Wisdom(object sender, RoutedEventArgs e)
        {
            WisdomText.Text = Convert.ToString(PointsGet.PointCost(Convert.ToInt32(PointsText.Text), Convert.ToInt32(WisdomText.Text)));
            PointsText.Text = Convert.ToString(PointsGet.PointSpend(Convert.ToInt32(PointsText.Text)));

            var MultStats = new Calculate().GetCharStat(Convert.ToInt32(CharSelect.SelectedIndex), Convert.ToInt32(WisdomText.Text), "Wisdom",
                Convert.ToInt32(Weapon.SelectedIndex), Convert.ToInt32(Helmet.SelectedIndex), Convert.ToInt32(Chest.SelectedIndex), Convert.ToInt32(Pants.SelectedIndex),
                Convert.ToInt32(Boots.SelectedIndex), Convert.ToInt32(Skill1.SelectedIndex), Convert.ToInt32(Skill2.SelectedIndex),
                Convert.ToInt32(Skill3.SelectedIndex), Convert.ToInt32(Skill4.SelectedIndex), Convert.ToInt32(Skill5.SelectedIndex),
                Convert.ToInt32(Skill6.SelectedIndex), Convert.ToInt32(Skill7.SelectedIndex), Convert.ToInt32(Skill8.SelectedIndex),
                Convert.ToInt32(Skill9.SelectedIndex), Convert.ToInt32(Skill10.SelectedIndex));
            WisdomTextHide.Text = MultStats.ToString();

            var Power = new PowerCalc();
            PowerText.Text = Convert.ToString(Power.Calculator(Convert.ToInt32(StrengthTextHide.Text), Convert.ToInt32(ConstitutionTextHide.Text),
                Convert.ToInt32(DexterityTextHide.Text), Convert.ToInt32(IntelligenceTextHide.Text), Convert.ToInt32(WisdomTextHide.Text),
                Convert.ToInt32(CharismaTextHide.Text)));
        }

        private void Button_Intelligence(object sender, RoutedEventArgs e)
        {
            IntelligenceText.Text = Convert.ToString(PointsGet.PointCost(Convert.ToInt32(PointsText.Text), Convert.ToInt32(IntelligenceText.Text)));
            PointsText.Text = Convert.ToString(PointsGet.PointSpend(Convert.ToInt32(PointsText.Text)));

            var MultStats = new Calculate().GetCharStat(Convert.ToInt32(CharSelect.SelectedIndex), Convert.ToInt32(IntelligenceText.Text), "Intelligence",
                Convert.ToInt32(Weapon.SelectedIndex), Convert.ToInt32(Helmet.SelectedIndex), Convert.ToInt32(Chest.SelectedIndex), Convert.ToInt32(Pants.SelectedIndex),
                Convert.ToInt32(Boots.SelectedIndex), Convert.ToInt32(Skill1.SelectedIndex), Convert.ToInt32(Skill2.SelectedIndex),
                Convert.ToInt32(Skill3.SelectedIndex), Convert.ToInt32(Skill4.SelectedIndex), Convert.ToInt32(Skill5.SelectedIndex),
                Convert.ToInt32(Skill6.SelectedIndex), Convert.ToInt32(Skill7.SelectedIndex), Convert.ToInt32(Skill8.SelectedIndex),
                Convert.ToInt32(Skill9.SelectedIndex), Convert.ToInt32(Skill10.SelectedIndex));
            IntelligenceTextHide.Text = MultStats.ToString();

            var Power = new PowerCalc();
            PowerText.Text = Convert.ToString(Power.Calculator(Convert.ToInt32(StrengthTextHide.Text), Convert.ToInt32(ConstitutionTextHide.Text),
                Convert.ToInt32(DexterityTextHide.Text), Convert.ToInt32(IntelligenceTextHide.Text), Convert.ToInt32(WisdomTextHide.Text),
                Convert.ToInt32(CharismaTextHide.Text)));
        }

        private void Button_Dexterity(object sender, RoutedEventArgs e)
        {
            DexterityText.Text = Convert.ToString(PointsGet.PointCost(Convert.ToInt32(PointsText.Text), Convert.ToInt32(DexterityText.Text)));
            PointsText.Text = Convert.ToString(PointsGet.PointSpend(Convert.ToInt32(PointsText.Text)));

            var MultStats = new Calculate().GetCharStat(Convert.ToInt32(CharSelect.SelectedIndex), Convert.ToInt32(DexterityText.Text), "Dexterity",
                Convert.ToInt32(Weapon.SelectedIndex), Convert.ToInt32(Helmet.SelectedIndex), Convert.ToInt32(Chest.SelectedIndex), Convert.ToInt32(Pants.SelectedIndex),
                Convert.ToInt32(Boots.SelectedIndex), Convert.ToInt32(Skill1.SelectedIndex), Convert.ToInt32(Skill2.SelectedIndex),
                Convert.ToInt32(Skill3.SelectedIndex), Convert.ToInt32(Skill4.SelectedIndex), Convert.ToInt32(Skill5.SelectedIndex),
                Convert.ToInt32(Skill6.SelectedIndex), Convert.ToInt32(Skill7.SelectedIndex), Convert.ToInt32(Skill8.SelectedIndex),
                Convert.ToInt32(Skill9.SelectedIndex), Convert.ToInt32(Skill10.SelectedIndex));
            DexterityTextHide.Text = MultStats.ToString();

            var Power = new PowerCalc();
            PowerText.Text = Convert.ToString(Power.Calculator(Convert.ToInt32(StrengthTextHide.Text), Convert.ToInt32(ConstitutionTextHide.Text),
                Convert.ToInt32(DexterityTextHide.Text), Convert.ToInt32(IntelligenceTextHide.Text), Convert.ToInt32(WisdomTextHide.Text),
                Convert.ToInt32(CharismaTextHide.Text)));
        }

        private void Button_Constitution(object sender, RoutedEventArgs e)
        {
            ConstitutionText.Text = Convert.ToString(PointsGet.PointCost(Convert.ToInt32(PointsText.Text), Convert.ToInt32(ConstitutionText.Text)));
            PointsText.Text = Convert.ToString(PointsGet.PointSpend(Convert.ToInt32(PointsText.Text)));

            var MultStats = new Calculate().GetCharStat(Convert.ToInt32(CharSelect.SelectedIndex), Convert.ToInt32(ConstitutionText.Text), "Constitution",
                Convert.ToInt32(Weapon.SelectedIndex), Convert.ToInt32(Helmet.SelectedIndex), Convert.ToInt32(Chest.SelectedIndex), Convert.ToInt32(Pants.SelectedIndex),
                Convert.ToInt32(Boots.SelectedIndex), Convert.ToInt32(Skill1.SelectedIndex), Convert.ToInt32(Skill2.SelectedIndex),
                Convert.ToInt32(Skill3.SelectedIndex), Convert.ToInt32(Skill4.SelectedIndex), Convert.ToInt32(Skill5.SelectedIndex),
                Convert.ToInt32(Skill6.SelectedIndex), Convert.ToInt32(Skill7.SelectedIndex), Convert.ToInt32(Skill8.SelectedIndex),
                Convert.ToInt32(Skill9.SelectedIndex), Convert.ToInt32(Skill10.SelectedIndex));
            ConstitutionTextHide.Text = MultStats.ToString();

            var Power = new PowerCalc();
            PowerText.Text = Convert.ToString(Power.Calculator(Convert.ToInt32(StrengthTextHide.Text), Convert.ToInt32(ConstitutionTextHide.Text),
                Convert.ToInt32(DexterityTextHide.Text), Convert.ToInt32(IntelligenceTextHide.Text), Convert.ToInt32(WisdomTextHide.Text),
                Convert.ToInt32(CharismaTextHide.Text)));
        }

        private void Button_Strength(object sender, RoutedEventArgs e)
        {
            StrengthText.Text = Convert.ToString(PointsGet.PointCost(Convert.ToInt32(PointsText.Text),Convert.ToInt32(StrengthText.Text)));
            PointsText.Text = Convert.ToString(PointsGet.PointSpend(Convert.ToInt32(PointsText.Text)));

            var MultStats = new Calculate().GetCharStat(Convert.ToInt32(CharSelect.SelectedIndex), Convert.ToInt32(StrengthText.Text), "Strength",
                Convert.ToInt32(Weapon.SelectedIndex), Convert.ToInt32(Helmet.SelectedIndex), Convert.ToInt32(Chest.SelectedIndex), Convert.ToInt32(Pants.SelectedIndex),
                Convert.ToInt32(Boots.SelectedIndex), Convert.ToInt32(Skill1.SelectedIndex), Convert.ToInt32(Skill2.SelectedIndex),
                Convert.ToInt32(Skill3.SelectedIndex), Convert.ToInt32(Skill4.SelectedIndex), Convert.ToInt32(Skill5.SelectedIndex),
                Convert.ToInt32(Skill6.SelectedIndex), Convert.ToInt32(Skill7.SelectedIndex), Convert.ToInt32(Skill8.SelectedIndex),
                Convert.ToInt32(Skill9.SelectedIndex), Convert.ToInt32(Skill10.SelectedIndex));
            StrengthTextHide.Text = MultStats.ToString();

            var Power = new PowerCalc();
            PowerText.Text = Convert.ToString(Power.Calculator(Convert.ToInt32(StrengthTextHide.Text), Convert.ToInt32(ConstitutionTextHide.Text),
                Convert.ToInt32(DexterityTextHide.Text), Convert.ToInt32(IntelligenceTextHide.Text), Convert.ToInt32(WisdomTextHide.Text),
                Convert.ToInt32(CharismaTextHide.Text)));
        }

        private void Button_LVL(object sender, RoutedEventArgs e)
        {
            try
            {
                LevelText.Text = Convert.ToString(PointsGet.LevelChange(Convert.ToInt32(LevelText.Text)));
                PointsText.Text = Convert.ToString(PointsGet.PointsChange(Convert.ToInt32(PointsText.Text), Convert.ToInt32(LevelText.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}");
            }
        }

        private void Button_PDF(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Reset(object sender, RoutedEventArgs e)
        {
            LevelText.Text = "0";
            PointsText.Text = "0";
            StrengthText.Text = "0";
            ConstitutionText.Text = "0";
            DexterityText.Text = "0";
            IntelligenceText.Text = "0";
            WisdomText.Text = "0";
            CharismaText.Text = "0";

            StrengthTextHide.Text = "0";
            ConstitutionTextHide.Text = "0";
            DexterityTextHide.Text = "0";
            IntelligenceTextHide.Text = "0";
            WisdomTextHide.Text = "0";
            CharismaTextHide.Text = "0";

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

        private void ButtonHide(object sender, RoutedEventArgs e)
        {
            if (StrengthTextHide.Visibility == Visibility.Hidden)
            {
                StrengthTextHide.Visibility = Visibility.Visible;
                ConstitutionTextHide.Visibility = Visibility.Visible;
                DexterityTextHide.Visibility = Visibility.Visible;
                IntelligenceTextHide.Visibility = Visibility.Visible;
                WisdomTextHide.Visibility = Visibility.Visible;
                CharismaTextHide.Visibility = Visibility.Visible;
            }
            else
            {
                StrengthTextHide.Visibility = Visibility.Hidden;
                ConstitutionTextHide.Visibility = Visibility.Hidden;
                DexterityTextHide.Visibility = Visibility.Hidden;
                IntelligenceTextHide.Visibility = Visibility.Hidden;
                WisdomTextHide.Visibility = Visibility.Hidden;
                CharismaTextHide.Visibility = Visibility.Hidden;
            }
        }
    }
}
