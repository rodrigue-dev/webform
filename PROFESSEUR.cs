namespace webschool
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PROFESSEUR")]
    public partial class PROFESSEUR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROFESSEUR()
        {
            SESSIONUEs = new HashSet<SESSIONUE>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDPROFESSEUR { get; set; }

        [Required]
        [StringLength(32)]
        public string NOM { get; set; }

        [Required]
        [StringLength(32)]
        public string PRENOM { get; set; }

        public int TELEPHONE { get; set; }

        [Required]
        [StringLength(32)]
        public string EMAIL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SESSIONUE> SESSIONUEs { get; set; }
    }
}
