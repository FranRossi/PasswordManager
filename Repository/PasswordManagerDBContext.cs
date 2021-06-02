using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Obligatorio1_DA1.Domain;

namespace Repository
{
    class PasswordManagerDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public PasswordManagerDBContext() : base("name=PasswordManagerDB") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserTypeConfiguration());
            modelBuilder.Configurations.Add(new PasswordTypeConfiguration());

            modelBuilder.Entity<Password>()
                .HasRequired<User>(pass => pass.User)
                .WithMany();
            modelBuilder.Entity<Password>()
                .HasRequired(pass => pass.SharedWith)
                .WithMany()
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Password>()
                .HasMany<User>(pass => pass.SharedWith)
                .WithMany()
                .Map(m =>
                {
                    m.MapLeftKey("PasswordId");
                    m.MapRightKey("UserSharedWithName");
                    m.ToTable("SharedPasswordUser");
                });
        }
    }
}
