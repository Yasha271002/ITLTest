using System.Windows.Controls;


namespace ITLTest
{
    /// <summary>
    /// Логика взаимодействия для FourPage.xaml
    /// </summary>
    public partial class FourPage : Page
    {
        public FourPage()
        {
            InitializeComponent();
            CloseWindow();
        }

        private async void CloseWindow()
        {
            await ClosingTasks();
        }

        private async Task ClosingTasks()
        {
            await Task.Delay(2000);
            this.NavigationService.Navigate(new FirstPage());
        }
        
    }
}
