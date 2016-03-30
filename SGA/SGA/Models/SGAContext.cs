namespace SGA.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SGAContext : DbContext
    {
        public SGAContext()
            : base("name=SGAContext")
        {
        }

        public virtual DbSet<ARTC> ARTC { get; set; }
        public virtual DbSet<ARTF> ARTF { get; set; }
        public virtual DbSet<UBCI> UBCI { get; set; }
        public virtual DbSet<UBCM> UBCM { get; set; }
        public virtual DbSet<USRS> USRS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ARTC>()
                .Property(e => e.sARTC_EAN)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ARTC>()
                .HasMany(e => e.ARTF)
                .WithRequired(e => e.ARTC)
                .HasForeignKey(e => e.sARTF_CODIGO);

            modelBuilder.Entity<ARTF>()
                .Property(e => e.iARTF_DUN14)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ARTF>()
                .Property(e => e.iARTF_NFORMATO)
                .HasPrecision(2, 0);

            modelBuilder.Entity<ARTF>()
                .Property(e => e.iARTF_CANTIDAD)
                .HasPrecision(3, 0);

            modelBuilder.Entity<ARTF>()
                .Property(e => e.iARTF_PESO)
                .HasPrecision(3, 2);

            modelBuilder.Entity<UBCI>()
                .Property(e => e.iUBCI_CODIGOFMT)
                .HasPrecision(2, 0);

            modelBuilder.Entity<UBCI>()
                .Property(e => e.iUBCI_DUN14)
                .HasPrecision(18, 0);

            modelBuilder.Entity<UBCI>()
                .Property(e => e.iUBCI_CANTIDAD)
                .HasPrecision(3, 0);

            modelBuilder.Entity<UBCI>()
                .Property(e => e.iUBCI_PESO)
                .HasPrecision(3, 2);

            modelBuilder.Entity<UBCM>()
                .HasMany(e => e.UBCI)
                .WithRequired(e => e.UBCM)
                .HasForeignKey(e => new { e.sUBCI_ALMACEN, e.sUBCI_ZONA, e.sUBCI_ESTANTERIA, e.sUBCI_PROFUNDIDAD, e.sUBCI_ALTURA });
        }
    }
}
