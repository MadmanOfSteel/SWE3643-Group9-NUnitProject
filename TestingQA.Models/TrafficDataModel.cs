using System;

namespace TestingQA.Models
{
    public class TrafficDataModel
    {
        public string Location { get; set; }
        public DateTime DateAndTime { get; set; }
        public double TrafficAverageSpeed { get; set; }
        public double TrafficDensity { get; set; }
        public double TruckPercentage { get; set; }
        public int NumberOfAccidents { get; set; }
    }
}
