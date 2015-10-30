using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WaySpot.Models
{
    public class Hold
    {
        public int HoldID { get; set; }
        [Required]
        public string Person { get; set; }
        [Required]
        public DateTime HoldDateTime { get; set; }
        public string Comments { get; set; }
    }
}