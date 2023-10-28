using System.Text.Json;
using HypeProxy.Entities.Proxies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HypeProxy.Data;

public class CredentialConfiguration : IEntityTypeConfiguration<Credential>
{
    public void Configure(EntityTypeBuilder<Credential> builder)
    {
        builder
            .HasOne(credential => credential.Proxy)
            .WithOne(proxy => proxy.Credential)
            .HasForeignKey<Proxy>(proxy => proxy.CredentialId)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .Property(e => e.AuthorizedIps)
            .HasConversion(
                authorizedIps => JsonSerializer.Serialize(authorizedIps, new JsonSerializerOptions()),
                authorizedIp => JsonSerializer.Deserialize<IEnumerable<string>>(authorizedIp, new JsonSerializerOptions()), 
                new ValueComparer<IEnumerable<string>>((c1, c2) => c2 != null && c1 != null && c1.SequenceEqual(c2), c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())), c => c.AsEnumerable()));
    }
}