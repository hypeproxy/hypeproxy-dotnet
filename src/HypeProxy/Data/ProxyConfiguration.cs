using HypeProxy.Entities.Features;
using HypeProxy.Entities.Proxies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HypeProxy.Data;

public class ProxyConfiguration: IEntityTypeConfiguration<Proxy>
{
    public void Configure(EntityTypeBuilder<Proxy> builder)
    {
        builder
            .HasOne(proxy => proxy.Provider)
            .WithMany(provider => provider.Proxies)
            .HasForeignKey(proxy => proxy.ProviderId)
            .OnDelete(DeleteBehavior.NoAction);
        
        builder
            .HasOne(proxy => proxy.IpRotation)
            .WithOne(ipRotation => ipRotation.Proxy)
            .HasForeignKey<IpRotation>(ipRotation => ipRotation.ProxyId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder
            .HasOne(proxy => proxy.Purchase)
            .WithMany(proxy => proxy.Proxies)
            .HasForeignKey(proxy => proxy.PurchaseId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}