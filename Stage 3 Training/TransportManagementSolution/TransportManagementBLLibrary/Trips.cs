using System;

namespace TransportManagementBLLibrary
{
    public class Trips
    {
        public int Id { get; set; }
        public string BusName { get; set; }
        public int DriverId { get; set; }
        public string Stop1 { get; set; }
        public DateTime Stop1Time { get; set; }
        public string Stop2 { get; set; }
        public DateTime Stop2Time { get; set; }
        public string Stop3 { get; set; }
        public DateTime Stop3Time { get; set; }
    }
}