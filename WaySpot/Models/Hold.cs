using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WaySpot.Models
{
    public class Hold
    {
        public int HoldID { get; set; }
        public string Person { get; set; }
        public DateTime HoldDateTime { get; set; }
        public string Comments { get; set; }
    }
}