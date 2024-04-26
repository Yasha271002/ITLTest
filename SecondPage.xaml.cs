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

namespace ITLTest
{

    public partial class SecondPage : Page
    {

        public SecondPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textUsername.Text) && !string.IsNullOrEmpty(textNumber.Text) && !string.IsNullOrEmpty(textEmail.Text))
            {
                this.NavigationService.Navigate(new ThreePage());
            } return;
        }
    }
}
