using System;
using NUnit.Framework;
using System.Linq;
using BusinessClass;
using DataClass;

namespace FunctionTests
{
    class TeacherTest
    {
        TeacherBusiness _teacher;
        DateTime date = DateTime.Today;

        [SetUp]
        public void Setup()
        {
            _teacher = new TeacherBusiness();

            // remove test entry in DB if present
            using (var db = new SchoolDBContext())
            {
                var selectedTeacher =
                from t in db.Teachers
                where t.Username == "TestU"
                select t;

                db.Teachers.RemoveRange(selectedTeacher);
                db.SaveChanges();
            }
        }

        [Test]
        public void WhenANewTeacherIsRegistered_TheNumberOfTeacherssIncreasesBy1()
        {
            using (var db = new SchoolDBContext())
            {
                var NumberOfTeachersPrior = db.Teachers.Count();

                _teacher.RegisterTeacher("Test", "TestS", "TestU", "TestP", date, "07898789890",
                    "01232186781", "TestEmail", "TestStreet", "E10 3ju", "TestCity");

                var numberOfTeachersAfter = db.Teachers.Count();

                Assert.AreEqual(NumberOfTeachersPrior + 1, numberOfTeachersAfter);
            }
        }

        [Test]
        public void WhenTeacherDetailsAreChanged_DatabaseWillChange()
        {
            using (var db = new SchoolDBContext())
            {
                _teacher.RegisterTeacher("Test", "TestS", "TestU", "TestP", date, "07898789890",
                                         "01232186781", "TestEmail", "TestStreet", "E10 3ju", "TestCity");
                _teacher.EditName("TestU", "TestSuccess");

                var update = db.Teachers.Where(t => t.Username == "TestU").FirstOrDefault();
                Assert.AreEqual("TestSuccess", update.FirstName);

            }
        }

        [Test]
        public void WhenStudentDetailsAreChanged_DatabaseWillChange()
        {
            using (var db = new SchoolDBContext())
            {
                _teacher.RegisterTeacher("Test", "TestS", "TestU", "TestP", date, "07898789890",
                                         "01232186781", "TestEmail", "TestStreet", "E10 3ju", "TestCity");
                _teacher.EditLName("TestU", "TestSuccess");

                var update = db.Teachers.Where(t => t.Username == "TestU").FirstOrDefault();
                Assert.AreEqual("TestSuccess", update.LastName);

            }
        }

        [Test]
        public void WhenTeacherPasscodeChanged_DatabaseWillChange()
        {
            using (var db = new SchoolDBContext())
            {
                _teacher.RegisterTeacher("Test", "TestS", "TestU", "TestP", date, "07898789890",
                                         "01232186781", "TestEmail", "TestStreet", "E10 3ju", "TestCity");
                _teacher.EditPassword("TestU","TestSuccess");

                var update = db.Teachers.Where(t => t.Username == "TestU").FirstOrDefault();
                Assert.AreEqual("TestSuccess", update.Passcode);

            }
        }

        [Test]
        public void WhenTeacherAddressAreChanged_DatabaseWillChange()
        {
            using (var db = new SchoolDBContext())
            {
                _teacher.RegisterTeacher("Test", "TestS", "TestU", "TestP", date, "07898789890",
                                         "01232186781", "TestEmail", "TestStreet", "E10 3ju", "TestCity");
                _teacher.EditAddress("TestU","TestLane", "CityTest", "TestPostcode");

                var update = db.Teachers.Where(t => t.Username == "TestU").FirstOrDefault();

                Assert.AreEqual("TestLane", update.Addr);
                Assert.AreEqual("CityTest", update.City);
                Assert.AreEqual("TestPostcode", update.Postcode);
            }
        }

        [TearDown]
        public void TearDown()
        {
            using (var db = new SchoolDBContext())
            {
                var selectedTeacher =
                from t in db.Teachers
                where t.Username == "TestU"
                select t;

                db.Teachers.RemoveRange(selectedTeacher);
                db.SaveChanges();
            }
        }
    }
}
