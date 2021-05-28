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
    /// Interaction logic for ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        StudentBusiness studentBusiness = new();

        private string test;

        public ProfilePage()
        {
            InitializeComponent();
        }

        public ProfilePage(string test)
        {
            InitializeComponent();

            this.test = test;
        }

        private void enrol_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new EnrollmentPage(test);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            TopName.Text = $"{studentBusiness.StudentInfo(test).Nickname}'s Profile";

            //Student Info
            fName.Text = studentBusiness.StudentInfo(test).FirstName ;
            lName.Text = studentBusiness.StudentInfo(test).LastName;
            sId.Text = studentBusiness.StudentInfo(test).StudentId.ToString();
            username.Text = studentBusiness.StudentInfo(test).Username;
            password.Text = studentBusiness.StudentInfo(test).Passcode;
            addr.Text = studentBusiness.StudentInfo(test).Addr;
            credits.Text = studentBusiness.StudentInfo(test).Credits.ToString();
            pCode.Text = studentBusiness.StudentInfo(test).Postcode.ToString();
            city.Text = studentBusiness.StudentInfo(test).City.ToString();

            //Student Enrolment Info
            tName.Text = studentBusiness.TeacherInfo(test).FirstName + " " + studentBusiness.TeacherInfo(test).LastName;
            tNumber.Text = studentBusiness.TeacherInfo(test).MobilePhone.ToString();
            cName.Text = studentBusiness.CourseInfo(test).Title;
            cDate.Text = studentBusiness.CourseInfo(test).StartDate.ToString();
        }

        private void refresh_Click(object sender, RoutedEventArgs e)
        {
            if (fName.Text != studentBusiness.StudentInfo(test).FirstName && fName.Text != null)
            {
                studentBusiness.EditName(test, fName.Text);
            }            
            if (lName.Text != studentBusiness.StudentInfo(test).LastName && lName.Text != null)
            {
                studentBusiness.EditName(test, lName.Text);
            }           
            if (password.Text != studentBusiness.StudentInfo(test).Passcode && password.Text != null)
            {
                studentBusiness.EditPassword(test, password.Text);
            }
            if (addr.Text != studentBusiness.StudentInfo(test).Addr && addr.Text != null)
            {
                studentBusiness.EditAddress(test, addr.Text, city.Text, pCode.Text);
            }
        }

        private void log_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new LoginPage();
        }
    }
}
