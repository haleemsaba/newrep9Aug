namespace webgithubdemo.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class customerdbmodel : DbContext
    {
        public customerdbmodel()
            : base("name=customerdbmodel")
        {
        }

        public virtual DbSet<customer> customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<customer>()
                .Property(e => e.CustID)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.CustName)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.Phone)
                .IsUnicode(false);
        }
    }
}
