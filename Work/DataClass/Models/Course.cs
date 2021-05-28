using System;
using System.Collections.Generic;

#nullable disable

namespace DataClass
{
    public partial class Course
    {
        public Course()
        {
            CourseTeachers = new HashSet<CourseTeacher>();
            Enrolments = new HashSet<Enrolment>();
        }

        public int CourseId { get; set; }
        public string Title { get; set; }
        public int? Credits { get; set; }
        public DateTime? StartDate { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<CourseTeacher> CourseTeachers { get; set; }
        public virtual ICollection<Enrolment> Enrolments { get; set; }
    }
}
