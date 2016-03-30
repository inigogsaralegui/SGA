namespace SGA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UBCM")]
    public partial class UBCM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UBCM()
        {
            UBCI = new HashSet<UBCI>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string sUBCM_ALMACEN { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string sUBCM_ZONA { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(3)]
        public string sUBCM_ESTANTERIA { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(3)]
        public string sUBCM_PROFUNDIDAD { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(2)]
        public string sUBCM_ALTURA { get; set; }

        public bool bUBCM_MONOPRODUCTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UBCI> UBCI { get; set; }
    }
}
