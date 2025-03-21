using AlibabaClone.Domain.Aggregates.VehicleAggregates;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Infrastructure.Configurations.VehicleConfigurations
{
    public class SeatConfiguration : IEntityTypeConfiguration<Seat>
    {
        public void Configure(EntityTypeBuilder<Seat> builder)
        {
            builder.ToTable("Seat");
            builder.HasKey(s => s.Id);

            builder.Property(s => s.VehicleId)
                   .IsRequired();

            builder.Property(s => s.Row)
                   .IsRequired();

            builder.Property(s => s.Column)
                   .IsRequired();

            builder.Property(s => s.IsVIP)
                   .IsRequired();

            builder.Property(s => s.IsAvailable)
                   .IsRequired();


            builder.HasOne(s => s.Vehicle)
                   .WithMany(v => v.Seats)
                   .HasForeignKey(s => s.VehicleId)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
