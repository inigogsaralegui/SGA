namespace SGA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    public partial class USRS
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Key]
        [StringLength(50)]
        public string sUSRS_USUARIO { get; set; }

        [Required]
        [StringLength(50)]
        public string sUSRS_PASSWORD { get; set; }

        [Required]
        [StringLength(20)]
        public string sUSRS_ROL { get; set; }

        [Required]
        [StringLength(50)]
        public string sUSRS_NOMBRE { get; set; }

        [Required]
        [StringLength(50)]
        public string sUSRS_APELLIDO1 { get; set; }

        [Required]
        [StringLength(50)]
        public string sUSRS_APELLIDO2 { get; set; }

        public bool sUSRS_ACTIVO { get; set; }

        [Required]
        [StringLength(5)]
        public string sUSRS_CULTURA { get; set; }

        public List<USRS> Listar()
        {
            var usuarios = new List<USRS>();
            try
            {
                using (var context = new SGAContext())
                {
                    usuarios = context.USRS.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return usuarios;
        }

        public USRS Obtener(string username)
        {
            var usuario = new USRS();
            try
            {
                using (var context = new SGAContext())
                {
                    usuario = context.USRS
                        .Where(x => x.sUSRS_USUARIO == username)
                        .Single();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return usuario;
        }

        public void Guardar()
        {
            try
            {
                using (var context = new SGAContext())
                {
                    if (this.id == 0)
                    {
                        context.Entry(this).State = System.Data.Entity.EntityState.Added;
                    }
                    else
                    {
                        context.Entry(this).State = System.Data.Entity.EntityState.Modified;
                    }

                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
