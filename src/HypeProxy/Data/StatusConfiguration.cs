using System.Text.Json.Serialization;
using HypeProxy.Constants;
using HypeProxy.Entities.Statuses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HypeProxy.Data;

public class StatusConfiguration : IEntityTypeConfiguration<Status>
{
    public void Configure(EntityTypeBuilder<Status> builder)
    {
        builder
            .HasOne(status => status.RequestDetails)
            .WithOne(requestDetails => requestDetails.Status)
            .HasForeignKey<RequestDetail>(requestDetails => requestDetails.StatusId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder
            .Property(status => status.Level)
            .HasConversion(new EnumToStringConverter<WarningLevels>());
        
        // builder
        //     .Property(status => status.Icon)
        //     .HasConversion(new EnumToStringConverter<Icons>());
    }
}