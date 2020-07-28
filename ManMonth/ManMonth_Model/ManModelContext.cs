namespace ManMonth_Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ManModelContext : DbContext
    {
        public ManModelContext()
            : base("name=ManModelContext")
        {
        }

        public virtual DbSet<NewMan> NewMen { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NewMan>()
                .Property(e => e.NewTitle)
                .IsUnicode(false);

            modelBuilder.Entity<NewMan>()
                .Property(e => e.NewContent)
                .IsUnicode(false);

            modelBuilder.Entity<NewMan>()
                .Property(e => e.NewLevel)
                .IsUnicode(false);

            modelBuilder.Entity<NewMan>()
                .Property(e => e.NewWriter)
                .IsUnicode(false);
        }
    }
}
