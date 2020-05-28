namespace WienerLinien.Models
{
    public class Line
    {
        public string name { get; set; }
        public string towards { get; set; }
        public string direction { get; set; }
        public string platform { get; set; }
        public string richtungsId { get; set; }
        public bool barrierFree { get; set; }
        public bool realtimeSupported { get; set; }
        public bool trafficjam { get; set; }
        public Departures departures { get; set; }
        public string type { get; set; }
        public int lineId { get; set; }
    }
}