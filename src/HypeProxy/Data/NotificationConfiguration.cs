using HypeProxy.Constants;
using HypeProxy.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HypeProxy.Data;

public class NotificationConfiguration : IEntityTypeConfiguration<Notification>
{
    public void Configure(EntityTypeBuilder<Notification> builder)
    {
        builder
            .Property(d => d.Level)
            .HasConversion(new EnumToStringConverter<WarningLevels>());
        
        builder
            .Property(d => d.Icon)
            .HasConversion(new EnumToStringConverter<Icons>());
    }
}