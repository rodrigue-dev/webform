using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace b_school.Models
{
    public class SessionUe
    {
        public int ID { get; set; }
        public string periode { get; set; }
        public string lieu { get; set; }
        public int etcs { get; set; }
        public DateTime dateDebut { get; set; }
        public DateTime dateFin { get; set; }
    }
}