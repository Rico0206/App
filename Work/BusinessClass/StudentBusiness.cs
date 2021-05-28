using System;
using System.Linq;
using DataClass;

namespace BusinessClass
{
    public class StudentBusiness
    {
        public Student student { get; set; }
        string emailSignature = "@School.ac.uk";

        public void RegisterStudent(string fname, string lname, string username, string passcode,
            DateTime dob, string homePhone, string mobile, string email, string addr,
            string postcode, string city, int credits)
        {
            using var db = new SchoolDBContext();


            var mail = (fname.ElementAt(0) + lname) + emailSignature;
            db.Add(new Student
            {
                FirstName = fname,
                LastName = lname,
                Username = username,
                Passcode = passcode,
                Dob = dob,
                HomePhone = homePhone,
                MobilePhone = mobile,
                Email = mail,
                Addr = addr,
                Postcode = postcode,
                City = city
            });

            db.SaveChanges();
        }

        public bool StudentLogin(string user, string pass)
        {
            bool result = false;

            using (var db = new SchoolDBContext())
            {
                var query =
                    from s in db.Students
                    where s.Username == user
                    select s.Passcode;

                if (query.FirstOrDefault() != null)
                {
                    if (pass == query.FirstOrDefault())
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }

        public Teacher TeacherInfo(string user)
        {
            using (var db = new SchoolDBContext())
            {
                var query =
                    from s in db.Students
                    join e in db.Enrolments on s.StudentId equals e.StudentId
                    join c in db.Courses on e.CourseId equals c.CourseId
                    join ct in db.CourseTeachers on c.CourseId equals ct.CourseId
                    join t in db.Teachers on ct.TeacherId equals t.TeacherId
                    where s.Username == user
                    select t;

                return query.FirstOrDefault();
            }
        }

        public Course CourseInfo(string user)
        {
            using (var db = new SchoolDBContext())
            {
                var query =
                    from s in db.Students
                    join e in db.Enrolments on s.StudentId equals e.StudentId
                    join c in db.Courses on e.CourseId equals c.CourseId
                    join ct in db.CourseTeachers on c.CourseId equals ct.CourseId
                    join t in db.Teachers on ct.TeacherId equals t.TeacherId
                    where s.Username == user
                    select c;

                return query.FirstOrDefault();
            }
        }





        public Student StudentInfo(string username)
        {
            using (var db = new SchoolDBContext())
            {
                var query =
                    db.Students
                    .Where(s => s.Username == username);

                return query.FirstOrDefault();
            }
        }

        public void EditName(string user, string newName)
        {
            using (var db = new SchoolDBContext())
            {
                student = db.Students.Where(s => s.Username == user).FirstOrDefault();
                student.FirstName = newName;

                db.SaveChanges();
            }
        }

        public void EditAddress(string user,string addr, string city, string poscode)
        {
            using (var db = new SchoolDBContext())
            {
                student = db.Students.Where(s => s.Username == user).FirstOrDefault();

                student.Addr = addr;
                student.City = city;
                student.Postcode = poscode;

                db.SaveChanges();
            }
        }

        public void EditLName(string user, string newLName)
        {
            using (var db = new SchoolDBContext())
            {
                student = db.Students.Where(s => s.Username == user).FirstOrDefault();

                student.LastName = newLName;
                db.SaveChanges();
            }
        }

        public void EditPassword(string user, string newPass)
        {
            using (var db = new SchoolDBContext())
            {
                student = db.Students.Where(s => s.Username == user).FirstOrDefault();

                student.Passcode = newPass;
                db.SaveChanges();
            }
        }
    }
}
