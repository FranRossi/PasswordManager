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
            this.HasKey(user => user.MasterName);
            this.Property(user => user.MasterName).HasMaxLength(25);
            this.Property(user => user.MasterPass).IsRequired();
        }
    }
}
