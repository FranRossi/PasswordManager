using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Obligatorio1_DA1.Domain;

namespace Repository
{
    public class PasswordManagerDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Password> Passwords { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }

        public PasswordManagerDBContext() : base("name=PasswordManagerDB") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserTypeConfiguration());
            modelBuilder.Configurations.Add(new PasswordTypeConfiguration());
            modelBuilder.Configurations.Add(new CreditCardTypeConfiguration());
            modelBuilder.Entity<CreditCard>()
                .HasRequired<User>(pass => pass.User)
                .WithMany();
            modelBuilder.Entity<Password>()
                .HasRequired<User>(pass => pass.User)
                .WithMany();
            /*modelBuilder.Entity<Password>()
                .HasRequired(pass => pass.SharedWith)
                .WithMany()
                .WillCascadeOnDelete(false);*/
            modelBuilder.Entity<Password>()
                .HasMany<User>(pass => pass.SharedWith)
                .WithMany()
                .Map(m =>
                {
                    m.MapLeftKey("PasswordId");
                    m.MapRightKey("UserSharedWithName");
                    m.ToTable("SharedPasswordUser");
                });
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            //modelBuilder.Entity<Password>().HasMany<User>(pass => pass.SharedWith).WithMany();
        }
    }
}
