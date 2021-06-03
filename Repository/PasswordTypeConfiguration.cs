using Obligatorio1_DA1.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PasswordTypeConfiguration : EntityTypeConfiguration<Password>
    {
        public PasswordTypeConfiguration()
        {
            this.Property(pass => pass.LastModification).IsRequired();
            this.Property(pass => pass.Notes).IsOptional();
            this.Property(pass => pass.Pass).IsRequired();
            this.Property(pass => pass.PasswordStrength).IsRequired();
            this.Property(pass => pass.Site).IsRequired();
            this.Property(pass => pass.Username).IsRequired();

            this.Property(pass => pass.Notes).HasMaxLength(250);
            this.Property(pass => pass.Pass).HasMaxLength(25);
            this.Property(pass => pass.Site).HasMaxLength(25);
            this.Property(pass => pass.Username).HasMaxLength(25);

        }
    }
}
