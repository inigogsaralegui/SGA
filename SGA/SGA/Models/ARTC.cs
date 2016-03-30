namespace SGA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ARTC")]
    public partial class ARTC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ARTC()
        {
            ARTF = new HashSet<ARTF>();
        }

        [Key]
        [StringLength(50)]
        public string sARTC_CODIGO { get; set; }

        [Required]
        public string sARTC_DESCRIPCION { get; set; }

        [Column(TypeName = "numeric")]
        public decimal sARTC_EAN { get; set; }

        public bool bART_FIFO { get; set; }

        public bool bART_LIFO { get; set; }

        public bool bART_LOTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ARTF> ARTF { get; set; }
    }
}
