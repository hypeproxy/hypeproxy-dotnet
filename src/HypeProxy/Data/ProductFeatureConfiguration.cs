using HypeProxy.Entities.Joins;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HypeProxy.Data;

public class ProductFeatureConfiguration: IEntityTypeConfiguration<ProductFeature>
{
    public void Configure(EntityTypeBuilder<ProductFeature> builder)
    {
        // builder.HasKey(productFeature => new { productFeature.ProductId, productFeature.FeatureId });
        //
        // builder
        //     .HasOne(productFeature => productFeature.Product)
        //     .WithMany(product => product.Features)
        //     .HasForeignKey(productFeature => productFeature.ProductId);
        //
        // builder
        //     .HasOne(productFeature => productFeature.Feature)
        //     .WithMany(feature => feature.Products)
        //     .HasForeignKey(productFeature => productFeature.FeatureId);
    }
}