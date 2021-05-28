using System;
using System.Collections.Generic;

#nullable disable

namespace DataClass
{
    public partial class Enrolment
    {
        public int EnrolmentId { get; set; }
        public string Grade { get; set; }
        public DateTime? EnrolmentDate { get; set; }
        public int? CourseId { get; set; }
        public int? StudentId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
