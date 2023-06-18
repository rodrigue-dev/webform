namespace webschool
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SECTEUR")]
    public partial class SECTEUR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SECTEUR()
        {
            SECTIONs = new HashSet<SECTION>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDSECTEUR { get; set; }

        [Required]
        [StringLength(32)]
        public string INTITULE { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATEDEBUT { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATEFIN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SECTION> SECTIONs { get; set; }
    }
}
