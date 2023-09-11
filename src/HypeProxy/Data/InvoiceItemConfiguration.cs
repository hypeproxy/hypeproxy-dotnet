using HypeProxy.Entities.Invoices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HypeProxy.Data;

public class InvoiceItemConfiguration : IEntityTypeConfiguration<InvoiceItem>
{
    public void Configure(EntityTypeBuilder<InvoiceItem> builder)
    {
        builder
            .Property(invoiceItem => invoiceItem.UnitPrice)
            .HasPrecision(18, 2);
        
        builder
            .Property(invoiceItem => invoiceItem.TotalAmount)
            .HasPrecision(18, 2);
    }
}