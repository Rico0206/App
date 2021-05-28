using System;
using System.Collections.Generic;

#nullable disable

namespace DataClass
{
    public partial class Department
    {
        public Department()
        {
            Courses = new HashSet<Course>();
            TeacherDepartments = new HashSet<TeacherDepartment>();
        }

        public int DepartmentId { get; set; }
        public string Title { get; set; }
        public int? Budget { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<TeacherDepartment> TeacherDepartments { get; set; }
    }
}
