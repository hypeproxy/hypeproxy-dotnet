using HypeProxy.Entities.Proxies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HypeProxy.Data;

public class AuthorizedIpConfiguration : IEntityTypeConfiguration<AuthorizedIp>
{
    public void Configure(EntityTypeBuilder<AuthorizedIp> builder)
    {
        builder
            .HasOne(authorizedIp => authorizedIp.Credential)
            .WithMany(credential => credential.AuthorizedIps)
            .HasForeignKey(authorizedIp => authorizedIp.CredentialId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}