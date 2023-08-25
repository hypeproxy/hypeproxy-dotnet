using System.Text.Json.Serialization;
using HypeProxy.Constants;
using HypeProxy.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HypeProxy.Data;

public class PurchaseConfiguration : IEntityTypeConfiguration<Purchase>
{
    public void Configure(EntityTypeBuilder<Purchase> builder)
    {
        builder
            .HasMany(purchase => purchase.Invoices)
            .WithOne(invoice => invoice.Purchase)
            .HasForeignKey(invoice => invoice.PurchaseId)
            .OnDelete(DeleteBehavior.NoAction);
        
        // builder
        //     .HasOne(purchase => purchase.Product)
        //     .WithMany()
        //     .HasForeignKey(purchase => purchase.ProductId);
        
        builder
            .Property(d => d.Status)
            .HasConversion(new EnumToStringConverter<PurchaseStatuses>());
        
        builder
            .Property(d => d.PaymentMethod)
            .HasConversion(new EnumToStringConverter<PaymentMethods>());
        
        builder
            .Property(d => d.BillingCycle)
            .HasConversion(new EnumToStringConverter<BillingCycles>());
    }
}