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
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }

        public PasswordManagerDBContext() : base("name=PasswordManagerDB") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserTypeConfiguration());
            modelBuilder.Configurations.Add(new PasswordTypeConfiguration());
            modelBuilder.Configurations.Add(new CreditCardTypeConfiguration());
            modelBuilder.Configurations.Add(new CategoryTypeConfiguration());
            modelBuilder.Entity<Password>().ToTable("Passwords");
            modelBuilder.Entity<CreditCard>().ToTable("CreditCards");

            modelBuilder.Entity<Password>()
               .HasRequired<User>(pass => pass.User)
               .WithMany();
            modelBuilder.Entity<CreditCard>()
                .HasRequired<User>(card => card.User)
                .WithMany();

            modelBuilder.Entity<Item>()
                .HasRequired<User>(item => item.User)
                .WithMany();
            
            modelBuilder.Entity<Item>()
               .HasRequired<Category>(item => item.Category)
                .WithMany()
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Category>()
              .HasRequired<User>(cat => cat.User);
            /*            modelBuilder.Entity<User>()
                            .HasMany<Category>(user => user.Categories)
                            .WithRequired();*/
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