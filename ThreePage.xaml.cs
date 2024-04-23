using System.Windows;
using System.Windows.Controls;


namespace ITLTest
{
    /// <summary>
    /// Логика взаимодействия для ThreePage.xaml
    /// </summary>
    public partial class ThreePage : Page
    {
        public ThreePage()
        {
            InitializeComponent();
        }

        private void ButtonConfirmNumber_Click(object sender, RoutedEventArgs e)
        {
            if (PhoneCode.Text != "000")
            {
                PhoneCode.Text = "Неа";
            }
            else
            {
                this.NavigationService.Navigate(new FourPage());
            }
        }
    }
}
