using System;
using TestingQA.Models;

namespace TestingQA.Services
{
    public static class TrafficService
    {
        public static TrafficDataModel DisplayTrafficInfo(string location, DateTime dateAndTime)
        {
            return new TrafficDataModel()
            {
                Location = location,
                DateAndTime = dateAndTime,
                TrafficAverageSpeed = 35.4,
                TrafficDensity = 0.24,
                TruckPercentage = 0.15,
                NumberOfAccidents = 5
            };
        }

        public static TrafficDataModel CompareTrafficInfo (string location1, DateTime dateAndTime1, string location2, DateTime dateAndTime2)
        {
            return null;
        }
        
        public static TrafficDataModel ReadTrafficFromDatabase(bool dbconnection, string location, DateTime dateAndTime1)
        {
           if(dbconnection == true){
            return new TrafficDataModel()
            {
                dbconn
                Location = location;
                DateAndtime = dateAndTime;
            }
           }
        }
        
        public static ConnectToDatabase(bool dbconnection)
        {
            return dbconnection;
        }
    }
}
