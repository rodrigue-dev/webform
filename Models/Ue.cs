using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace b_school.Models
{
    public class Ue
    {
        public int ID { get; set; }
        public string titre { get; set; }
        public string description { get; set; }
        public string periode { get; set; }
        public int ects { get; set; }
    }
}