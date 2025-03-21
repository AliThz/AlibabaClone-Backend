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
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.ToTable("Vehicle");
            builder.HasKey(v => v.Id);

            builder.Property(v => v.Title)
                   .IsRequired()
                   .HasMaxLength(127);

            builder.Property(v => v.VehicleTypeId)
                   .IsRequired();

            builder.Property(v => v.Capacity)
                   .IsRequired();

            builder.Property(v => v.PlateNumber)
                   .IsRequired()
                   .HasMaxLength(63);
            builder.HasIndex(v => v.PlateNumber)
                   .IsUnique();


            builder.HasOne(v => v.VehicleType)
                   .WithMany()
                   .HasForeignKey(v => v.VehicleTypeId)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
