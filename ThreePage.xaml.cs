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
            if(PhoneCode.Text == "0" && PhoneCodeTwo.Text == "0" && PhoneCodeThree.Text == "0")
            {
                this.NavigationService.Navigate(new FourPage());
            } return;
        }

        private void PhoneCode_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if(PhoneCode.Text.Length == PhoneCode.MaxLength)
            {
                PhoneCodeTwo.Focus();

                if(PhoneCodeTwo.Text.Length == PhoneCodeTwo.MaxLength)
                {
                    PhoneCodeThree.Focus();
                }
            }
        }

        private void PhoneCode_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(PhoneCodeThree.Text.Length != PhoneCodeThree.MaxLength) 
            {
                PhoneCodeTwo.Focus();
                if(PhoneCodeTwo.Text.Length != PhoneCodeTwo.MaxLength)
                {
                    PhoneCode.Focus();
                }
            }
        }
    }
}
