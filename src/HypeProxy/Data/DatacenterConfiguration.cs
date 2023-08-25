using HypeProxy.Entities.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HypeProxy.Data;

public class DatacenterConfiguration : IEntityTypeConfiguration<Datacenter>
{
    public void Configure(EntityTypeBuilder<Datacenter> builder)
    {
        builder
            .HasMany(datacenter => datacenter.Bays)
            .WithOne(bay => bay.Datacenter)
            .HasForeignKey(bay => bay.DatacenterId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}