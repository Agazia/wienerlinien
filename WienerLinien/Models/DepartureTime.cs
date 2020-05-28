using System;

namespace WienerLinien.Models
{
    public class DepartureTime
    {
        public DateTime timePlanned { get; set; }
        public DateTime timeReal { get; set; }
        public int countdown { get; set; }
    }
}