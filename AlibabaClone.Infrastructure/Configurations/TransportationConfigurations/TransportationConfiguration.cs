﻿using AlibabaClone.Domain.Aggregates.TransportationAggregates;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Infrastructure.Configurations.TransportationConfigurations
{
    public class TransportationConfiguration : IEntityTypeConfiguration<Transportation>
    {
        public void Configure(EntityTypeBuilder<Transportation> builder)
        {
            builder.ToTable("Transportation");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.FromLocationId)
                   .IsRequired();

            builder.Property(t => t.ToLocationId)
                   .IsRequired();

            builder.Property(t => t.CompanyId)
                   .IsRequired();

            builder.Property(t => t.Vehicle)
                   .IsRequired();

            builder.Property(t => t.StartDateTime)
                   .IsRequired();

            builder.Property(t => t.EndDateTime)
                   .IsRequired();

            builder.Property(t => t.SerialNumber)
                   .IsRequired()
                   .HasMaxLength(63)
                   .IsUnicode(false);

            builder.Property(t => t.RemainingCapacity)
                   .IsRequired();

            builder.Property(t => t.BasePrice)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(t => t.VIPPrice)
                   .HasColumnType("decimal(18,2)");


            builder.HasOne(t => t.FromLocation)
                   .WithMany()
                   .HasForeignKey(t => t.FromLocationId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.ToLocation)
                   .WithMany()
                   .HasForeignKey(t => t.ToLocationId)
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
