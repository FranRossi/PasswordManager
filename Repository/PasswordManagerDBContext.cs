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
        }
    }
}
