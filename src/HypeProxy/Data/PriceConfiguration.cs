using HypeProxy.Constants;
using HypeProxy.Entities.Prices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HypeProxy.Data;

public class PriceConfiguration : IEntityTypeConfiguration<Price>
{
    public void Configure(EntityTypeBuilder<Price> builder)
    {
        builder
            .HasOne(price => price.Product)
            .WithMany(product => product.Prices)
            .HasForeignKey(price => price.ProductId)
            .OnDelete(DeleteBehavior.NoAction);
        
        // builder
        //     .HasOne(p => p.Product)
        //     .WithMany()
        //     .HasForeignKey(p => p.ProductId)
        //     .OnDelete(DeleteBehavior.Restrict);
        
        builder
            .HasMany(price => price.PriceTiers)
            .WithOne(priceTier => priceTier.Price)
            .HasForeignKey(priceTier => priceTier.PriceId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder
            .Property(d => d.PaymentMethod)
            .HasConversion(new EnumToStringConverter<PaymentMethods>());
        
        builder
            .Property(d => d.BillingCycle)
            .HasConversion(new EnumToStringConverter<BillingCycles>());
    }
}