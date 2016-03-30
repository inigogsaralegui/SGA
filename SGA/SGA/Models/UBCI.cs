namespace SGA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UBCI")]
    public partial class UBCI
    {
        public int id { get; set; }

        [Required]
        [StringLength(4)]
        public string sUBCI_ALMACEN { get; set; }

        [Required]
        [StringLength(2)]
        public string sUBCI_ZONA { get; set; }

        [Required]
        [StringLength(3)]
        public string sUBCI_ESTANTERIA { get; set; }

        [Required]
        [StringLength(3)]
        public string sUBCI_PROFUNDIDAD { get; set; }

        [Required]
        [StringLength(2)]
        public string sUBCI_ALTURA { get; set; }

        [Required]
        [StringLength(50)]
        public string sUBCI_CODIGOART { get; set; }

        [Column(TypeName = "numeric")]
        public decimal iUBCI_CODIGOFMT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal iUBCI_DUN14 { get; set; }

        [StringLength(50)]
        public string iUBCI_MATRICULA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal iUBCI_CANTIDAD { get; set; }

        [Column(TypeName = "numeric")]
        public decimal iUBCI_PESO { get; set; }

        public DateTime iUBCI_FECHAALM { get; set; }

        [Required]
        [StringLength(50)]
        public string iUBCI_LOTE { get; set; }

        public virtual UBCM UBCM { get; set; }
    }
}
