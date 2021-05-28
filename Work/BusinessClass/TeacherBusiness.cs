using System;
using System.Linq;
using DataClass;

namespace BusinessClass
{
    public class TeacherBusiness
    {
        Teacher teacher { get; set; }
        string emailSignature = "@School.ac.uk";

        public void RegisterTeacher(string fname, string lname, string username, string passcode,
            DateTime dob, string homePhone, string mobile, string email, string addr,
            string postcode, string city)
        {
            using var db = new SchoolDBContext();


            var mail = (fname.ElementAt(0) + lname) + emailSignature;
            db.Add
                (
                new Teacher
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

        public bool LoginTeacher(string user, string pass)
        {
            bool result = false;

            using (var db = new SchoolDBContext())
            {
                var query =
                    from t in db.Teachers
                    where t.Username == user
                    select t.Passcode;

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

        public Teacher TeacherInfo(string username)
        {
            using (var db = new SchoolDBContext())
            {
                var query =
                    db.Teachers
                    .Where(s => s.Username == username);

                return query.FirstOrDefault();
            }
        }

        public void EditName(string user, string newName)
        {
            using (var db = new SchoolDBContext())
            {
                teacher = db.Teachers.Where(t => t.Username == user).FirstOrDefault();

                teacher.FirstName = newName;
                db.SaveChanges();
            }
        }

        public void EditLName(string user, string newLName)
        {
            using (var db = new SchoolDBContext())
            {
                teacher = db.Teachers.Where(t => t.Username == user).FirstOrDefault();

                teacher.LastName = newLName;
                db.SaveChanges();
            }
        }

        public void EditPassword(string user, string newPass)
        {
            using (var db = new SchoolDBContext())
            {
                teacher = db.Teachers.Where(t => t.Username == user).FirstOrDefault();

                teacher.Passcode = newPass;

                db.SaveChanges();
            }
        }

        public void EditAddress(string user, string addr, string city, string postcode)
        {
            using (var db = new SchoolDBContext())
            {
                teacher = db.Teachers.Where(t => t.Username == user).FirstOrDefault();

                teacher.Addr = addr;
                teacher.City = city;
                teacher.Postcode = postcode;

                db.SaveChanges();
            }
        }
    }
}
