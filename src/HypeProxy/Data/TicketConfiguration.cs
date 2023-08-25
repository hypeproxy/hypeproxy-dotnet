using HypeProxy.Constants;
using HypeProxy.Entities.Tickets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HypeProxy.Data;

public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
{
    public void Configure(EntityTypeBuilder<Ticket> builder)
    {
        builder
            .HasMany(ticket => ticket.Answers)
            .WithOne(ticketAnswer => ticketAnswer.Ticket)
            .HasForeignKey(ticketAnswer => ticketAnswer.TicketId)
            .OnDelete(DeleteBehavior.Cascade);
        
        // builder
        //     .HasMany(ticket => ticket.Answers)
        //     .WithOne(ticketAnswer => ticketAnswer.AnswerUser)
        
        builder
            .Property(d => d.Priority)
            .HasConversion(new EnumToStringConverter<TicketPriorities>());
    }
}