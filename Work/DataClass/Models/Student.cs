using System;
using System.Collections.Generic;

#nullable disable

namespace DataClass
{
    public partial class Student
    {
        public Student()
        {
            Enrolments = new HashSet<Enrolment>();
        }

        public int StudentId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Nickname { get; set; }
        public string Username { get; set; }
        public string Passcode { get; set; }
        public DateTime? Dob { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string Addr { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
        public int? Credits { get; set; }

        public virtual ICollection<Enrolment> Enrolments { get; set; }
    }
}
