using NUnit.Framework;
using BusinessClass;
using DataClass;
using System.Linq;
using System;

namespace FunctionTests
{
    public class StudentTests
    {

        StudentBusiness _student;
        DateTime date = DateTime.Today;

        [SetUp]
        public void Setup()
        {
            _student = new StudentBusiness();


            // remove test entry in DB if present
            using (var db = new SchoolDBContext())
            {
                var selectedStudents =
                from s in db.Students
                where s.Username == "TestU"
                select s;

                db.Students.RemoveRange(selectedStudents);
                db.SaveChanges();
            }
        }

        [Test]
        public void WhenANewStudentrIsRegistered_TheNumberOfStudentsIncreasesBy1()
        {
            using (var db = new SchoolDBContext())
            {
                var NumberOfStudentsPrior = db.Students.Count();


                _student.RegisterStudent("Test", "TestS", "TestU", "TestP", date, "07898789890",
                    "01232186781", "TestEmail", "TestStreet", "E10 3ju", "TestCity", 1000);

                var numberOfStudentsAfter = db.Students.Count();

                Assert.AreEqual(NumberOfStudentsPrior + 1, numberOfStudentsAfter);
            }
        }


        [Test]
        public void WhenStudentDetailsAreChanged_DatabaseWillChange()
        {
            using (var db = new SchoolDBContext())
            {
                _student.RegisterStudent("Test", "TestS", "TestU", "TestP", date, "07898789890",
                                         "01232186781", "TestEmail", "TestStreet", "E10 3ju", "TestCity", 1000);
                _student.EditName("TestU","TestSuccess");

                var update = db.Students.Where(s => s.Username == "TestU").FirstOrDefault();
                Assert.AreEqual("TestSuccess", update.FirstName);

            }
        }

        [Test]
        public void WhenStudentLastNameIsChanged_DatabaseWillChange()
        {
            using (var db = new SchoolDBContext())
            {
                _student.RegisterStudent("Test", "TestS", "TestU", "TestP", date , "07898789890",
                                         "01232186781", "TestEmail", "TestStreet", "E10 3ju", "TestCity", 1000);
                _student.EditLName("TestU","TestSuccess");

                var update = db.Students.Where(s => s.Username == "TestU").FirstOrDefault();
                Assert.AreEqual("TestSuccess", update.LastName);
            }
        }

        [Test]
        public void WhenStudentPasswordIsChanged_DatabaseWillChange()
        {
            using (var db = new SchoolDBContext())
            {
                _student.RegisterStudent("Test", "TestS", "TestU", "TestP", date, "07898789890",
                                         "01232186781", "TestEmail", "TestStreet", "E10 3ju", "TestCity", 1000);
                _student.EditPassword("TestU","TestSuccess");

                var update = db.Students.Where(s => s.Username == "TestU").FirstOrDefault();
                Assert.AreEqual("TestSuccess", update.Passcode);

            }
        }

        [Test]
        public void WhenStudentAddressIsChangedDatabaseWillChange()
        {
            using (var db = new SchoolDBContext())
            {
                _student.RegisterStudent("Test", "TestS", "TestU", "TestP", date, "07898789890",
                                         "01232186781", "TestEmail", "TestStreet", "E10 3ju", "TestCity", 1000);
                _student.EditAddress("TestU","TestLane", "CityTest", "TestPostcode");

                var update = db.Students.Where(s => s.Username == "TestU").FirstOrDefault();

                Assert.AreEqual("TestLane", update.Addr);
                Assert.AreEqual("CityTest", update.City);
                Assert.AreEqual("TestPostcode", update.Postcode);
            }
        }

        public void WhenStudentEnrolsDatabaswWillBeUpdated()
        {

        }


        [TearDown]
        public void TearDown()
        {
            using (var db = new SchoolDBContext())
            {
                var selectedStudents =
                from s in db.Students
                where s.Username == "TestU"
                select s;

                db.Students.RemoveRange(selectedStudents);
                db.SaveChanges();
            }
        }
    }
}