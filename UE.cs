namespace webschool
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UE")]
    public partial class UE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UE()
        {
            SESSIONUEs = new HashSet<SESSIONUE>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDUE { get; set; }

        public int? IDSECTION { get; set; }

        [Required]
        [StringLength(32)]
        public string TITRE { get; set; }

        [Required]
        [StringLength(1000)]
        public string DESCRIPTION { get; set; }

        public int PERIODE { get; set; }

        public int ECTS { get; set; }

        public virtual SECTION SECTION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SESSIONUE> SESSIONUEs { get; set; }
    }
}
