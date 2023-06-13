using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace b_school.Models
{
    public class Secteur
    {
        public int ID { get; set; }
        public string intitule { get; set; }
        public DateTime dateDebut { get; set; }
        public DateTime dateFin { get; set; }
    }
}