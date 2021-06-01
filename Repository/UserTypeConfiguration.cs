using Obligatorio1_DA1.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserTypeConfiguration : EntityTypeConfiguration<User>
    {
        public UserTypeConfiguration()
        {
            this.HasKey(user => user.Name);
            this.Property(user => user.Name).HasMaxLength(25);
            this.Property(user => user.MasterPass).HasMaxLength(25);
            this.Property(user => user.MasterPass).IsRequired();
        }
    }
}
