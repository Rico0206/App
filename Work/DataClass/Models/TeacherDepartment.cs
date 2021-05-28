using System;
using System.Collections.Generic;

#nullable disable

namespace DataClass
{
    public partial class TeacherDepartment
    {
        public int DepartmentId { get; set; }
        public int TeacherId { get; set; }

        public virtual Department Department { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
