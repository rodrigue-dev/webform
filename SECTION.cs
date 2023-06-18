namespace webschool
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SECTION")]
    public partial class SECTION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SECTION()
        {
            UEs = new HashSet<UE>();
            METIERs = new HashSet<METIER>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDSECTION { get; set; }

        public int IDSECTEUR { get; set; }

        [Required]
        [StringLength(1000)]
        public string DESCRIPTION { get; set; }

        [Required]
        [StringLength(1000)]
        public string IMAGESECTION { get; set; }

        public virtual SECTEUR SECTEUR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UE> UEs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<METIER> METIERs { get; set; }
    }
}
