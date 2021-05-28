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
    /// Interaction logic for TeacherProfilePage.xaml
    /// </summary>
    public partial class TeacherProfilePage : Page
    {
        TeacherBusiness teacherBusiness = new();
        string user;
        public TeacherProfilePage()
        {
            InitializeComponent();
        }

        public TeacherProfilePage(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            topNames.Text = teacherBusiness.TeacherInfo(user).FirstName;
            tDob.Text = teacherBusiness.TeacherInfo(user).Dob.ToString();
            tId.Text = teacherBusiness.TeacherInfo(user).TeacherId.ToString();
            tName.Text = teacherBusiness.TeacherInfo(user).FirstName + " " + teacherBusiness.TeacherInfo(user).LastName;
            tUser.Text = teacherBusiness.TeacherInfo(user).Username;
            tPass.Text = teacherBusiness.TeacherInfo(user).Passcode;
            addr.Text = teacherBusiness.TeacherInfo(user).Addr + " " + teacherBusiness.TeacherInfo(user).City + " " + teacherBusiness.TeacherInfo(user).Passcode;
            hPhone.Text = teacherBusiness.TeacherInfo(user).HomePhone.ToString();
            mPhone.Text = teacherBusiness.TeacherInfo(user).MobilePhone.ToString();
        }
    }
}
