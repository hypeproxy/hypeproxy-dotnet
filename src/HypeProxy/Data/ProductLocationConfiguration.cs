using HypeProxy.Entities.Joins;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HypeProxy.Data;

public class ProductLocationConfiguration: IEntityTypeConfiguration<ProductLocation>
{
    public void Configure(EntityTypeBuilder<ProductLocation> builder)
    {
        // builder.HasKey(productLocation => new { productLocation.ProductId, productLocation.LocationId });
        //
        // builder
        //     .HasOne(productLocation => productLocation.Product)
        //     .WithMany(product => product.Locations)
        //     .HasForeignKey(productLocation => productLocation.ProductId);
        //
        // builder
        //     .HasOne(productLocation => productLocation.Location)
        //     .WithMany(location => location.Products)
        //     .HasForeignKey(productLocation => productLocation.LocationId);
    }
}