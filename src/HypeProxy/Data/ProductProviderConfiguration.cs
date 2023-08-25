using HypeProxy.Entities.Joins;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HypeProxy.Data;

public class ProductProviderConfiguration: IEntityTypeConfiguration<ProductProvider>
{
    public void Configure(EntityTypeBuilder<ProductProvider> builder)
    {
        // builder.HasKey(productProvider => new { productProvider.ProductId, productProvider.ProviderId });
        //
        // builder
        //     .HasOne(productProvider => productProvider.Product)
        //     .WithMany(product => product.Providers)
        //     .HasForeignKey(productProvider => productProvider.ProductId);
        //
        // builder
        //     .HasOne(productProvider => productProvider.Provider)
        //     .WithMany(location => location.Products)
        //     .HasForeignKey(productProvider => productProvider.ProviderId);
    }
}