using HypeProxy.Constants;
using HypeProxy.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HypeProxy.Data;

public class LocationConfiguration : IEntityTypeConfiguration<Location>
{
    public void Configure(EntityTypeBuilder<Location> builder)
    {
        builder
            .HasMany(location => location.Providers)
            .WithMany(provider => provider.Locations)
            .UsingEntity(j => j.ToTable("LocationProviders"));
        
        builder
            .HasMany(location => location.Datacenters)
            .WithOne(datacenter => datacenter.Location)
            .HasForeignKey(datacenter => datacenter.LocationId);
        
        builder
            .Property(location => location.CountryCode)
            .HasConversion(new EnumToStringConverter<CountryCodes>());
    }
}