namespace WienerLinien.Models
{
    public class Properties
    {
        public string name { get; set; }
        public string title { get; set; }
        public string municipality { get; set; }
        public int municipalityId { get; set; }
        public string type { get; set; }
        public string coordName { get; set; }
        public string gate { get; set; }
        public Attributes attributes { get; set; }
    }
}