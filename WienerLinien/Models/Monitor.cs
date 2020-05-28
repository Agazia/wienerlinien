using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WienerLinien.Models
{
    public class Monitor
    {
        public LocationStop locationStop { get; set; }
        public IList<Line> lines { get; set; }
        public Attributes attributes { get; set; }
}
}
