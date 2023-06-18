namespace webschool
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SESSIONUE")]
    public partial class SESSIONUE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SESSIONUE()
        {
            LOCALs = new HashSet<LOCAL>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDSESSIONUE { get; set; }

        public int? IDPROFESSEUR { get; set; }

        public int? IDUE { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATEDEBUT { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATEFIN { get; set; }

        public int PERIODE { get; set; }

        public TimeSpan HEUREDEBUT { get; set; }

        public TimeSpan HEUREFIN { get; set; }

        public virtual PROFESSEUR PROFESSEUR { get; set; }

        public virtual UE UE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOCAL> LOCALs { get; set; }
    }
}
