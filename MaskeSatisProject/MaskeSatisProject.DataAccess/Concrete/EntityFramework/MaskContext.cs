namespace MaskeSatisProject.Entities.Concrete
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MaskContext : DbContext
    {
        public MaskContext()
            : base("name=MaskContext")
        {
        }

        public virtual DbSet<MaskTable> MaskTable { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .Property(e => e.TcNo)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .HasMany(e => e.MaskTable)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);
        }
    }
}
