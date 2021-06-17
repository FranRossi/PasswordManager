using Obligatorio1_DA1.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CategoryTypeConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryTypeConfiguration()
        {
            this.Property(category => category.Name).IsRequired();
            this.Property(category => category.Name).HasMaxLength(15);
        }
    }
}
