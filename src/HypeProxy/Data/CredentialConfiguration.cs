using System.Text.Json;
using HypeProxy.Entities.Proxies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HypeProxy.Data;

[Obsolete]
public class CredentialConfiguration : IEntityTypeConfiguration<Credential>
{
    public void Configure(EntityTypeBuilder<Credential> builder)
    {
        builder
            .HasOne(credential => credential.Proxy)
            .WithOne(proxy => proxy.Credential)
            .HasForeignKey<Proxy>(proxy => proxy.CredentialId)
            .OnDelete(DeleteBehavior.NoAction);
         
        // builder
        //     .HasMany(product => product.Locations)
        //     .WithMany(location => location.Products)
        //     .UsingEntity(j => j.ToTable("ProductLocations"));
        
        // builder
        //     .Property(e => e.AuthorizedIps)
        //     .HasConversion(
        //         v => JsonSerializer.Serialize(v, new JsonSerializerOptions()),
        //         v => JsonSerializer.Deserialize<IEnumerable<string>>(v, new JsonSerializerOptions()), 
        //         new ValueComparer<IEnumerable<string>>((c1, c2) => c1.SequenceEqual(c2), c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())), c => c.AsEnumerable()));
    }
}