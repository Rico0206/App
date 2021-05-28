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
    /// Interaction logic for SignupPage.xaml
    /// </summary>
    public partial class SignupPage : Page
    {
        StudentBusiness studentBusiness = new();
        public SignupPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            //int.Parse(credits.Text);
            //DateTime.ParseExact(dob.Text, "dd/MM/yyyy", null);
            string _fname = fname.Text;
            string _lname = lname.Text;
            string _user = username.Text;
            string _pass = password.Text;
            DateTime _dob;
            string _hPhone = hPhone.Text;
            string _mobile = mPhone.Text;
            string _email = email.Text;
            string _addr = addr.Text;
            string _postcode = postcode.Text;
            string _city = city.Text;
            int _credits = 0;

            if (DateTime.TryParseExact(dob.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out _dob)
                || int.TryParse(credits.Text, out  _credits))
            {
                if (_fname == null || _lname == null || _user == null)
                {
                    if (_hPhone == null || _city == null || _credits <= 0)
                    {
                        login.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 36, 0));
                    }
                    else
                    {
                        studentBusiness.RegisterStudent(_fname, _lname, _user, _pass, _dob, _hPhone,
                        _mobile, _email, _addr, _postcode, _city, _credits);
                    }
                }
                else
                {
                    credits.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 36, 0));
                }


            }


        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new LoginPage();
        }

        private void teacher_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new TeacherSignup();
        }
    }
}
