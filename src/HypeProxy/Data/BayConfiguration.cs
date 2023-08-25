using HypeProxy.Entities.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HypeProxy.Data;

public class BayConfiguration : IEntityTypeConfiguration<Bay>
{
    public void Configure(EntityTypeBuilder<Bay> builder)
    {
        builder
            .HasMany(bay => bay.ComputeUnits)
            .WithOne(computeUnit => computeUnit.Bay)
            .HasForeignKey(computeUnit => computeUnit.BayId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}