using DataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessClass
{
    public class EnrolmentBusiness
    {

        public void EnrolStudent(int courseId, int studentId )
        {
            using var db = new SchoolDBContext();
            db.Add(new Enrolment
            {
                Grade = "A",
                EnrolmentDate = DateTime.Today,
                CourseId = courseId,
                StudentId = studentId
            });
        }

        public List<Course> Enrolment()
        {
            List<Course> queryables = new();
            using (var db = new SchoolDBContext())
            {
                var query =
              db.Departments
              .Join(db.Courses, d => d.DepartmentId, c => c.DepartmentId,
              (c, d) => d);

                queryables = query.ToList();
            }
            return queryables;
        }

        public List<Course> SearchCourses(string search)
        {
            List<Course> queryables = new();
            using (var db = new SchoolDBContext())
            {
                var query =
              db.Courses
              .Where(c => c.Title.Contains(search));

                queryables = query.ToList();
            }
            return queryables;
        }
    }
}
