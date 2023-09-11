using HypeProxy.Constants;
using HypeProxy.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HypeProxy.Data;

public class UserSettingsConfiguration : IEntityTypeConfiguration<UserSettings>
{
    public void Configure(EntityTypeBuilder<UserSettings> builder)
    {
        builder
            .Property(userSettings => userSettings.DefaultBillingCycle)
            .HasConversion(new EnumToStringConverter<BillingCycles>());
        
        builder
            .Property(userSettings => userSettings.DefaultPaymentMethod)
            .HasConversion(new EnumToStringConverter<PaymentMethods>());
    }
}