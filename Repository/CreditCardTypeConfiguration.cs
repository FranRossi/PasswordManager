using Obligatorio1_DA1.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CreditCardTypeConfiguration : EntityTypeConfiguration<CreditCard>
    {
        public CreditCardTypeConfiguration()
        {
            this.Property(card => card.Number).IsRequired();
            this.Property(card => card.Name).IsRequired();
            this.Property(card => card.Type).IsRequired();
            this.Property(card => card.SecureCode).IsRequired();
            this.Property(card => card.ExpirationDate).IsRequired();

            this.Property(card => card.Number).HasMaxLength(16);
            this.Property(card => card.Name).HasMaxLength(25);
            this.Property(card => card.Type).HasMaxLength(25);
            this.Property(card => card.SecureCode).HasMaxLength(3);
            this.Property(card => card.ExpirationDate).HasMaxLength(5);
        }
    }
}
