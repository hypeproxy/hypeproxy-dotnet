using HypeProxy.Constants;
using HypeProxy.Entities.Invoices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HypeProxy.Data;

public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
{
    public void Configure(EntityTypeBuilder<Invoice> builder)
    {
        builder
            .HasMany(invoice => invoice.Items)
            .WithOne(item => item.Invoice)
            .HasForeignKey(item => item.InvoiceId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder
            .Property(invoice => invoice.Status)
            .HasConversion(new EnumToStringConverter<InvoiceStatuses>());
        
        builder
            .Property(invoice => invoice.PaymentMethod)
            .HasConversion(new EnumToStringConverter<PaymentMethods>());
        
        builder
            .Property(invoice => invoice.SubtotalAmount)
            .HasPrecision(18, 2);
        
        builder
            .Property(invoice => invoice.TotalAmount)
            .HasPrecision(18, 2);
    }
}