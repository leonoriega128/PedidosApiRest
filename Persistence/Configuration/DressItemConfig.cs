using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configuration
{
    public class DressItemConfig : IEntityTypeConfiguration<DressItem>
    {
        public void Configure(EntityTypeBuilder<DressItem> builder)
        {
            builder.ToTable("DressItem");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .HasMaxLength(100);
            builder.Property(x => x.Price) 
                .HasMaxLength(100);
        }

    }
}
