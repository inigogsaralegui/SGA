namespace SGA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ARTF")]
    public partial class ARTF
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string sARTF_CODIGO { get; set; }

        public bool bARTF_EAN { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? iARTF_DUN14 { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal iARTF_NFORMATO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal iARTF_CANTIDAD { get; set; }

        public bool bARTF_MATRICULA { get; set; }

        [StringLength(50)]
        public string sARTF_MATRICULA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal iARTF_PESO { get; set; }

        public virtual ARTC ARTC { get; set; }
    }
}
