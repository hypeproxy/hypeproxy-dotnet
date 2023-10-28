using HypeProxy.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HypeProxy.Data;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder
            .HasOne(user => user.BillingDetails)
            .WithOne(billingDetails => billingDetails.User)
            .HasForeignKey<User>(user => user.BillingDetailsId)
            .OnDelete(DeleteBehavior.NoAction);
        
        // builder
        //     .HasMany(user => user.Invoices)
        //     .WithOne(invoice => invoice.User)
        //     .HasForeignKey(invoice => invoice.UserId)
        //     .OnDelete(DeleteBehavior.NoAction);
        
        builder
            .HasMany(user => user.Purchases)
            .WithOne(purchase => purchase.User)
            .HasForeignKey(purchase => purchase.UserId)
            .OnDelete(DeleteBehavior.NoAction);
        
        builder
            .HasMany(user => user.Notifications)
            .WithOne(notification => notification.User)
            .HasForeignKey(notification => notification.UserId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder
            .HasMany(user => user.Reminders)
            .WithOne(reminder => reminder.User)
            .HasForeignKey(reminder => reminder.UserId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder
            .HasMany(user => user.Memos)
            .WithOne(memo => memo.User)
            .HasForeignKey(memo => memo.UserId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder
            .HasMany(user => user.Statuses)
            .WithOne(status => status.User)
            .HasForeignKey(status => status.UserId)
            .OnDelete(DeleteBehavior.NoAction);
        
        builder
            .HasMany(user => user.Tickets)
            .WithOne(ticket => ticket.User)
            .HasForeignKey(ticket => ticket.UserId)
            .OnDelete(DeleteBehavior.NoAction);
        
        builder
            .HasMany(user => user.TicketAnswers)
            .WithOne(ticketAnswer => ticketAnswer.User)
            .HasForeignKey(ticketAnswer => ticketAnswer.UserId)
            .OnDelete(DeleteBehavior.NoAction);
        
        
        // builder
        //     .HasOne(user => user.Authorization)
        //     .WithOne()
        //     .HasForeignKey<AuthorizationDetails>(ad => ad.UserId)
        //     .OnDelete(DeleteBehavior.NoAction);
        //
        // builder
        //     .HasOne(user => user.BillingDetails)
        //     .WithOne()
        //     .HasForeignKey<BillingDetails>(bd => bd.UserId)
        //     .OnDelete(DeleteBehavior.NoAction);
        //
        // builder
        //     .HasOne(user => user.Compliance)
        //     .WithOne()
        //     .HasForeignKey<ComplianceDetails>(cd => cd.UserId)
        //     .OnDelete(DeleteBehavior.NoAction);
        //
        // builder
        //     .HasOne(user => user.Settings)
        //     .WithOne()
        //     .HasForeignKey<UserSettings>(us => us.UserId)
        //     .OnDelete(DeleteBehavior.NoAction);
    }
}