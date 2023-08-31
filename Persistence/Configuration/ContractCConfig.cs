using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class ContractCConfig : IEntityTypeConfiguration<ContractC>
    {
        public void Configure(EntityTypeBuilder<ContractC> builder) 
        {
            builder.ToTable("ContractC");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ContractId)
                .IsRequired();
            builder.Property(x => x.ItemId)
                .IsRequired();
            builder.Property(x => x.CreatedDate)
                .IsRequired();
            builder.Property(x => x.UpdateDate)
                .HasMaxLength(100);
            builder.Property(x=> x.Enabled)
                .IsRequired();
            builder.Property(x=> x.Deleted)
                .IsRequired();
            builder.Property(x => x.CreatedBy)
                .HasMaxLength(100);

        }
    }
}
