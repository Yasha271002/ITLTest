using System.Windows;
using System.Windows.Controls;

namespace ITLTest
{
    /// <summary>
    /// Логика взаимодействия для FirstPage.xaml
    /// </summary>
    public partial class FirstPage : Page
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void MainButtonPage_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new SecondPage());
        }
    }
}
