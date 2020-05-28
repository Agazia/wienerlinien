namespace WienerLinien.Models
{
    public class Vehicle
    {
        public string name { get; set; }
        public string towards { get; set; }
        public string direction { get; set; }
        public string richtungsId { get; set; }
        public bool barrierFree { get; set; }
        public bool realtimeSupported { get; set; }
        public bool trafficjam { get; set; }
        public string type { get; set; }
        public Attributes attributes { get; set; }
        public int linienId { get; set; }
    }
}