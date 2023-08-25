using HypeProxy.Entities.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HypeProxy.Data;

public class ComputeUnitConfiguration : IEntityTypeConfiguration<ComputeUnit>
{
    public void Configure(EntityTypeBuilder<ComputeUnit> builder)
    {
        builder
            .HasMany(computeUnit => computeUnit.Proxies)
            .WithOne(proxy => proxy.ComputeUnit)
            .HasForeignKey(proxy => proxy.ComputeUnitId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}