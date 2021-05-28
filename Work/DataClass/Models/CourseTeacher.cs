using System;
using System.Collections.Generic;

#nullable disable

namespace DataClass
{
    public partial class CourseTeacher
    {
        public int CourseId { get; set; }
        public int TeacherId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
