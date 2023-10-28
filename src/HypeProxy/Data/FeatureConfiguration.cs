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
        builder
            .Property(feature => feature.Tag)
            .HasConversion(new EnumToStringConverter<FeatureTags>());
        
        // builder
        //     .HasMany(feature => feature.Products)
        //     .WithMany(product => product.Features)
        //     .UsingEntity<ProductFeature>("ProductFeatures");
    }
}