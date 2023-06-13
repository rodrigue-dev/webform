using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace b_school.Models
{
    public class Section
    {
        public int ID { get; set; }
        public string debouches { get; set; }
        public string description { get; set; }
        public string imageSection { get; set; }
        public Secteur secteur { get; set; }
    }
}