using HypeProxy.Constants;
using HypeProxy.Entities;
using HypeProxy.Entities.Joins;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HypeProxy.Data;

public class FeatureConfiguration : IEntityTypeConfiguration<Feature>
{
    public void Configure(EntityTypeBuilder<Feature> builder)
    {
        // builder
        //     .Property(d => d.Type)
        //     .HasConversion(new EnumToStringConverter<FeatureTypes>());
        
        // builder
        //     .HasMany(feature => feature.Products)
        //     .WithMany(product => product.Features)
        //     .UsingEntity<ProductFeature>("ProductFeatures");
    }
}