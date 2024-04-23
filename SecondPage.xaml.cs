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

        private void textUsername_MouseEnter(object sender, MouseEventArgs e)
        {
            if (textUsername.Text != null)
            {
                textUsername.Text = "";
            }
            else
            {
                textUsername.Text = "Фамилия, Имя, Отчество";
            }
        }

        private void textNumber_MouseEnter(object sender, MouseEventArgs e)
        {
            if (textNumber.Text != null) 
            {
                textNumber.Text = "";
            } return;
        }

        private void textEmail_MouseEnter(object sender, MouseEventArgs e)
        {
            if(textEmail.Text != null) 
            {
                textEmail.Text = "";
            } return;
        }
    }
}
