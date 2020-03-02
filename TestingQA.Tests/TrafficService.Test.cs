using NUnit.Framework;
using System;
using TestingQA.Models;
using TestingQA.Services;

namespace TestingQA.Tests
{
    public class Test
    {
        private string happyLocation;
        private string invalidLocation;
        private DateTime happyDateAndTime;
        private DateTime invalidDateAndTime;
             

        [SetUp]
        public void Setup()
        {
            happyLocation = "Kennesaw";
            invalidLocation = "Antarctica";
            happyDateAndTime = new DateTime(2019, 7, 24, 9, 37, 54); // yy,MM,dd,hh,mm,ss
            invalidDateAndTime = new DateTime(2022, 7, 24, 9, 37, 54); // yy,MM,dd,hh,mm,ss
        }

        [Test]
        public void DisplayTrafficInfo_Happy()
        {
            TrafficDataModel expected = new TrafficDataModel()
            {
                Location = happyLocation,
                DateAndTime = happyDateAndTime,
                TrafficAverageSpeed = 35.4,
                TrafficDensity = 0.24,
                TruckPercentage = 0.15,
                NumberOfAccidents = 5
            };
            var actual = TrafficService.DisplayTrafficInfo(happyLocation, happyDateAndTime);

            Assert.AreEqual(expected.Location, actual.Location);
            Assert.AreEqual(expected.DateAndTime, actual.DateAndTime);
            Assert.AreEqual(expected.TrafficAverageSpeed, actual.TrafficAverageSpeed);
            Assert.AreEqual(expected.TrafficDensity, actual.TrafficDensity);
            Assert.AreEqual(expected.TruckPercentage, actual.TruckPercentage);
            Assert.AreEqual(expected.NumberOfAccidents, actual.NumberOfAccidents);
        }

        [Test]
        public void DisplayTrafficInfo_NullLocation()
        {
            var ex = Assert.Throws<ArgumentNullException>(() =>
            {
                TrafficService.DisplayTrafficInfo(null, happyDateAndTime);
            });

            Assert.That(ex.Message, Is.EqualTo("Location is required."));
        }

        [Test]
        public void DisplayTrafficInfo_InvalidLocation()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                TrafficService.DisplayTrafficInfo(invalidLocation, happyDateAndTime);
            });

            Assert.That(ex.Message, Is.EqualTo("Invalid location input."));
        }

        [Test]
        public void DisplayTrafficInfo_InvalidDateTime()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                TrafficService.DisplayTrafficInfo(happyLocation, invalidDateAndTime);
            });

            Assert.That(ex.Message, Is.EqualTo("Invalid dateAndTime input."));
        }
        
        [Test]
        public void DatabaseConnection_Happy()
        {
            Database db = new Database(...);
            bool dbconnection = db.Open();
            Assert.IsTrue(dbconnection);
        }
        
        [Test]
        public void DatabaseConnection_False()
        {
            Database db = new Database(...);
            bool dbconnection = falseDBConnection;
            Assert.IsTrue(dbconnection);
        }
        
         [Test]
        public void ReadTrafficDataFromDatabase_Happy()
        {
            TrafficDataModel expected = new TrafficDataModel()
            {
                Database db = new Database(...);
                dbconnection = ConnectToDatabse(db.Open());
                Location = happyLocation,
                DateAndTime = happyDateAndTime,
                
            };
            var actual = TrafficService.ReadTrafficDataFromDatabase(dbconnection, happyLocation, happyDateAndTime);

            Assert.IsTrue(dbconnnection);
            Assert.AreEqual(expected.Location, actual.Location);
            Assert.AreEqual(expected.DateAndTime, actual.DateAndTime);
           
        }
        [Test]
        public void ReadTrafficDataFromDatabase_False()
        {
            TrafficDataModel expected = new TrafficDataModel()
            {
                Database db = new Database(...);
                dbconnection = false;
                Location = invalidLocation,
                DateAndTime = invalidDateAndTime,
                
            };
            var actual = TrafficService.ReadTrafficDataFromDatabase(dbconnection, happyLocation, happyDateAndTime);

            Assert.IsTrue(dbconnnection);
            Assert.AreEqual(expected.Location, actual.Location);
            Assert.AreEqual(expected.DateAndTime, actual.DateAndTime);
           
        }
    }
}
