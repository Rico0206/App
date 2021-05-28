using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using BusinessClass;
using DataClass;
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
    /// Interaction logic for EnrollmentPage.xaml
    /// </summary>
    public partial class EnrollmentPage : Page
    {
        EnrolmentBusiness enrolmentBusiness = new();
        StudentBusiness studentBusiness = new();
        string user;

        public EnrollmentPage()
        {
            InitializeComponent();
        }

        public EnrollmentPage(string user)
        {
            InitializeComponent();
            this.user = user;
        }



        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dataView.ItemsSource = enrolmentBusiness.Enrolment();
        }

        private void prof_Click(object sender, RoutedEventArgs e)
        {
            Course course = dataView.SelectedItem as Course;
            string title = course.Title;
            string courseId = course.CourseId.ToString();
            string credits = course.Credits.ToString();
            string departmentId = course.DepartmentId.ToString();
            string startDate = course.StartDate.ToString();


            

           MessageBoxResult message = MessageBox.Show($"You Have Selected To Enrol In" +
                $"Course Title = {title} \n " +
                $"Course ID = {courseId} \n " +
                $"Credits REQUIRED = {credits} \n" +
                $"departmentId =  {departmentId} \n" +
                $"Start Date = {startDate} \n" , "Confirmation", MessageBoxButton.YesNo);
            switch (message)
            {
                case MessageBoxResult.Yes:
                    main.Content = new ProfilePage(user);
                    enrolmentBusiness.EnrolStudent(int.Parse(courseId), studentBusiness.StudentInfo(user).StudentId);
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Ok Try Again");
                    break;
                default:
                    break;
            }

            
        }

        private void searchbtn_Click(object sender, RoutedEventArgs e)
        {
            if (searchBox.Text != null)
            {
                dataView.ItemsSource = enrolmentBusiness.SearchCourses(searchBox.Text);
            }

            else
            {
                dataView.ItemsSource = enrolmentBusiness.Enrolment();
            }
            
        }
    }
}
