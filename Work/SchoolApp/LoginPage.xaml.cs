using BusinessClass;
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

namespace SchoolApp
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        StudentBusiness studentBusiness = new();
        TeacherBusiness teacherBusiness = new();
        public LoginPage()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (studentBusiness.StudentLogin(user.Text, pass.Text))
            {
                Main.Content = new ProfilePage(user.Text);               
            }

            else if (teacherBusiness.LoginTeacher(user.Text, pass.Text))
            {
                Main.Content = new TeacherProfilePage(user.Text);
            }

            else
            {
                user.BorderBrush = System.Windows.Media.Brushes.Red;
                pass.BorderBrush = System.Windows.Media.Brushes.Red;
            }
        }

        private void signup_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new SignupPage();
        }
    }
}
