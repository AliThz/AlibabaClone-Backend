using AlibabaClone.Domain.Aggregates.TransportationAggregates;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Infrastructure.Configurations.TransportationConfigurations
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.ToTable("Ticket");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.TransportationId)
                   .IsRequired();

            builder.Property(t => t.SeatId)
                   .IsRequired();

            builder.Property(t => t.BuyerId)
                   .IsRequired();

            builder.Property(t => t.TravelerId)
                   .IsRequired();

            builder.Property(t => t.CompanionId)
                   .IsRequired(false);

            builder.Property(t => t.TicketStatusId)
                .IsRequired();

            builder.Property(t => t.SerialNumber)
                   .IsRequired()
                   .HasMaxLength(255)
                   .IsUnicode(false);

            builder.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);


            builder.HasOne(t => t.Transportation)
                   .WithMany(tr => tr.Tickets)
                   .HasForeignKey(t => t.TransportationId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.Seat)
                   .WithMany(s => s.Tickets)
                   .HasForeignKey(t => t.SeatId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.Buyer)
                   .WithMany(a => a.BoughtTickets)
                   .HasForeignKey(t => t.BuyerId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.Traveler)
                   .WithMany(p => p.TraveledTickets)
                   .HasForeignKey(t => t.TravelerId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.Companion)
                   .WithMany()
                   .HasForeignKey(t => t.CompanionId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.TicketStatus)
                   .WithMany()
                   .HasForeignKey(t => t.TicketStatusId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
