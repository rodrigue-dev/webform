using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace webschool
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<LOCAL> LOCALs { get; set; }
        public virtual DbSet<METIER> METIERs { get; set; }
        public virtual DbSet<PROFESSEUR> PROFESSEURs { get; set; }
        public virtual DbSet<SECTEUR> SECTEURs { get; set; }
        public virtual DbSet<SECTION> SECTIONs { get; set; }
        public virtual DbSet<SESSIONUE> SESSIONUEs { get; set; }
        public virtual DbSet<UE> UEs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LOCAL>()
                .Property(e => e.LIEU)
                .IsUnicode(false);

            modelBuilder.Entity<LOCAL>()
                .HasMany(e => e.SESSIONUEs)
                .WithMany(e => e.LOCALs)
                .Map(m => m.ToTable("LOCALISER").MapLeftKey("IDLOCAL").MapRightKey("IDSESSIONUE"));

            modelBuilder.Entity<METIER>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<METIER>()
                .HasMany(e => e.SECTIONs)
                .WithMany(e => e.METIERs)
                .Map(m => m.ToTable("DEBOUCHER").MapLeftKey("IDMETIER").MapRightKey("IDSECTION"));

            modelBuilder.Entity<PROFESSEUR>()
                .Property(e => e.NOM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PROFESSEUR>()
                .Property(e => e.PRENOM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PROFESSEUR>()
                .Property(e => e.EMAIL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SECTEUR>()
                .Property(e => e.INTITULE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SECTEUR>()
                .HasMany(e => e.SECTIONs)
                .WithRequired(e => e.SECTEUR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SECTION>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<SECTION>()
                .Property(e => e.IMAGESECTION)
                .IsUnicode(false);

            modelBuilder.Entity<UE>()
                .Property(e => e.TITRE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UE>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);
        }
    }
}
