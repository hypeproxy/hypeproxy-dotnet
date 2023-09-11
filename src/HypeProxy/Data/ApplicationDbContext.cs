using System.ComponentModel;
using HypeProxy.Entities;
using HypeProxy.Entities.Features;
using HypeProxy.Entities.Infrastructure;
using HypeProxy.Entities.Invoices;
using HypeProxy.Entities.Prices;
using HypeProxy.Entities.Proxies;
using HypeProxy.Entities.Statuses;
using HypeProxy.Entities.Tickets;
using HypeProxy.Entities.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HypeProxy.Data;

[EditorBrowsable(EditorBrowsableState.Never)]
public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<Datacenter> Datacenters { get; set; }
    public DbSet<Bay> Bays { get; set; }
    public DbSet<ComputeUnit> ComputeUnits { get; set; }

    public DbSet<Product> Products { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Provider> Providers { get; set; }
    public DbSet<Feature> Features { get; set; }
    
    public DbSet<Purchase> Purchases { get; set; }
    public DbSet<Price> Prices { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<Coupon> Coupons { get; set; }
    
    public DbSet<Proxy> Proxies { get; set; }
    public DbSet<Credential> Credentials { get; set; }
    public DbSet<AuthorizedIp> AuthorizedIps { get; set; }
    public DbSet<IpRotation> IpRotations { get; set; }
    
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<TicketAnswer> TicketAnswers { get; set; }

    public DbSet<Notification> Notifications { get; set; }
    public DbSet<Reminder> Reminders { get; set; }
    public DbSet<Memo> Memos { get; set; }
    
    public DbSet<Status> Statuses { get; set; }
    public DbSet<RequestDetail> RequestDetails { get; set; }
    
    // Joins
    // public DbSet<ProductFeature> ProductFeatures { get; set; }
    // public DbSet<ProductLocation> ProductLocations { get; set; }
    // public DbSet<ProductProvider> ProductProviders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new UserSettingsConfiguration());
        modelBuilder.ApplyConfiguration(new DatacenterConfiguration());
        modelBuilder.ApplyConfiguration(new BayConfiguration());
        modelBuilder.ApplyConfiguration(new ComputeUnitConfiguration());
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new LocationConfiguration());
        modelBuilder.ApplyConfiguration(new ProviderConfiguration());
        modelBuilder.ApplyConfiguration(new FeatureConfiguration());
        modelBuilder.ApplyConfiguration(new PurchaseConfiguration());
        modelBuilder.ApplyConfiguration(new ProxyConfiguration());
        modelBuilder.ApplyConfiguration(new CredentialConfiguration());
        modelBuilder.ApplyConfiguration(new AuthorizedIpConfiguration());
        modelBuilder.ApplyConfiguration(new PriceConfiguration());
        modelBuilder.ApplyConfiguration(new InvoiceConfiguration());
        modelBuilder.ApplyConfiguration(new InvoiceItemConfiguration());
        modelBuilder.ApplyConfiguration(new TicketConfiguration());
        modelBuilder.ApplyConfiguration(new StatusConfiguration());
        modelBuilder.ApplyConfiguration(new NotificationConfiguration());

        // modelBuilder.ApplyConfiguration(new ProductFeatureConfiguration());
        // modelBuilder.ApplyConfiguration(new ProductLocationConfiguration());
        // modelBuilder.ApplyConfiguration(new ProductProviderConfiguration());
        
        base.OnModelCreating(modelBuilder);
    }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     if (!optionsBuilder.IsConfigured)
    //     {
    //         // Replace "YourMigrationsProjectName" with the actual name of the project containing the migrations.
    //         optionsBuilder.UseSqlServer(connection, b => b.MigrationsAssembly("YourMigrationsProjectName"));
    //     }
    //     base.OnConfiguring(optionsBuilder);
    // }
}