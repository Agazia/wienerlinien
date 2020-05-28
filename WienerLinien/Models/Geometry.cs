using System.Collections.Generic;

namespace WienerLinien.Models
{
    public class Geometry
    {
        public string type { get; set; }
        public IList<double> coordinates { get; set; }
    }
}