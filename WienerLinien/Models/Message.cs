using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WienerLinien.Models
{
    public class Message
    {
        public string value { get; set; }
        public int messageCode { get; set; }
        public DateTime serverTime { get; set; }
    }
}
