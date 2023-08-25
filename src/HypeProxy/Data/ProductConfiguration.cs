using System.Text.Json;
using HypeProxy.Constants;
using HypeProxy.Entities;
using HypeProxy.Entities.Joins;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HypeProxy.Data;

public class ProductConfiguration: IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder
            .HasMany(product => product.Locations)
            .WithMany(location => location.Products)
            .UsingEntity(j => j.ToTable("ProductLocations"));
        
        builder
            .HasMany(product => product.Features)
            .WithMany(feature => feature.Products)
            .UsingEntity(j => j.ToTable("ProductFeatures"));
        
        builder
            .HasMany(product => product.Providers)
            .WithMany(provider => provider.Products)
            .UsingEntity(j => j.ToTable("ProductProviders"));
        
        // builder
        //     .HasMany(product => product.Features)
        //     .WithMany(feature => feature.Products)
        //     .UsingEntity<ProductFeature>("ProductFeatures");
        
        // builder
        //     .HasMany(product => product.Features)
        //     .WithMany(feature => feature.Products);
        
        // builder
        //     .HasMany(product => product.Features)
        //     .WithOne(feature => feature.Product)
        //     .HasForeignKey(feature => feature.ProductId)
        //     .OnDelete(DeleteBehavior.NoAction);

        // var valueComparerForBillingPeriodsEnumerable = new ValueComparer<IEnumerable<BillingCycles>>((c1, c2) => c1.SequenceEqual(c2), c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())), c => c.AsEnumerable());
        //
        // builder.Property(e => e.AvailableBillingCycles)
        //     .HasConversion(
        //     convertToProviderExpression: v => JsonSerializer.Serialize(v, new JsonSerializerOptions()), 
        //     convertFromProviderExpression: v => JsonSerializer.Deserialize<IEnumerable<BillingCycles>>(v, new JsonSerializerOptions()), 
        //     valueComparer: valueComparerForBillingPeriodsEnumerable);
    }
}